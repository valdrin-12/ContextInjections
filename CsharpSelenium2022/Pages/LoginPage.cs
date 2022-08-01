using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CsharpSelenium2022.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));


        IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);

        }


        public void ClickLogin()


        {



            btnLogin.Click();   
        }
    }
}
