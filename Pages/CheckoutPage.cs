using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Login or Signup')]")]
        private IWebElement LoginSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='r4vIwl Jr-g+f']")]
        private IWebElement EnterEMail { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='QqFHMw YhpBe+ _7Pd1Fp']")]
        private IWebElement ContBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='I-qZ4M _3789DR']/input)[2]")]
        private IWebElement EnterMob { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Enter OTP']")]
        private IWebElement OTPSection { get; set; }

        [FindsBy(How = How.LinkText, Using = "Resend?")]
        private IWebElement Resendlnk { get; set; }


        public bool IsLoginSectionDisplayed()
        {
            try
            {
                return LoginSection.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
        }

        public void Checkoutdetails(string Email, string mobile)
        {
            EnterEMail.SendKeys(Email);
            ContBtn.Click();
            EnterMob.SendKeys(mobile);
            Thread.Sleep(3000);
            ContBtn.Click();          
            
        }      

        
        public bool IsOTPSectionDisplayed()
        {
            return OTPSection.Displayed && OTPSection.Text.Equals("Enter OTP");
        }

        public bool IsResendLinkDisplayed()
        {
            return Resendlnk.Displayed;
        }
    }
}
