using CsharpSelenium2022.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CsharpSelenium2022
{
    public class Tests : DriverHelper
    {
    
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

           
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

         //   CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond"); 
            

            
            Console.WriteLine("testtttt2");
            Assert.Pass();
        }

          //      [Test]
            //    public  void LoginTest()
           //     {

              //      Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
                //    HomePage homepage = new HomePage();
                //    LoginPage loginpage = new LoginPage();
                 //   homepage.Clicklogin();

                 //   loginpage.EnterUserNameAndPassword("admin", "password");

                 //   loginpage.ClickLogin();
                 //   Assert.That(homepage.IsLogOffExists(),Is.True, "log off button is not displayed");

           

              //  }
    }
}