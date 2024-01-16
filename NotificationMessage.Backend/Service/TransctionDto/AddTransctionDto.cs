using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.ProjectDto
{
    public class AddTransctionDto
    {
        public int Userid { get; set; }
        public BalanceType balanceType { get; set; }
        public decimal Amount { get; set; }
    }
}
