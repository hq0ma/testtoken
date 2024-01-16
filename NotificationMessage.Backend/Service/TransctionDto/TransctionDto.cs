using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.ProjectDto
{
    public class TransctionDto
    {
        public int Userid { get; set; }
        public BalanceType balanceType { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateProcess { get; set; }
    }
}
