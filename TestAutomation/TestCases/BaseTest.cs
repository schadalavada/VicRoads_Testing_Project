using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelReader;


namespace TestAutomation.TestCases
{
    public class BaseTest
    {
        public IWebDriver driver;
        public static ExcelReaderFile xls = new ExcelReaderFile(@"Data.xlsx");
        
        [Obsolete]
        public void openBrowser(string bName)
        {
            
                if (bName.Equals("Mozilla"))
                    driver = new FirefoxDriver();
                else if (bName.Equals("Chrome"))
                    driver = new ChromeDriver("E://");

               // driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
                driver.Manage().Window.Maximize();
            }
           
                
            }
       }
    

