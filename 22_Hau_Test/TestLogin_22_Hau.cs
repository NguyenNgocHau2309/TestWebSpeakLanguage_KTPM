using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Globalization;
using System.IO;

namespace _22_Hau_Test
{
    [TestClass]
    public class TestLogin_22_Hau
    {
        public WebDriver driver_22Hau;
        public string email_22Hau, password_22Hau, expectedResult_22Hau;
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestLogin.csv", "22_Hau_DataTestLogin#csv", DataAccessMethod.Sequential)]
        public void TestLogin_22Hau()
        {
            email_22Hau = TestContext.DataRow[0].ToString();
            password_22Hau = TestContext.DataRow[1].ToString();
            expectedResult_22Hau = TestContext.DataRow[2].ToString();
            driver_22Hau = new ChromeDriver();
            driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
            System.Threading.Thread.Sleep(1000);
            IWebElement element_22Hau = driver_22Hau.FindElement(By.TagName("li"));
            element_22Hau.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement element1_22Hau = driver_22Hau.FindElement(By.Name("email"));
            element1_22Hau.SendKeys(email_22Hau);
            System.Threading.Thread.Sleep(1000);
            IWebElement element2_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='password']"));
            element2_22Hau.SendKeys(password_22Hau);
            System.Threading.Thread.Sleep(1000);
            IWebElement element3_22Hau = driver_22Hau.FindElement(By.Id("login_button"));
            element3_22Hau.Click();
            System.Threading.Thread.Sleep(5000);
            if (expectedResult_22Hau == "https://www.speaklanguages.com/")
            {
                Assert.AreEqual(expectedResult_22Hau, driver_22Hau.Url);
            }
            else
            {
                IWebElement element4_22Hau = driver_22Hau.FindElement(By.ClassName("error_message"));
                element4_22Hau.Click();
                Assert.AreEqual(expectedResult_22Hau, element4_22Hau.Text);
            }
            driver_22Hau.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestLogin.csv", "22_Hau_DataTestLogin#csv", DataAccessMethod.Sequential)]
        public void TestSuccessfulLogin_22Hau()
        {
            email_22Hau = TestContext.DataRow[0].ToString();
            password_22Hau = TestContext.DataRow[1].ToString();
            expectedResult_22Hau = TestContext.DataRow[2].ToString();
            if (expectedResult_22Hau == "https://www.speaklanguages.com/")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.TagName("li"));
                element_22Hau.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.Name("email"));
                element1_22Hau.SendKeys(email_22Hau);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='password']"));
                element2_22Hau.SendKeys(password_22Hau);
                IWebElement element3_22Hau = driver_22Hau.FindElement(By.Id("login_button"));
                element3_22Hau.Click();
                System.Threading.Thread.Sleep(5000);
                Assert.AreEqual(expectedResult_22Hau, driver_22Hau.Url);
                driver_22Hau.Quit();
            }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestLogin.csv", "22_Hau_DataTestLogin#csv", DataAccessMethod.Sequential)]
        public void TestFailedLogin_NoEmail_22Hau()
        {
            email_22Hau = TestContext.DataRow[0].ToString();
            password_22Hau = TestContext.DataRow[1].ToString();
            expectedResult_22Hau = TestContext.DataRow[2].ToString();
            if (email_22Hau == "")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.TagName("li"));
                element_22Hau.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.Name("email"));
                element1_22Hau.SendKeys(email_22Hau);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='password']"));
                element2_22Hau.SendKeys(password_22Hau);
                IWebElement element3_22Hau = driver_22Hau.FindElement(By.Id("login_button"));
                element3_22Hau.Click();
                System.Threading.Thread.Sleep(5000);
                IWebElement element4_22Hau = driver_22Hau.FindElement(By.ClassName("error_message"));
                element4_22Hau.Click();
                Assert.AreEqual(expectedResult_22Hau, element4_22Hau.Text);
                driver_22Hau.Quit();
            }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestLogin.csv", "22_Hau_DataTestLogin#csv", DataAccessMethod.Sequential)]
        public void TestFailedLogin_WrongPasswordorLogin_22Hau()
        {
            email_22Hau = TestContext.DataRow[0].ToString();
            password_22Hau = TestContext.DataRow[1].ToString();
            expectedResult_22Hau = TestContext.DataRow[2].ToString();
            if (expectedResult_22Hau == "The login details you entered are incorrect.")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.TagName("li"));
                element_22Hau.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.Name("email"));
                element1_22Hau.SendKeys(email_22Hau);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='password']"));
                element2_22Hau.SendKeys(password_22Hau);
                IWebElement element3_22Hau = driver_22Hau.FindElement(By.Id("login_button"));
                element3_22Hau.Click();
                System.Threading.Thread.Sleep(5000);
                IWebElement element4_22Hau = driver_22Hau.FindElement(By.ClassName("error_message"));
                element4_22Hau.Click();
                Assert.AreEqual(expectedResult_22Hau, element4_22Hau.Text);
                driver_22Hau.Quit();
            }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestLogin.csv", "22_Hau_DataTestLogin#csv", DataAccessMethod.Sequential)]
        public void TestFailedLogin_NoPassword_22Hau()
        {
            email_22Hau = TestContext.DataRow[0].ToString();
            password_22Hau = TestContext.DataRow[1].ToString();
            expectedResult_22Hau = TestContext.DataRow[2].ToString();
            if (expectedResult_22Hau == "Please enter your password.")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.TagName("li"));
                element_22Hau.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.Name("email"));
                element1_22Hau.SendKeys(email_22Hau);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='password']"));
                element2_22Hau.SendKeys(password_22Hau);
                IWebElement element3_22Hau = driver_22Hau.FindElement(By.Id("login_button"));
                element3_22Hau.Click();
                System.Threading.Thread.Sleep(5000);
                IWebElement element4_22Hau = driver_22Hau.FindElement(By.ClassName("error_message"));
                element4_22Hau.Click();
                Assert.AreEqual(expectedResult_22Hau, element4_22Hau.Text);
                driver_22Hau.Quit();
            }
        }
    }
}
