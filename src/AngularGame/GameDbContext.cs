using Microsoft.Framework.Configuration;
using System.Data.Entity;
using AngularGame.Models;

namespace AngularGame
{
    [DbConfigurationType(typeof(GameDbConfiguration))]
    public class GameDbContext : DbContext
    {
        public GameDbContext(IConfiguration config)
            : base(config.Get("Data:DefaultConnection:ConnectionString"))
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
