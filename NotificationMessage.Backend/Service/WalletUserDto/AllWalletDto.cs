﻿
using System.Text.Json.Serialization;

namespace NotificationMessage.Backend.Service.WalletUserDto
{
    public class AllWalletDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int UserId { get; set; }
        public int SmsBalance { get; set; }
        public int WhatsappBalance { get; set; }
        public int TelegramBalance { get; set; }
    }
}
