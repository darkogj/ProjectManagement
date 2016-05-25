using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.TaskManagementDomainEntities
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public virtual int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
