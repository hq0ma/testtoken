namespace NotificationMessage.Backend.Common
{
    public class Enums
    {
        public enum MessageType
        {
            sms,
            whatsapp,
            telegram,
        }
        public enum MessageStatus
        {
            sending,
            sent,
            cencele,
            failed
        }
        public enum Role
        {
            admin,
            Operation,
            merchant,
            customer
        }
        public enum BalanceType
        {
            smsbalance,
            whatsappbalance,
            telegrambalance,
        }
    }
}
