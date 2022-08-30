namespace UIWeb.Models.Home
{
    public class AnnouncementVm
    {
        public ICollection<HomeAnnouncementEntrySectionVm>? Announcements { get; set; }
    }
}

public class HomeAnnouncementEntrySectionVm
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime? Date { get; set; }
}
