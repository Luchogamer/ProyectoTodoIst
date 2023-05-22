using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using ProyectoTodoist.src.code.session;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTodoist.src.code.control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator)
        {
            this.locator = locator;
        }

        protected void FindControl()
        {
            control = Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click()
        {
            FindControl();
            control.Click();
        }
        public void enter()
        {
            FindControl();
            control.SendKeys(Keys.Enter);
        }

        public string getText()
        {
            FindControl();
            return control.Text;
        }
        public Boolean IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

