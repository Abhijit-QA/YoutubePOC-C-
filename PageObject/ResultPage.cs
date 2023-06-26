using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarchPractice.PageObject
{
  public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.LinkText, Using = "CitiusTech")]
        public IWebElement ChannelNameLinkText { get; set; }

        // public void NavigateTochannel()  
        public ChannelPage NavigateToChannel()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}
