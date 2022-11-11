using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;

namespace PlayFab_Tester
{
    public class APIResultsQueue
    {
        static private Queue<LoginResult> loginResults = new Queue<LoginResult>();

        public delegate void LoginResultsReady();


        static public bool AddLoginResult(LoginResult loginResult)
        {
            bool Succeeded = false;

            loginResults.Enqueue(loginResult);

            return Succeeded;
        }

        static public LoginResult GetLoginResult()
        {
            LoginResult result = loginResults.Dequeue();
            return result;
        }

    }
}
