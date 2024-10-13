using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
    public class DetailsPage
    {
        private IWebDriver driver;

        public DetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='QqFHMw vslbG+ In9uk2']")]
        private IWebElement AddToCartBtn { get; set; }

        public void ProductDetail()
        {
            var windowHandles = driver.WindowHandles;
            driver.SwitchTo().Window(windowHandles[1]);
            try
            {
                AddToCartBtn.Click();
            }
            catch (StaleElementReferenceException)
            {
                
                AddToCartBtn = driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']"));
                AddToCartBtn.Click();
            }
        }
    }
}
