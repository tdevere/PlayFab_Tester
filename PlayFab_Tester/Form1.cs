using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayFab_Tester;
using static PlayFab_Tester.APIResultsQueue;
using PlayFab;
using PlayFab.ClientModels;
using System.Xml.Linq;

namespace PlayFab_Tester
{
    public partial class frmPlayFabTester : Form
    {
        public LoginResultsReady Callback;

        public frmPlayFabTester()
        {
            InitializeComponent();
        }

        private void frmPlayFabTester_Load(object sender, EventArgs e)
        {
            this.Callback += new LoginResultsReady(this.LoginResultsReady);
        }

        private void LoginResultsReady() 
        {
            GetLoginResults(rtbResults, APIResultsQueue.GetLoginResult());
        }

        private void GetLoginResults(Control control, LoginResult loginResult)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(Callback, loginResult);
            }
            else
            {
                //Do The Work Here
                ((RichTextBox)control).Clear();

                var stringPropertyNamesAndValues = loginResult.GetType()
                .GetProperties()
                .Where(pi => pi.PropertyType == typeof(string) && pi.GetGetMethod() != null)
                .Select(pi => new
                {
                    Name = pi.Name,
                    Value = pi.GetGetMethod().Invoke(loginResult, null)
                });

                foreach (var pair in stringPropertyNamesAndValues)
                {
                    string results = pair.Name + " " + pair.Value;

                    control.Text += results;
                }
            }
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            //Get Selected API and Invoke the API
        }
    }
}
