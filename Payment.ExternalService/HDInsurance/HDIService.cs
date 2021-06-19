using Newtonsoft.Json;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public interface IHDIService
    {
        public bool CreateOrder(HealthInsuranceOrderRequest request);
    }
    public class HDIService : IHDIService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HDIService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public bool CreateOrder(HealthInsuranceOrderRequest request)
        {
            using (var client = httpClientFactory.CreateClient())
            {
                var url = "OpenApi/v1/mask/insur/create_pay";
                client.BaseAddress = new Uri(AppGlobal.HDInsurance_Url);
                var httpContent = new StringContent(request.ToString(), Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
