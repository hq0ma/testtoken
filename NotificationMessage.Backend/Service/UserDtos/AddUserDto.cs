using static NotificationMessage.Backend.Common.Enums;
using System.ComponentModel.DataAnnotations;
using NotificationMessage.Backend.Model;
using System.Text.Json.Serialization;

namespace NotificationMessage.Backend.Service.UserDtos
{
    public class AddUserDto
    {
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public Role role { get; set; }

        [JsonIgnore]
        public DateTime DateCreated { get; set; }
    }
}
