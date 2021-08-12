using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelReader;
using VicRoads_Project.Util;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using VicRoads_Project.Pages;


namespace TestAutomation.TestCases
{
    [TestFixture]
  public  class FillUVPPageForm1of7test : BaseTest

    {
        [Test, TestCaseSource("getData")]
        public void uvpFillForm1of7Test(string vehicletype, string address, string permitstartdate, string permintduration, string compaddressval)
        {
            openBrowser("Chrome");
            UVPPagestep1Of7 uvvpage1 = new UVPPagestep1Of7(driver);
            UVV2Of7Page uvvpage2 = new UVV2Of7Page(driver);
            uvvpage1.SelectVehicleType(vehicletype);
            uvvpage1.EnterAddress(address, compaddressval);
            uvvpage1.permitStartDate(permitstartdate);
            uvvpage1.permitDuration(permintduration);
            uvvpage1.ClickNext();
            Boolean actual = uvvpage2.ValidateselectpermitIsVisible();
            
                Assert.IsTrue(actual);
                System.Console.WriteLine("Select permit type displayed");

        
        }



            




        }

    }
}
