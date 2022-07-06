using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrService.Database.Models.OrgStructure
{
    internal class Position
    {
        public int Id { get; set; }

        public Guid? ExternalId { get; set; }

        public string Name { get; set; }

        public bool IsActual { get; set; }

        public bool IsManager { get; set; }
    }
}
