using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.MessageHistoryDto
{
    public class UpdateMessageDto
    {
        public MessageType MessageType { get; set; }
        public string? Messagetext { get; set; }
        public List<string>? PhoneNumbers { get; set; }
    }
}
