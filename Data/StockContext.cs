using AssessmentTest.Model;
using Microsoft.EntityFrameworkCore;

namespace AssessmentTest.Data
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> opt) : base(opt)
        {
            
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockProcessor> StockProcessors { get; set; }

    }
}