using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarchPractice.PageObject
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//yt-formatted-string[text()='CitiusTech']")]
        
        public IWebElement ChannelName { get; set; }
        public string getChannelName()
        {
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return ChannelName.Text;
        }
    }
}

