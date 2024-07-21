using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BookReview.EntityFrameworkCore;

[ConnectionStringName(BookReviewDbProperties.ConnectionStringName)]
public interface IBookReviewDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
