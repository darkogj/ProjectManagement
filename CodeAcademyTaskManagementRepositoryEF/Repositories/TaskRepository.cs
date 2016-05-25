using CodeAcademy.TaskManagementDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeAcademyTaskManagementRepositoryEF.Repositories
{
    public class TaskRepository
    {
        Database db = new Database();
        public List<Task> GetAll()
        {
            return db.Tasks.ToList();
        }

        public Task GetById(int id)
        {
            return new Task();
        }

        public List<TaskComment> GetComments(Task id)
        {
            return new List<TaskComment>();
        }

        public string GetTaskAssigneeName(int taskId)
        {
            return string.Empty;
        }

        public bool Create(Task task)
        {
            return false;
        }

        public bool Update(Task task)
        {
            return false;
        }

        public bool Delete(Task task)
        {
            return false;
        }
    }
}
