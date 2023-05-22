using ProyectoTodoist.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace ProyectoTodoist.src.code.page
{
	public class CredentialsPage
	{
		public TextBox emailbox = new TextBox(By.XPath("//input[@placeholder='Introduce tu email...']"));

		public TextBox pwrbox = new TextBox(By.XPath("//input[@placeholder='Introduce tu contraseña...']"));

		public Button loginbutton = new Button(By.XPath("//button[@data-gtm-id='start-email-login']"));
	}
}

