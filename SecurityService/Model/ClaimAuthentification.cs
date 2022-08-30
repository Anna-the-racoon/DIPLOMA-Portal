namespace SecurityService.Model
{
    public class ClaimAuthentification
    {
        public string Name { get; set; }
        public int UserId { get; internal set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
