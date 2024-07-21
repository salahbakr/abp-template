using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BookReview.EntityFrameworkCore;

[ConnectionStringName(BookReviewDbProperties.ConnectionStringName)]
public class BookReviewDbContext : AbpDbContext<BookReviewDbContext>, IBookReviewDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public BookReviewDbContext(DbContextOptions<BookReviewDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureBookReview();
    }
}
