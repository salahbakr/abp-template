using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace BookReview.MongoDB;

[ConnectionStringName(BookReviewDbProperties.ConnectionStringName)]
public interface IBookReviewMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
