using System.Text.Json.Serialization;

namespace NotificationMessage.Backend.Service.ProjectDto
{
    public class AddProjectDto
    {
        [JsonIgnore]
        public string? Uniqueid { get; set; }
        [JsonIgnore]
        public int UserId { get; set; }
        public string? ProjectName { get; set; }
    }
}
