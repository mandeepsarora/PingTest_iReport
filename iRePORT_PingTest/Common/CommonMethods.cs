using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRePORT_PingTest.Common
{
    public class CommonMethods
    {
        static IWebDriver m_Driver = Login_Main.Driver;
        private static bool isloggedIn = false;
        public static void CaptureScreenshot()
        {
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(m_Driver, TimeSpan.FromSeconds(10));
            // wait.Until(driver.FindElement(By.Id("knownElementId")).Displayed);           

            string scrshotpath = ConfigurationManager.AppSettings["screenshotpath"];
            ITakesScreenshot screenshotDriver = m_Driver as ITakesScreenshot;
            try
            {
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
                screenshot.SaveAsFile(scrshotpath + "iRePORT_" + timestamp + ".png");
            }
            catch (Exception)
            {

                throw;
            }                                                 
        }

        public static void GetURL()
        {
            try
            {
                var appurl = ConfigurationManager.AppSettings["iRePORTURL"];
                m_Driver.Navigate().GoToUrl(appurl);
                m_Driver.Manage().Window.Maximize();
                Console.WriteLine("Browser Opened");
                System.Threading.Thread.Sleep(15000);
            }
            catch (NoSuchElementException)
            {

            }
        }
        public static void cleanup()
        {
            m_Driver.Quit();
          
        }
    }
}
