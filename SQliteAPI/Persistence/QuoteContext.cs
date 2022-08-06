using Microsoft.EntityFrameworkCore;
using SQliteAPI.Entities;
using System.Reflection;

namespace SQliteAPI.Persistence
{
    public class QuoteContext: DbContext
    {
        public QuoteContext(DbContextOptions<QuoteContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().ToTable("Quotes","test");
            modelBuilder.Entity<Quote>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuoteCreateTime).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
            modelBuilder.Entity<Quote>().HasData(SeedQuotes());
            base.OnModelCreating(modelBuilder);
        }

        private Quote[] SeedQuotes()
        {
            return new Quote[2] { new Quote() { Id = 1, TheQuote = "test", WhoSaid = "test person", QuoteCreator = "Joku" }, new Quote() { Id = 2, TheQuote = "test2", WhoSaid = "test person2", QuoteCreator = "Joku" } };
        }
    }
}
