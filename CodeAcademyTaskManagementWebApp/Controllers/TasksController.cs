using CodeAcademy.TaskManagementDomainEntities;
using CodeAcademyTaskManagementRepositoryEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAcademyTaskManagementWebApp.Controllers
{
    public class TasksController : Controller
    {
        public TaskRepository _taskRepository = new TaskRepository();
        public ActionResult Index()
        {
            List<Task> tasks = _taskRepository.GetAll();
            return View(tasks);
        }
    }
}