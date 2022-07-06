using Database.Models.Contacts;
using HrService.Database.Models.HumanResources;

namespace Database.Models.HumanResources
{
    internal class Employee
    {
        public int Id { get; set; }

        public Guid? ExternalId { get; set; }

        public DateTime BirthDay { get; set; }

        public string Address { get; set; }

        public int? PrivatePhoneId { get; set; }

        public int? CompanyPhoneId { get; set; }

        public string? Email { get; set; }


        public virtual Phone? Phone { get; set; }

        public virtual Assignment? Assignment { get; set; }
    }
}
