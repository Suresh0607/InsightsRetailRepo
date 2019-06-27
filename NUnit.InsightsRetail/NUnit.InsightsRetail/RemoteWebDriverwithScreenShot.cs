﻿using System;
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
        string _host = "10.10.10.74";
        string _port = "4444";
        EventFiringWebDriver eveDriver = null;
                    
        public IWebDriver LaunchBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            threadDriver = new ScreenShotRemoteWebDriver(new Uri("http://" + _host + ":" + _port + "/wd/hub"), options);
            eveDriver = new MyEventFiringWebDriver(threadDriver);
            return eveDriver;
        }
    }
}
