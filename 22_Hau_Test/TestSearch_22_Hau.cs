using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace _22_Hau_Test
{
    [TestClass]
    public class TestSearch_22_Hau
    {
        public WebDriver driver_22Hau;
        public string key_22Hau, expectedResult_22Hau;
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestSearch.csv", "22_Hau_DataTestSearch#csv", DataAccessMethod.Sequential)]
        public void TestSearch_22Hau()
        {
            key_22Hau = TestContext.DataRow[0].ToString();
            expectedResult_22Hau = TestContext.DataRow[1].ToString();
            driver_22Hau = new ChromeDriver();
            driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
            System.Threading.Thread.Sleep(1000);
            IWebElement element_22Hau = driver_22Hau.FindElement(By.Name("q"));
            element_22Hau.SendKeys(key_22Hau);
            IWebElement element1_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='submit']"));
            element1_22Hau.Click();
            System.Threading.Thread.Sleep(3000);
            if (expectedResult_22Hau == "No results found")
            {
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.TagName("h3"));
                Assert.AreEqual(expectedResult_22Hau, element2_22Hau.Text);
            }
            else
            {
                IWebElement element3_22Hau = driver_22Hau.FindElement(By.XPath("//*[@id=\"er_top_head\"]/div"));
                Assert.IsTrue(element3_22Hau.Text.Contains(expectedResult_22Hau));
            }
            driver_22Hau.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestSearch.csv", "22_Hau_DataTestSearch#csv", DataAccessMethod.Sequential)]
        public void TestSuccessfulSearch_22Hau()
        {
            key_22Hau = TestContext.DataRow[0].ToString();
            expectedResult_22Hau = TestContext.DataRow[1].ToString();
            if (expectedResult_22Hau == "Showing")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.Name("q"));
                element_22Hau.SendKeys(key_22Hau);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='submit']"));
                element1_22Hau.Click();
                System.Threading.Thread.Sleep(2000);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.XPath("//*[@id=\"er_top_head\"]/div"));
                Assert.IsTrue(element2_22Hau.Text.Contains(expectedResult_22Hau));
                driver_22Hau.Quit();
            }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\22_Hau_DataTestSearch.csv", "22_Hau_DataTestSearch#csv", DataAccessMethod.Sequential)]
        public void TestNoSearch_22Hau()
        {
            key_22Hau = TestContext.DataRow[0].ToString();
            expectedResult_22Hau = TestContext.DataRow[1].ToString();
            if (expectedResult_22Hau == "No results found")
            {
                driver_22Hau = new ChromeDriver();
                driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
                System.Threading.Thread.Sleep(1000);
                IWebElement element_22Hau = driver_22Hau.FindElement(By.Name("q"));
                element_22Hau.SendKeys(key_22Hau);
                IWebElement element1_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='submit']"));
                element1_22Hau.Click();
                System.Threading.Thread.Sleep(2000);
                IWebElement element2_22Hau = driver_22Hau.FindElement(By.TagName("h3"));
                Assert.AreEqual(expectedResult_22Hau, element2_22Hau.Text);
                driver_22Hau.Quit();
            }
        }
        [TestMethod]
        public void TestSearch1_22Hau()
        {
            driver_22Hau = new ChromeDriver();
            driver_22Hau.Navigate().GoToUrl("https://www.speaklanguages.com/");
            System.Threading.Thread.Sleep(1000);
            IWebElement element_22Hau = driver_22Hau.FindElement(By.Name("q"));
            element_22Hau.SendKeys("abcdy");
            IWebElement element1_22Hau = driver_22Hau.FindElement(By.CssSelector("input[type='submit']"));
            element1_22Hau.Click();
            System.Threading.Thread.Sleep(4000);
            IWebElement element2_22Hau = driver_22Hau.FindElement(By.TagName("h3"));
            Assert.AreEqual(expectedResult_22Hau, "No results found");
            driver_22Hau.Quit();
        }
    }
}
