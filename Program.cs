using AutomationTrainingG7B_HVIDAL.Base_Files;
using AutomationTrainingG7B_HVIDAL.Page_Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomationTrainingG7B_HVIDAL
{
    class Program : BaseTest

    {
        static void Main(string[] args)
        {
            /*puedo usar directamente la funcion o el metodo por que ya lo tengo heredado
             *podria usar BaseTest.SetupDriver(); pero seria redundante
             */

            /*originalmente el codigo se corre desde aqui, en main
             *sin embargo al usarse NUnit Framework, los test cases 
             * los controlamos desde ahi, lo que hace que el main, 
             * practicamente no se estaria usando
             */

            /*  este codigo estaba funcional como ejemplo
            SetupDriver();

           
            LoginPage_Mercury objLogin; // primero creo el objeto
            objLogin = new LoginPage_Mercury(objDriver); // luego lo instancio
            LoginPage_Mercury.fnEnterUserName(strUserName); // luego puedo usar sus funciones
            LoginPage_Mercury.fnEnterPassword(strPassword);
            LoginPage_Mercury.fnClickSignInBtn();
            
            ExitDriver();
            */

            /*
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            //Object Page
            objDriver.FindElement(By.Name("userName")).Clear();
            objDriver.FindElement(By.Name("userName")).SendKeys(strUserName);
            objDriver.FindElement(By.Name("password")).Clear();
            objDriver.FindElement(By.Name("password")).SendKeys(strPassword);

            objDriver.FindElement(By.Name("userName")).Clear();
            objDriver.FindElement(By.Name("userName")).SendKeys("admin123");
            objDriver.FindElement(By.Name("password")).Clear();
            objDriver.FindElement(By.Name("password")).SendKeys("45374w");

            objDriver.FindElement(By.XPath("//input[@name='login']")).Click();
            objDriver.FindElement(By.LinkText("REGISTER")).Click();
            //Driver Kill
            objDriver.Close();
            objDriver.Quit();

            Console.ReadKey();
            */
        }
    }
}