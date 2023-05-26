using System;
using OpenQA.Selenium;
using ProyectoTodoist.src.code.control;

namespace ProyectoTodoist.src.code.page
{
	public class ProjectMenuCreation
	{
        public TextBox nameProject = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button createProject = new Button(By.XPath("//button[@type='submit']"));
        public Button creations = new Button(By.XPath("//button[@class='plus_add_button']"));
        public TextBox newTask = new TextBox(By.XPath("//p[@data-placeholder='Nombre de la tarea']"));
        public Button acceptTask = new Button(By.XPath("//button[@data-testid='task-editor-submit-button']"));
    }
}

