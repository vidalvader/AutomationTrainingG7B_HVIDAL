using AutomationTrainingG7B_HVIDAL.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingG7B_HVIDAL.Page_Objects
{
    class RegisterPage_Mercury : BaseTest
    {
        private static IWebDriver _driver;

        readonly static string strFirstName_txt = "firstName";
        readonly static string strLastName_txt = "lastName";

        readonly static string strPhone_txt = "//input[@name='login']";

        public RegisterPage_Mercury(IWebDriver pobjDriver)  //este es mas para navegar
        {
            _driver = pobjDriver;
        }

        //lambdas para especificar los names de los campos 
        //sacados en el html
        private static IWebElement objFirstName_Txt => _driver.FindElement(By.Name(strFirstName_txt));
        private static IWebElement objLastName_Txt => _driver.FindElement(By.Name(strLastName_txt));

        //FUNCTONS ALL

        //buscamos en la página el campo, lo localizamos
        private static IWebElement GetFirstNameTxt()
        {
            return objFirstName_Txt;
        }

        //una vez encontrado podemos usar esta funcion para meter datos
        public static void fnEnterFirstName(string pstrFirstName)
        {
            objFirstName_Txt.Clear();
            objFirstName_Txt.SendKeys(pstrFirstName);
        }

        private static IWebElement GetLastNameTxt()
        {
            return objLastName_Txt;
        }

        public static void fnEnterLastName(string pstrLastName)
        {
            objLastName_Txt.Clear();
            objLastName_Txt.SendKeys(pstrLastName);
        }


    }
}
