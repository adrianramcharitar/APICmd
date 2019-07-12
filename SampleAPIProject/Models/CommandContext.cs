using Microsoft.EntityFrameworkCore;

namespace SampleAPIProject.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) :base(options)
        {

        }

        public DbSet<Command> CommandItems { get; set; }
    }
}