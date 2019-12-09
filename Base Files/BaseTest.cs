using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingG7B_HVIDAL.Base_Files
{
    class BaseTest
    {
        /*ATTRIBUTES - Porque estan los datos aqui en base test??*/
        public static IWebDriver objDriver;

        protected static string strUserName = ConfigurationManager.AppSettings.Get("username");
        protected static string strPassword = ConfigurationManager.AppSettings.Get("password");
        protected static string strUrl = ConfigurationManager.AppSettings.Get("url");

        /*ATTRIBUTES FOR REGISTER PAGE*/
        protected static string strFirstName = ConfigurationManager.AppSettings.Get("firstName");
        protected static string strLastName = ConfigurationManager.AppSettings.Get("lastName");
        protected static string strPhone = ConfigurationManager.AppSettings.Get("phone");

        /* cuando tengamos una funcion que regresa un tipo de dato
         * es necesario hacer un return con el mismo tipo de dato
         * EL VOID puede hacer un proceso sin esperar un tipo de dato
         */

        /*METHOD / FUNCTIONS aqui ya esta inicializado */
        /*para hacer una referencia directa, se usa static
         *y es para evitar la bronca de inicializar, crear una declaraci[on 
         */
        [SetUp]
        public static void SetupDriver()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();
        }

        /*si no uso el static, tengo que inicializarla, por ejemplo
         * BaseTest objX = new BaseTest();
         * objX.ExitDriver();
        */
        [TearDown]
        public static void ExitDriver()
        {
            objDriver.Close();
            objDriver.Quit();
        }


    }
}
