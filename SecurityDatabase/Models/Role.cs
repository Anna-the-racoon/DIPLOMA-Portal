namespace SecurityDatabase.Models
{
    internal class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
        public Role() => Permissions = new HashSet<Permission>();

    }
}
