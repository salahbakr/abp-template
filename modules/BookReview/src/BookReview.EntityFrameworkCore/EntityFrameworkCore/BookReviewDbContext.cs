using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
namespace BookReview.EntityFrameworkCore;

[ConnectionStringName(BookReviewDbProperties.ConnectionStringName)]
public class BookReviewDbContext : AbpDbContext<BookReviewDbContext>, IBookReviewDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<BookReview> BookReviews { get; set; }

    public BookReviewDbContext(DbContextOptions<BookReviewDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureBookReview();


        builder.Entity<BookReview>(b =>
        {
            b.ToTable("AppBookReviews");
            b.ConfigureByConvention();
            b.Property(x => x.ReviewerName).IsRequired();
            b.Property(x => x.Text).IsRequired().HasMaxLength(500);
            b.Property(x => x.Rating).IsRequired();
        });
    }
}
