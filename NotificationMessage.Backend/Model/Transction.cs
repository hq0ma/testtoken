using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Model
{
    public class Transction
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public User User { get; set; }
        public BalanceType balanceType { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateProcess { get; set; }
    }
}
