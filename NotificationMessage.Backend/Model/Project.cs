namespace NotificationMessage.Backend.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string? Uniqueid { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string? ProjectName { get; set; }
    }
}
