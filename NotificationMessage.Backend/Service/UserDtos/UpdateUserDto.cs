using System.Text.Json.Serialization;
using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.UserDtos
{
    public class UpdateUserDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public Role role { get; set; }
    }
}
