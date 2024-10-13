using Flipkart.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using PayPalAutomation.Base;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Flipkart.Testcase
{
    [TestFixture]
    public class TestCase : Base
    {
        [Test]
        public void Test_SearchAndAddProductToCart() 
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var data = testData[0];

            homePage.SearchItem(data.ProductName);
            productPage.SelectProduct();
            detailsPage.ProductDetail();
            addToCartPage.PlaceOrder();
            checkoutPage.Checkoutdetails(data.Email, data.Mobile);

            Assert.That(checkoutPage.IsLoginSectionDisplayed(), Is.True, "Expected 'Login or Signup' section not displayed.");
            Assert.That(checkoutPage.IsOTPSectionDisplayed(), Is.True, "Expected OTP section not displayed.");
            Assert.That(checkoutPage.IsResendLinkDisplayed(), Is.True, "Expected 'Resend?' link not displayed.");
            
        }

        
    }
}
