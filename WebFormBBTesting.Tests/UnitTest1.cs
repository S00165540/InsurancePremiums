using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebFormBBTesting.Tests
{
    [TestFixture]
    public class UnitTest1
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
    public void The25RuralTest()
    {
        driver.Navigate().GoToUrl("https://localhost:42800/");
        driver.FindElement(By.Id("MainContent_TextBox1")).Click();
        driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
        driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("25");
        driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
        driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Rural");
        string five = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
        // ERROR: Caught exception [unknown command []]
    }
       [Test]
       public void The35RuralTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Click();
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("35");
           String threePointFive = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
       }

       [Test]
       public void The25UrbanTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("25");
           driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Urban");
           driver.FindElement(By.Id("MainContent_Button1")).Click();
           String six = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
       }
       [Test]
       public void The40UrbanTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Click();
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("40");
           driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Urban");
           String five = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
       }


       [Test]
       public void The50RuralTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("50");
           driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Rural");
           String discounted = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
       }
       [Test]
       public void The15RuralTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("50");
           driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Rural");
           String zero = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
       }
       [Test]
       public void The17UrbanTest()
       {
           driver.Navigate().GoToUrl("https://localhost:42800/");
           driver.FindElement(By.Id("MainContent_TextBox1")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox1")).SendKeys("17");
           driver.FindElement(By.Id("MainContent_TextBox2")).Clear();
           driver.FindElement(By.Id("MainContent_TextBox2")).SendKeys("Urban");
           String zero = driver.FindElement(By.Id("MainContent_Button1")).GetAttribute("value");
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
