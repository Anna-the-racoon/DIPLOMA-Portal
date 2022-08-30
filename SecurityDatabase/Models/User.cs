namespace SecurityDatabase.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public Guid Token { get; set; }

        public virtual ICollection<Permission>? Permissions { get; set; }

    }
}
