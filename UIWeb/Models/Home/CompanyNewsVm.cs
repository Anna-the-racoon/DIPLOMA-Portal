namespace UIWeb.Models.Home
{
    public class CompanyNewsVm
    {
        public ICollection<HomeCompanyNewsEntrySectionVm> CompanyNews { get; set; }
    }

    public class HomeCompanyNewsEntrySectionVm
    {
        public int Id { get; set; }
        public int? PictureId { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
