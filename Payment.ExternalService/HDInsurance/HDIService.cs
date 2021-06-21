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

        public bool Login(LoginRequest request, out string token, out string errorMessage);
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
            bool loginResult = Login(new LoginRequest(true), out string token, out string errorMessage);

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

        public bool Login(LoginRequest request, out string token, out string errorMessage)
        {
            bool result = false;
            token = string.Empty;
            errorMessage = string.Empty;

            using (var client = httpClientFactory.CreateClient())
            {
                var url = "OpenApi/Login";
                client.BaseAddress = new Uri(AppGlobal.HDInsurance_Url);
                var content = JsonConvert.SerializeObject(request);
                var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
              
                var response = client.PostAsync(url, httpContent).Result;

                if(response.IsSuccessStatusCode)
                {
                    result = true;
                }
                else
                {
                    errorMessage = response.ReasonPhrase;
                    result = false;
                }
            }

            return result;
        }
    }
}
