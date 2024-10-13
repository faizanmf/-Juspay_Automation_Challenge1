using Flipkart.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace PayPalAutomation.Base
{
    public class Base
    {
        public IWebDriver driver;
        public HomePage homePage;
        public ProductPage productPage;
        public DetailsPage detailsPage;
        public AddToCartPage addToCartPage;
        public CheckoutPage checkoutPage;
        public List<TestData> testData;

        public Base()
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://www.flipkart.com/");          
            homePage = new HomePage(driver);
            productPage = new ProductPage(driver);
            detailsPage = new DetailsPage(driver);
            addToCartPage = new AddToCartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            testData = ExcelHelper.ReadTestData("D:\\interview training\\C# selenium\\POM\\flipkart\\Juspay_Flipkart\\Flipkart\\Testdata\\TestData.xlsx");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
            
        }
    }
}
