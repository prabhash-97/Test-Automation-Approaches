using HomeTask.Drivers;
using HomeTask.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace HomeTask.StepDefinitions
{
    [Binding]
    public class LoginSD
    {
        LoginPage loginPO;
        BaseTest baseTestPO = new BaseTest();

        [Given(@"user in the login page")]
        public void GivenUserInTheLoginPage()
        {
            baseTestPO.BrowserSetup();
            loginPO = new LoginPage();
        }

        [Given(@"user enter (.*) (.*)")]
        public void GivenUserEnterUsernameAndPassword(string username, string pasaword)
        {
            loginPO.addloginCerditionals(username, pasaword);
        }


        [When(@"user clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            loginPO.clickLoginButton();
        }

        [Then(@"user navigate to home page")]
        public void ThenUserNavigateToHomePage()
        {
            loginPO.navigateToHomePage();
        }

    }
}
