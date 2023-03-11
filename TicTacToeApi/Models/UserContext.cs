using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TicTacToeApi.Models
{
    public class UserDb : DbContext
    {
        public UserDb(DbContextOptions<UserDb> options)
            : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}