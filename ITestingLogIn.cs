﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Inegration_Testing
{
    class ITestingLogIn
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://www.esheba.cnsbd.com/#/login";
            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("smamonisha@gmail.com");
            Thread.Sleep(2000);

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("selenium");
            Thread.Sleep(2000);

            //driver.FindElement(By.Id("studlogin")).Click();
            String at = driver.Title;
            String et = "BANGLADESH RAILWAY E-TICKETING SERVICE";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/div/section/div/div/div/div/div[2]/div/form/div[4]/div/button"));
                element2.Click();
                Thread.Sleep(2000);

            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
