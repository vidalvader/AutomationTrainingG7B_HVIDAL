using AutomationTrainingG7B_HVIDAL.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTrainingG7B_HVIDAL.Page_Objects
{
    /*son como 3 fases 
    * Declarar la description
    * Crear el objeto, solo crearlo
    * Trabajar / interactual con el objeto
    */

    class LoginPage_Mercury : BaseTest
    {
        /*Creando un objeto de la clase*/
        /*los guion bajo son un campo*/
        private static IWebDriver _driver;  //viene vacio hay que inicializarlo para trabajar con ello

        /*LOCATORS FOR EACH AND EVERY ELEMENT IN PAGE*/
        /*Solo son las definiciones de los objetos, no los estoy trabajando*/
        readonly static string strUserName_txt = "userName";
        readonly static string strPassword_txt = "password";
        readonly static string strSignIn_btn = "//input[@name='login']";

        /*Inicializando un objeto de la clase*/
        /*Para inicializar una clase, se utilzia un constructor, por ejemplo*/
        /*para reutilizarlo debe ser Publico*/
        /*Este es un constructor*/
        public LoginPage_Mercury(IWebDriver pobjDriver)  //este es mas para navegar
        {
            _driver = pobjDriver;
        }

        /*LOCATORS 
         * Trabajando
         * vamos a hacerlo privado por si es que lo heredo
         * El IWebElement ya es para la manipulacion
         * Si por alguna razon mi identificacion de Name a ID, puedo cambiarlo en el codigo acontinuacion
         */
        private static IWebElement objUserName_Txt => _driver.FindElement(By.Name(strUserName_txt));
        private static IWebElement objPassword_Txt => _driver.FindElement(By.Name(strPassword_txt));
        private static IWebElement objSignIn_Btn => _driver.FindElement(By.XPath(strSignIn_btn));

        /* METODOS PARA ACCEDER A WEBELEMENTS EN ESTA CLASE EN PARTICULAR
         */

        /*   hay que hacer que las funciones accedan a el */

        /*   hay que hacer que las funciones accedan a el */
        private static IWebElement GetUserNameTxt()
        {
            return objUserName_Txt;
        }

        /*  usamos el p (de parametro) + str (el tipo de dato) y el nombre */
        public static void fnEnterUserName (string pstrUserName)
        {
            objUserName_Txt.Clear();
            objUserName_Txt.SendKeys(pstrUserName);
        }

        /*   ahora el password */
        private static IWebElement GetPasswordTxt()
        {
            return objPassword_Txt;
        }

        public static void fnEnterPassword (string pstrPassword)
        {
            objPassword_Txt.Clear();
            objPassword_Txt.SendKeys(pstrPassword);
        }

        /*   ahora el buton */
        private static IWebElement GetSignInBtn()
        {
            return objSignIn_Btn;
        }

        public static void fnClickSignInBtn ()
        {
            objSignIn_Btn.Click();
        }

    }
}
