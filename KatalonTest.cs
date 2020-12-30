using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class KatalonTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheKatalonTest()
        {
            driver.Navigate().GoToUrl("https://www.esheba.cnsbd.com/#/");
            Thread.Sleep(1500);
            driver.FindElement(By.LinkText("Login")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("smamonisha@gmail.com");
            Thread.Sleep(1500);
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("selenium");
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//div[@id='topNavbarSupportedContent']/ul/li/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Verify Ticket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Dashboard")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Logout")).Click();
            Thread.Sleep(2000);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
