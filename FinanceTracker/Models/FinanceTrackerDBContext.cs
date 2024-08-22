using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Models
{
    public class FinanceTrackerDBContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public FinanceTrackerDBContext(DbContextOptions<FinanceTrackerDBContext> options) : base(options) 
        {

        }
    }
}
