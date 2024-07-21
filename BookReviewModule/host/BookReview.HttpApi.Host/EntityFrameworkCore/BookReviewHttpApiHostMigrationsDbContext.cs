using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace BookReview.EntityFrameworkCore;

public class BookReviewHttpApiHostMigrationsDbContext : AbpDbContext<BookReviewHttpApiHostMigrationsDbContext>
{
    public BookReviewHttpApiHostMigrationsDbContext(DbContextOptions<BookReviewHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureBookReview();
    }
}
