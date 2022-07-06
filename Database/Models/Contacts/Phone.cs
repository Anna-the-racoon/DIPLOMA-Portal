using Database.Models.HumanResources;

namespace Database.Models.Contacts
{
    internal class Phone
    {
        public int Id { get; set; }

        public double Number { get; set; }

        public bool IsCompany { get; set; }

        public bool IsShown { get; set; }

        public virtual Employee? Employee { get; set; }

    }
}
