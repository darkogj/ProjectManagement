using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.TaskManagementDomainEntities
{
    public class Task
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EstimateHours { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public virtual TaskType Type { get; set; }

        public virtual ICollection<TaskComment> Comments { get; set; }

        public virtual int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public virtual int UserId { get; set; }
        public virtual User User { get; set; }        
    }

    public enum TaskType
    {
        Task = 0,
        Bug = 1,
        ChangeRequest = 2,
        SupportRequest = 3
    }
}
