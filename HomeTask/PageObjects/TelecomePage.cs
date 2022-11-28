using Dynamitey.DynamicObjects;
using HomeTask.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.PageObjects
{
    public class TelecomePage
    {
        public TelecomePage()
        {
            PageFactory.InitElements(BaseTest.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"one\"]/div/div[1]/div[1]/h3/a")]
        public IWebElement addCustomer { get; set; }

        [FindsBy(How=How.XPath, Using = "//*[@id=\"main\"]/div/form/div/div[1]/label")]
        public IWebElement radioBtn  { get; set; }

        [FindsBy(How = How.Id, Using = "fname")]
        public IWebElement fname { get; set; }

        [FindsBy(How = How.Id, Using = "lname")]
        public IWebElement lname { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "addr")]
        public IWebElement address { get; set; }

        [FindsBy(How = How.Id, Using = "telephoneno")]
        public IWebElement telephoneno { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement submit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/header/h1")]
        public IWebElement accessMsg { get; set; }

        public void navigateToTelecomePage()
        {
            addCustomer.Click();
        }
        public void selectRdioBtn()
        {
            radioBtn.Click();
        }

        public void adduserDetails(string fName, string lName, string emailId, string adDr)
        {
            fname.SendKeys(fName);
            lname.SendKeys(lName);
            email.SendKeys(emailId);
            address.SendKeys(adDr);
            telephoneno.SendKeys("0911111111");
        }

        public void clickLoginButton()
        {
            submit.Click();
        }

        public void checkAcessDetailsPage ()
        {
            string accessPage = "Access Details to Guru99 Telecom";
            Assert.AreEqual(accessPage,accessMsg.Text);
        }
    }
}
