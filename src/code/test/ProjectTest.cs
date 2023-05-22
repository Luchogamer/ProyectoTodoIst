using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoTodoist.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTodoist.src.code.session;

namespace ProyectoTodoist.src.code.test
{
	[TestClass]
	public class ProjectTest : testBase
	{
		mainPage mainPage = new mainPage();
		CredentialsPage CredentialsPage = new CredentialsPage();
		LeftSection LeftSection = new LeftSection();
		ProjectMenuCreation ProjectMenuCreation = new ProjectMenuCreation();

		[TestMethod]
		public void VerifyLoginSuccessfully()
		{
			mainPage.iniciarSesion.Click();

			Thread.Sleep(2000);
			CredentialsPage.emailbox.SetText("luigiii_95@hotmail.com");
			CredentialsPage.pwrbox.SetText("12345678mojix");
			CredentialsPage.loginbutton.Click();

			Thread.Sleep(5000);

			LeftSection.newProject.Click();
			ProjectMenuCreation.nameProject.SetText("nuevo proyecto");
            ProjectMenuCreation.createProject.Click();
			Thread.Sleep(2000);
            LeftSection.modifyProject.Click();
			LeftSection.deleteProject.Click();
			LeftSection.confirmDelete.Click();
        }
    }
}

