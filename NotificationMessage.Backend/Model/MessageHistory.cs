using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Model
{
    public class MessageHistory
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public MessageType MessageType { get; set; }
        public string? MessageText { get; set; }
        public List<string>? PhoneNumbers { get; set; }
        public MessageStatus messageStatus { get; set; }
    }
}
