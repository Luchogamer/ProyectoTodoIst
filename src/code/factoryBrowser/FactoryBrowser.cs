using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTodoist.src.code.factoryBrowser
{
    public class FactoryBrowser
    {
        public static IBrowser Make(String type)
        {
            IBrowser browser;

            switch (type)
            {
                case "chrome":
                    browser = new Chrome();
                    break;
                case "firefox":
                    browser = new FireFox();
                    break;
                case "edge":
                    browser = new Edge();
                    break;

                default:
                    browser = new Chrome();
                    break;
            }

            return browser;
        }
    }
}

