using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebFormBBTesting
{
    [TestFixture]
    public class UntitledTestCase
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
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44389/");
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("25");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Rural");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("");
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("35");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("40");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Urban");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("50");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.XPath("//form[@id='ctl01']/div[3]")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("15");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_Button1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Click();
            driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("17");
            driver.FindElement(By.Id("MainContent_TextBox2")).Click();
            driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
            driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("rural");
            driver.FindElement(By.Id("MainContent_Button1")).Click();
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

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
