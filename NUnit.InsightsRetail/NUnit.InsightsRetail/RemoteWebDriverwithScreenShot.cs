using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using System.Drawing;


namespace NUnit.InsightsRetail
{

    public class RemoteWebDriverwithScreenShot 
    {
         private ScreenShotRemoteWebDriver threadDriver;
         //private String host, port, _platform, _DisableProxy, _browserType, _chromeDriverPath, _fileDowload_path;
         string _host = "10.10.10.74";
         string _port = "4444";
         EventFiringWebDriver eveDriver = null;
                    
        public IWebDriver LaunchBrowser(TestContext ctx)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability("username", "Partner_ZZZZ", true);
            options.AddAdditionalCapability("accessKey", "ZZZZ", true);
                                          
            threadDriver = new ScreenShotRemoteWebDriver(new Uri("http://" + _host + ":" + _port + "/wd/hub"), options.ToCapabilities());
            eveDriver = new MyEventFiringWebDriver(threadDriver);
            return eveDriver;
        }
    }
}
