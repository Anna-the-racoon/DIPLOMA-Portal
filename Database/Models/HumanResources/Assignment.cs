using Database.Models.HumanResources;
using HrService.Database.Models.OrgStructure;

namespace HrService.Database.Models.HumanResources
{
    internal class Assignment
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public int DepartmentId { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly? DateEnd { get; set; }


        public virtual Employee Employee { get; set; }

        public virtual Position Position { get; set; }

        public virtual Department Department { get; set; }
    }
}
