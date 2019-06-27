using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Runtime.CompilerServices;

namespace NUnit.InsightsRetail
{
    public class CommonTestExecute
    {
            protected IWebDriver Driver;
            protected ICapabilities Capabilities;
            protected string TargetUrl;
            protected string GridUrl;

            RemoteWebDriverwithScreenShot threadDriverRemote;
            MyEventFiringWebDriver eveDriver;
                  
            public void BrowserSetUP()
            {
                TargetUrl = "http://urlOfMyWebsite";
                GridUrl   = "http://10.10.10.74:4444/wd/hub";
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);               
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            public MyEventFiringWebDriver SetUp() 
            {
                threadDriverRemote = new RemoteWebDriverwithScreenShot();
                eveDriver = (MyEventFiringWebDriver) threadDriverRemote.LaunchBrowser();
                return eveDriver;
	        }
                    
            public void TestCleanup()
            {
                Driver.Quit();
            }           
          
    }
 }
