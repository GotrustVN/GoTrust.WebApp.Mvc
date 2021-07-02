using Newtonsoft.Json;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Payment.ExternalService.HDInsurance
{
    public interface IHDIService
    {
        public bool CreateOrder(HealthInsuranceOrderRequest request, out string errorMessage,
            out HealthInsuranceReponseData reponseData);

        public bool Login(LoginRequest request, out string token, out string errorMessage);
    }
    public class HDIService : IHDIService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HDIService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public bool CreateOrder(HealthInsuranceOrderRequest request, out string errorMessage,
            out HealthInsuranceReponseData reponseData)
        {
            errorMessage = string.Empty;
            reponseData = null;

            if(HDIGlobal.IsTokenExpired || string.IsNullOrEmpty(HDIGlobal.RequestToken))
            {
                bool loginResult = Login(new LoginRequest(true), out string token, out errorMessage);

                if (!loginResult)
                {
                    return false;
                }
            }

            using (var client = httpClientFactory.CreateClient())
            {
                var url = "OpenApi/v1/mask/insur/create_pay";
                client.BaseAddress = new Uri(AppGlobal.HDInsurance_Url);
                client.DefaultRequestHeaders.Add("Token", HDIGlobal.RequestToken);
                
                if (string.IsNullOrEmpty(request.Data.ACTION))
                {
                    request.Data.ACTION = "BH_M";
                }

                request.CreateSignature();

                var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, httpContent).Result;

                var responseContent = response.Content.ReadAsStringAsync().Result;
                HealthInsuranceOrderResponse responseInfo = JsonConvert.DeserializeObject<HealthInsuranceOrderResponse>(responseContent);
                errorMessage = responseInfo.Error;

                if (responseInfo.Success)
                {
                    var data = responseInfo.Data.FirstOrDefault();
                    if(data != null)
                    {
                        reponseData = JsonConvert.DeserializeObject<HealthInsuranceReponseData>
                            (JsonConvert.SerializeObject(data));
                    }
                }

                return responseInfo.Success;
            }
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
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    LoginResponse responseData = JsonConvert.DeserializeObject<LoginResponse>(responseContent);

                    if (responseData.Success)
                    {
                        HDIGlobal.LastUpdateAt = DateTime.Now;
                        HDIGlobal.RequestToken = responseData.Token;
                        HDIGlobal.TokenExpire = responseData.Expires - 60;
                        HDIGlobal.RefreshToken = responseData.RefeshToken;

                        return true;
                    }
                    
                    errorMessage = responseData.ErrorMessage;
                    result = false;
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
