using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Apple iPhone 15 (Black, 128 GB)')]")]
        private IWebElement SelectItem { get; set; }

        public void SelectProduct()
        {
            SelectItem.Click();
        }
    }
}
