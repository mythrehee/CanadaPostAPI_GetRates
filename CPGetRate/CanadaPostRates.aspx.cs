using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPGetRate
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            if (validate())
            {
                String userName = txtUserName.Text;
                String password = txtPassword.Text;
                String customerNo = txtCustomerNumber.Text;
                GetRates getRate = new GetRates(userName, password, customerNo);

                pricequotes rates = getRate.SendRateRequest();

                if (rates == null || rates.pricequote.Count() == 0)
                {
                    displayNoRstesError();
                }
                else
                {
                    List<Rate> rateList = new List<Rate>();
                    foreach (var item in rates.pricequote)
                    {
                        rateList.Add(new Rate(item.servicename, item.servicestandard?.expectedtransittime, String.Format("${0}", item.pricedetails.due)));
                    }

                    rptRatesTable.DataSource = rateList;
                    rptRatesTable.DataBind();
                }
            

            }
        }

        public Boolean validate()
        {
            if (String.IsNullOrEmpty( txtUserName.Text ))
            {
                displayError("User name");
                return false;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                displayError("Password");
                return false;
            }
            else if (String.IsNullOrEmpty(txtCustomerNumber.Text))
            {
                displayError("Customer Number");
                return false;
            }
            return true;

        }

        public void displayError(string fieldName)
        {
            string script = "alert(\"Please enter the " + fieldName +  " to get the rates\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }

        public void displayNoRstesError()
        {
            string script = "alert(\"Error in Network! No Rates Returned\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }
}