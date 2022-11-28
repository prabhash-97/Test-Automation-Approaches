using HomeTask.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.PageObjects
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement loginBTN { get; set; }

        public void addloginCerditionals(string userName, string passWord)
        {
            username.SendKeys(userName);
            password.SendKeys(passWord);
        }

        public void clickLoginButton()
        {
            loginBTN.Click();
        }

        public void navigateToHomePage()
        {
            string url=BaseTest.driver.Url;
            string scuessPage = "https://demo.guru99.com/test/success.html";
            Assert.AreEqual(scuessPage, url);
        }
    }
}
