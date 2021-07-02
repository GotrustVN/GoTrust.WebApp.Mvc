using AutoMapper;
using HDIClient.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Payment.Data.Context;
using Payment.Data.Entities;
using Payment.Data.Extensions;
using Payment.Data.Repositories;
using Payment.ExternalService;
using Payment.NetCoreExtension;
using Payment.SharedModel.Common;
using Payment.SharedUltilities.Extensions;
using Payment.SharedUltilities.Global;
using Payment.SharedUltilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HDIClient.MVC.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IVNPayService vnpayService;
        private readonly IGenericRepository<OrderInfor> genericOrderInforRepository;
        private readonly IGenericRepository<OrderType> genericOrderTypeRepository;
        private readonly IGenericRepository<OrderStatus> genericOrderStatusRepository;
        private readonly IGenericRepository<Bank> genericBankRepository;
        private readonly IGenericRepository<Language> genericLanguageRepository;
        private readonly IGenericRepository<PaymentLog> genericPaymentLogRepository;
        private readonly IHealthInsuranceOrderRepository healthInsuranceOrderRepository;
        private readonly IMapper mapper;
        private readonly AppDbContext context;

        public PaymentController(IVNPayService vnpayService,
            IGenericRepository<OrderInfor> genericOrderInforRepository,
            IGenericRepository<OrderType> genericOrderTypeRepository,
            IGenericRepository<OrderStatus> genericOrderStatusRepository,
            IGenericRepository<Bank> genericBankRepository,
            IGenericRepository<Language> genericLanguageRepository,
            IGenericRepository<PaymentLog> genericPaymentLogRepository,
            IHealthInsuranceOrderRepository healthInsuranceOrderRepository,
            IMapper mapper,
            AppDbContext context)
        {
            this.vnpayService = vnpayService;
            this.genericOrderInforRepository = genericOrderInforRepository;
            this.genericOrderTypeRepository = genericOrderTypeRepository;
            this.genericOrderStatusRepository = genericOrderStatusRepository;
            this.genericBankRepository = genericBankRepository;
            this.genericLanguageRepository = genericLanguageRepository;
            this.genericPaymentLogRepository = genericPaymentLogRepository;
            this.healthInsuranceOrderRepository = healthInsuranceOrderRepository;
            this.mapper = mapper;
            this.context = context;
        }
        public IActionResult Index(PaymentDetailViewModel model)
        {
            if (model.banks == null)
            {
                model.banks = genericBankRepository.Get();
            }

            if (model.orderTypes == null)
            {
                model.orderTypes = genericOrderTypeRepository.Get();
            }

            if (model.languages == null)
            {
                model.languages = genericLanguageRepository.Get();
            }

            return View(model);
        }

        public IActionResult PaymentRedirect(PaymentDetailViewModel order)
        {
            if (ModelState.IsValid)
            {
                if (!genericOrderTypeRepository.IsExistById(order.orderTypeCode, out OrderType orderType))
                {
                    ModelState.AddModelError("", "Invalid order type");
                    return View();
                }
                var orderInfor = mapper.Map<OrderInfor>(order);
                orderInfor.type = orderType;
                orderInfor.bank = genericBankRepository.GetByID(order.bankCode);

                var oderStatus = genericOrderStatusRepository.GetByID(AppGlobal.DefaultOrderStatusCode);

                orderInfor.SetDefaultValue();
                orderInfor.SetOrderStatus(oderStatus);

                genericOrderInforRepository.Insert(orderInfor);

                int result = context.SaveChanges();

                if (result > 0)
                {
                    var requestData = orderInfor.ToPaymentRequestData(HttpContext.GetClientIp(), order.languageCode);

                    string paymentRedirectUrl = vnpayService.GetPaymentRedirectUrl(requestData);
                    return Redirect(paymentRedirectUrl);
                }
                else
                {
                    return Json(new CommonResponse().GetCreateFailedResponse("order infor"));
                }
            }
            return View();
        }

        public IActionResult PaymentReturn(VNPPaymentReturnModel model)
        {
            var viewModel = new PaymentReturnViewModel()
            {
                isSuccess = false
            };

            if (model != null)
            {
                var responeData = model.ToSortedList(new VNPayCompare());
                var isValidSignature = SecurityHelper.ValidateSignature(responeData, model.vnp_SecureHash,
                    AppGlobal.VNP_HashSecret);

                if (isValidSignature)
                {
                    var orderInfor = genericOrderInforRepository.GetByID(model.vnp_TxnRef);

                    if (model.vnp_ResponseCode == "00")
                    {
                        viewModel.isSuccess = true;
                        viewModel.message = AppGlobal.DefaultPaymentSuccessMessage;

                        var paymentSuccessStatus = genericOrderStatusRepository.GetByID(AppGlobal.PaymentSuccessOrderStatusCode);
                        orderInfor.SetOrderStatus(paymentSuccessStatus);

                        var healthInsuranceOrder = healthInsuranceOrderRepository.GetById(orderInfor.refDocNo);
                        healthInsuranceOrder.status = "paid";
                    }
                    else
                    {
                        viewModel.message = "Mã lỗi: " + model.vnp_ResponseCode;
                        var paymentFailedStatus = genericOrderStatusRepository.GetByID(AppGlobal.PaymentFailOrderStatusCode);
                        orderInfor.SetOrderStatus(paymentFailedStatus);
                    }

                    var paymentLog = mapper.Map<PaymentLog>(model);
                    genericPaymentLogRepository.Insert(paymentLog);

                    context.SaveChanges();

                    if (viewModel.isSuccess)
                    {
                        return RedirectToAction("SendAfterPaid", "HealthInsuranceOrder",
                            new { orderCode = orderInfor.refDocNo });
                    }
                }
                viewModel.message = AppGlobal.DefaultInvalidSignatureMessage;
            }

            return View(viewModel);
        }
    }
}
