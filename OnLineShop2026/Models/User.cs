namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string AvatarPath { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            AvatarPath = "/images/default-avatar.png";
        }

        public User(string firstName, string lastName, string email) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}