using HomeTask.Drivers;
using HomeTask.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace HomeTask.StepDefinitions
{
    [Binding]
    public class TelecomSD
    {
        TelecomePage telecomePO;
        BaseTest baseTestPO = new BaseTest();


        [Given(@"user in the telecome page")]
        public void GivenUserInTheTelecomePage()
        {
            baseTestPO.TelecomePageSetUp();
            telecomePO = new TelecomePage();
            telecomePO.navigateToTelecomePage();
        }

        [When(@"user tick radion button")]
        public void WhenUserTickRadionButton()
        {
            telecomePO.selectRdioBtn();
        }

        [Given(@"new user enter firstname, lastname, email, address and mobilenumber")]
        public void GivenNewUserEnterFirstnameLastnameEmailAddressAndMobilenumber(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            telecomePO.adduserDetails((string)data.firstname, (string)data.lastname, (string)data.email, (string)data.address);
        }


        [When(@"user clicks on the submit button")]
        public void WhenUserClicksOnTheSubmitButton()
        {
            telecomePO.clickLoginButton();
        }

        [Then(@"user navigate to access_detail page")]
        public void ThenUserNavigateToAccess_DetailPage()
        {
            telecomePO.checkAcessDetailsPage();
        }

    }
}
