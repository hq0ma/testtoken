using NotificationMessage.Backend.Model;
using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.UserDtos
{
    public class AllUserDto
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public Role role { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}
