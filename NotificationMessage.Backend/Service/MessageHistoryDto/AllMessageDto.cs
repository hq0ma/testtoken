using static NotificationMessage.Backend.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NotificationMessage.Backend.Service.MessageHistoryDto
{
    public class AllMessageDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public MessageType MessageType { get; set; }
        public string? Messagetext { get; set; }
        public List<string>? PhoneNumbers { get; set; }
        public MessageStatus messageStatus { get; set; }
    }
}
