using FluentAssertions;
using OpenQA.Selenium;
using PrepMajor.Hooks;
using PrepMajor.PageObject;
using System;
using TechTalk.SpecFlow;


namespace PrepMajor.Steps
{
    [Binding]
    public class StudentRegistrationSteps

    {
        //newbie
        StudentRegistrationPages _studentRegistrationPage;
        public int a = 2;

        public StudentRegistrationSteps()
        {
            _studentRegistrationPage = new StudentRegistrationPages();
        }




        [Given(@"a user navigates to the prepmajor site")]
        public void GivenAUserNavigatesToThePrepmajorSite()
        {
            _studentRegistrationPage.NavigateToPrepmajorSite();
        }

        [When(@"I click  on SignUp button")]
        public void WhenIClickOnSignUpButton()
        {
            _studentRegistrationPage.ClickSignUpButton();
        }


        [When(@"under the Registration section I fill in my ""(.*)""")]
        public void WhenUnderTheRegistrationSectionIFillInMy(string userName)
        {
            _studentRegistrationPage.EnterUserName(userName);
        }


        [When(@"I fill in my ""(.*)""")]
        public void WhenUnderTheRegistrationSectionIfillInMy(string email)
        {
            _studentRegistrationPage.EnterEmail(email);
        }

        [When(@"I fill in the ""(.*)""")]
        public void WhenUndeTheRegistrationSectionIFillInPassword(string password)
        {
            _studentRegistrationPage.EnterPassword(password);
        }

        [When(@"I confirm the ""(.*)""")]
        public void WhenUnderTheRegistrationSectionIConfirmPassword(string Cpassword)
        {
            _studentRegistrationPage.EnterconfirmPassword(Cpassword);
        }

        [When(@"I check the Terms Of Use And Condition checkBox")]
        public void WhenUnderTheRegistrationSerctionISelectTermsOfUseAndConditionCheckBox()
        {
            _studentRegistrationPage.SelecttermsOfUseAndConditionCheckBox();
        }

        [When(@"I click on the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            _studentRegistrationPage.ClickRegisterButton();

        }

       [Then(@"the student should successfully Register and see the username displayed")]
        public void ThenTheStudentShouldSuccessfullyRegisterAndSeeTheUsernameDisplayed()
        {
            _studentRegistrationPage.IsUserNameDisplayed().Should().BeTrue();
        }
       

    }
}
