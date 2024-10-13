using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
    public class AddToCartPage

    {
        private IWebDriver driver;

        public AddToCartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//button[@class='QqFHMw zA2EfJ _7Pd1Fp']")]
        private IWebElement PlaceOrderBtn { get; set; }

        public void PlaceOrder()
        {
            PlaceOrderBtn.Click();
        }
    }
}
