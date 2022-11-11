using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;

namespace PlayFab_Tester
{
    internal class API
    {
        public API() { }    
        public API(string apiKey) { }

        public async void LoginWithCustomID()
        {
            PlayFabSettings.staticSettings.TitleId = "1023F";
            var request = new LoginWithCustomIDRequest { CustomId = "55C843A80B7212D1", CreateAccount = false };
            
            PlayFabResult<LoginResult> loginTask = await PlayFabClientAPI.LoginWithCustomIDAsync(request);


        }
    }
}
