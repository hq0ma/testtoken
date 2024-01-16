
using System.Text.Json.Serialization;
using static NotificationMessage.Backend.Common.Enums;

namespace NotificationMessage.Backend.Service.ProjectDto
{
    public class UpdateTransctionDto
    {
        [JsonIgnore]
        public int Userid { get; set; }
        public BalanceType balanceType { get; set; }
        public decimal Amount { get; set; }
    }
}
