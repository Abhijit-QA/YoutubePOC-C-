using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MarchPractice.BaseClass;
using MarchPractice.PageObject;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MarchPractice.TestScripts
{
    [TestFixture]
    public class Module1: BaseTest
    {
        [Test]
        public void Testmethod1()
        {
          var searchpage =  new SearchPage(driver);
           var resultpage = searchpage.NavigateToResultPage();
        
          var channelname =  resultpage.NavigateToChannel();
            String actualChannelName = channelname.getChannelName();
            String expectedChannelName = "CitiusTech";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var videopage= new VideoPage(driver);
            videopage.getVideo();


           // Thread.Sleep(5000);

        }
    }
}
