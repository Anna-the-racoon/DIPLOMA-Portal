using HrService.Database.Models.HumanResources;
using System;

namespace HrService.Database.Models.OrgStructure
{
    internal class Position
    {
        public int Id { get; set; }

        public Guid? ExternalId { get; set; }

        public string Name { get; set; }

        public bool IsActual { get; set; }

        public bool IsManager { get; set; }

        public virtual Assignment? Assignment { get; set; }
    }
}
