using OpenQA.Selenium;
using ProyectoTodoist.src.code.factoryBrowser;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTodoist.src.code.session
{
    public class Session
    {
        private static Session instance = null;
        private IWebDriver browser;

        private Session()
        {
            browser = FactoryBrowser.Make("chrome").Create();
        }

        public static Session Instance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public void CloseBrowser()
        {
            instance = null;
            browser.Quit();
        }

        public void switchToFrame(string id)
        {
            browser.SwitchTo().Frame(id);
        }

        public void switchToMainFrame()
        {
            browser.SwitchTo().DefaultContent();
        }

        public IWebDriver GetBrowser()
        {
            return browser;
        }
    }
}

