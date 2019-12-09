using AutomationTrainingG7B_HVIDAL.Base_Files;
using AutomationTrainingG7B_HVIDAL.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingG7B_HVIDAL.Test_Cases
{
    class LoginTest_Mercury : BaseTest
    {
        LoginPage_Mercury objLoginPage;

        [Test, Order(0)]
        public void MercuryLoginTest()
        {
            objLoginPage = new LoginPage_Mercury(objDriver);
            LoginPage_Mercury.fnEnterUserName(strUserName); // luego puedo usar sus funciones
            LoginPage_Mercury.fnEnterPassword(strPassword);
            LoginPage_Mercury.fnClickSignInBtn();
            
        }

    }
}
