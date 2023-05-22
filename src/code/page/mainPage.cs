using ProyectoTodoist.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProyectoTodoist.src.code.page
{
	public class mainPage
	{
		public Button iniciarSesion = new Button(By.XPath("//li[@class='nOFNc0QpGW0HpMqVOfJb']/../li//a[@href='/auth/login']"));
	}
}

