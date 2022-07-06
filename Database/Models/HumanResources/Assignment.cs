using Database.Models.HumanResources;
using HrService.Database.Models.OrgStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrService.Database.Models.HumanResources
{
    internal class Assignment
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public int DepartmentId { get; set; }



        public virtual Employee Employee { get; set; }

        public virtual Position Position { get; set; }

        public virtual Department Department { get; set; }
    }
}
