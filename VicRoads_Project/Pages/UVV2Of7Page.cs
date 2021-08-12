using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VicRoads_Project.Pages
{
    public class  UVV2Of7Page : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "progress-bar-title")]
        public IWebElement Selectpermittype;
        public UVV2Of7Page(IWebDriver dr)
            : base(dr)
        {
        }

        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

       

        public Boolean ValidateselectpermitIsVisible()
        {
            System.Boolean status = Selectpermittype.Displayed;
            return status;
        }

        }


    }
}
