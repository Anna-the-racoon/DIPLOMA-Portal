using HrService.Database.Models.HumanResources;

namespace HrService.Database.Models.OrgStructure
{
    internal class Department
    {
        public int Id { get; set; }

        public Guid? ExternalId { get; set; }

        public string Name { get; set; }

        public bool IsActual { get; set; }

        public DateOnly DateStart { get; set; }

        public DateOnly? DateEnd { get; set; }

        public int? ParentId { get; set; }

        public string? Email { get; set; }


        public virtual Assignment? Assignment { get; set; }

    }
}
