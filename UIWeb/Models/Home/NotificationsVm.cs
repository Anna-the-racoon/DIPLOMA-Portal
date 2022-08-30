namespace UIWeb.Models.Home
{
    public class NotificationsVm
    {
        public ICollection<NotificationEntryVm>? Notifications { get; set; }
    }

    public class NotificationEntryVm
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
