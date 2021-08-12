using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VicRoads_Project.Pages
{
    class LaunchPage : BasePage
    {
        public LaunchPage(IWebDriver dr)
            : base(dr)
        {

        }

        public UVPPagestep1Of7 goToUVPPagestep1Of7()
        {
            // Webdriver
            // driver.url = "url";
            
           driver.Url = ("https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit");
            driver.Manage().Window.Maximize();
            UVPPagestep1Of7 uvpPagestep1of7 = new UVPPagestep1Of7(driver);
            PageFactory.InitElements(driver, uvpPagestep1of7);
            return uvpPagestep1of7;
        }
    }
    
}
