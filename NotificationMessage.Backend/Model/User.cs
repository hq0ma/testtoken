using System.Data;
using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public Role Role { get; set; }
        public WalletUser WalletUser { get; set; }
        public ICollection<Project> projects { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
