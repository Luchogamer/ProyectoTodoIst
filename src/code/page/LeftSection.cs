using ProyectoTodoist.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProyectoTodoist.src.code.page
{
	public class LeftSection
	{
		public Button newProject = new Button(By.XPath("//button[@aria-label='Añadir proyecto']"));
		public Button theProyect = new Button(By.XPath("//a[contains(.,('nuevo proyecto'))]"));
	
		public Button modifyProject = new Button(By.XPath("//div[@class='eYDM03d0TdWUmvQvarxM6w== DebMdpIqKcFRpFpVm5-wrA== _2a3b75a1 _509a57b4 e5a9206f _50ba6b6b']/../div//button[@type='button']"));
		public Button deleteProject = new Button(By.XPath("//div[contains(text(),'Eliminar proyecto')]"));
		public Button confirmDelete = new Button(By.XPath("//button[@data-autofocus='true']"));
	}
}

