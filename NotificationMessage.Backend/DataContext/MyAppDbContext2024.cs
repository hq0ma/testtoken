using Microsoft.EntityFrameworkCore;
using NotificationMessage.Backend.Model;

namespace NotificationMessage.Backend.DataContext
{
    public class MyAppDbContext2024 : DbContext 
    {
        public MyAppDbContext2024(DbContextOptions<MyAppDbContext2024> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<WalletUser> walletUsers { get; set; }
        public DbSet<MessageHistory> messageHistories { get; set; }
        public DbSet<Transction> transctions { get; set; }
    }
}
