using System;
using OpenQA.Selenium;
using ProyectoTodoist.src.code.control;

namespace ProyectoTodoist.src.code.page
{
	public class ProjectMenuCreation
	{
        public TextBox nameProject = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button createProject = new Button(By.XPath("//button[@type='submit']"));
    }
}

