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
    class RegisterTest_Mercury : BaseTest
    {
        RegisterPage_Mercury objRegisterPage;

        [Test, Order(0)]
        public void MercuryRegisterPage()
        {
            objRegisterPage = new RegisterPage_Mercury(objDriver);
            RegisterPage_Mercury.fnEnterFirstName(strFirstName);
            RegisterPage_Mercury.fnEnterLastName(strLastName);
            Console.ReadKey();
        }

    }
}
