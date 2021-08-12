using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicRoads_Project.Pages
{
    class BasePage
    {
        public IWebDriver driver;
        

        public BasePage(IWebDriver dr)
        {
            driver = dr;
            
        }

        public bool verifyTitle(string expTitle)
        {
            return false;
        }

       

        public bool isElementPresent(string xpathExpr)
        {
            int c = driver.FindElements(By.XPath(xpathExpr)).Count;
            if (c > 0)
                return true;
            else
                return false;
        }

        
    }
}
