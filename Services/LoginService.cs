using FL.Login.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Login.Services
{
    public class LoginService : ILoginRepository
    {
        public async Task<UserInfo> Login(string EmailField, string PasswordField)
        {

           var userInfo = new List<UserInfo>();
            var client = new HttpClient();

            string url = "https://lf-webservices-netcore.azurewebsites.net/user/loginuser/"+EmailField+"/"+PasswordField;
            client.BaseAddress= new Uri(url);
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                userInfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
               
                return await Task.FromResult(userInfo.FirstOrDefault());
            }
         
            
            else
            {
                return null;
            }
        }
    }
}
