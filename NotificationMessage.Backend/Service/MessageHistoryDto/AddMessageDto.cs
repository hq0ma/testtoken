using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.MessageHistoryDto
{
    public class AddMessageDto
    {
        public int ProjectId { get; set; }
        public MessageType MessageType { get; set; }
        public string? Messagetext { get; set; }
        public List<string> PhoneNumbers { get; set; } = new List<string>();
    }
}
