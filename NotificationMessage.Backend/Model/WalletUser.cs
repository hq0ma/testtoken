namespace NotificationMessage.Backend.Model
{
    public class WalletUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public int SmsBalance { get; set; }
        public int WhatsappBalance { get; set; }
        public int TelegramBalance { get; set; }
    }
}
