using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iRePORT_PingTest.Pages
{
    [TestClass]
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            mdriver = driver;
        }

    private IWebDriver mdriver;
           
        [FindsBy(How = How.Id, Using = "USER")]
        private IWebElement TxtUsername;

        [FindsBy(How = How.Id, Using = "PASSWORD")]
        private IWebElement TxtPassword;

        [FindsBy(How = How.Id, Using = "Image2")]
        private IWebElement BtnLogin;

        public void EnterUsernamePassword(string username, string password)
        {
            TxtUsername.SendKeys(username);
            System.Threading.Thread.Sleep(10000);
            TxtPassword.SendKeys(password);
        }
        public void ClickLogin()
        {
            BtnLogin.Click();           
            //SendKeys.SendWait(@"{Enter}");
           // System.Threading.Thread.Sleep(50000);
        }

    }
}
