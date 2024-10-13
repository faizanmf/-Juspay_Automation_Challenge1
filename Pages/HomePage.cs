using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
    public class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='Pke_EE']")]
        private IWebElement SearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement SearchBtn { get; set; }


        public void SearchItem(string product)
        {
            SearchBox.SendKeys(product);
            SearchBtn.Click();
        }        
    }
}

