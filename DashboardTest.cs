using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class DashboardTest : INavigation
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod()
        {
            driver.Url = "https://www.esheba.cnsbd.com/#/login";
            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("smamonisha@gmail.com");
            Thread.Sleep(1000);

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("selenium");
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button")).Click();

            driver.Navigate().GoToUrl("https://www.esheba.cnsbd.com/#/dashboard");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/div[2]/nav/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
            //profile update
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[2]")).Click();
            Thread.Sleep(1000);
            //change password
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[3]")).Click();
            Thread.Sleep(1000);
            //change mobile no
            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[4]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[5]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[6]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[7]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[8]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div[2]/div/a[9]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div/div[2]/nav/div/div/ul/li[6]/a")).Click();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        public void Back()
        {
            throw new NotImplementedException();
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void GoToUrl(string url)
        {
            throw new NotImplementedException();
        }

        public void GoToUrl(Uri url)
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
