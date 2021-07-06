using Newtonsoft.Json;
using Payment.SharedUltilities.Global;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Payment.ExternalService.BlueBolt
{
    public interface IBlueBoltService
    {
        public bool Login(LoginRequest request, out string errorCode ,out string errorMessage);

    }
    public class BlueBoltService : IBlueBoltService
    {
        public bool Login(LoginRequest request, out string errorCode, out string errorMessage)
        {
            errorMessage = string.Empty;
            errorCode = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress =  new Uri(AppGlobal.BlueBolt_BaseUrl);
                var httpContent = new StringContent(JsonConvert.SerializeObject(request), 
                    Encoding.UTF8, "application/json");
                var response = client.PostAsync("api-partner-cus/login", httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    var responseData = JsonConvert.DeserializeObject<LoginResponse>(responseContent);

                    if(responseData.code == 1)
                    {
                        BlueBoltGlobal.lastLoginAt = DateTime.Now;
                        BlueBoltGlobal.requestToken = responseData.data?.token;
                        return true;
                    }

                    errorCode = responseData.error;
                    errorMessage = responseData.message;
                }
                else
                {
                    errorCode = response.StatusCode.ToString();
                    errorMessage = response.ReasonPhrase;
                }
               
            }

            return false;
        }
    }
}
