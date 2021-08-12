using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace VicRoads_Project.Pages
{
    public class UVPPagestep1Of7 : BasePage
    {
        [FindsBy(How = How.Id, Using = "ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitStartDate_Date")]
        public IWebElement PermitStartDate;

        [FindsBy(How = How.Id, Using = "ph_pagebody_0_phthreecolumnmaincontent_0_panel_btnNext")]
        public IWebElement next;
        public UVPPagestep1Of7(IWebDriver dr)
            : base(dr)
        {
        }






        public void SelectVehicleType(String VehicleType)
        {

            string javascript = "return document.getElementById('ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList');";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement element = (IWebElement)js.ExecuteScript(javascript);
            System.Threading.Thread.Sleep(3000);

            SelectElement Securityquestionvalue = new SelectElement(element);

            Securityquestionvalue.SelectByIndex(3);
        }

       
       

        public void EnterAddress(String addressenterval, String compaddressval)
        {
            IWebElement address = driver.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown"));
            address.SendKeys(addressenterval);
            System.Threading.Thread.Sleep(3000);
            IWebElement autoOptions = driver.FindElement(By.Id("ui-id-1"));


            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = System.TimeSpan.FromSeconds(5);
            IWebElement SearchResult = fluentWait.Until(x => x.FindElement(By.Id("ui-id-1")));

            IList<IWebElement> displayedOptions = autoOptions.FindElements(By.TagName("li"));

            foreach (IWebElement option in displayedOptions)
            {
                string gettext = option.Text;
                if (gettext.Equals(compaddressval))
                {
                    System.Console.WriteLine("Trying to select: " + compaddressval);
                    option.Click();
                    System.Threading.Thread.Sleep(3000);
                }
            }

        }

        public void permitStartDate(String permitstdt)
        {

            PermitStartDate.Clear();
            PermitStartDate.SendKeys(permitstdt);
            System.Threading.Thread.Sleep(3000);

        }


        public void permitDuration(String permitdurn)
        {

            string javascript22 = "return document.getElementById('ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList');";

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;

            IWebElement element1 = (IWebElement)js1.ExecuteScript(javascript22);
            System.Threading.Thread.Sleep(3000);

            SelectElement Securityquestionvalue11 = new SelectElement(element1);

            Securityquestionvalue11.SelectByIndex(17);
            System.Threading.Thread.Sleep(3000);
        }

        public void ClickNext()
        {
            next.Click();
        }
    }
    }


    