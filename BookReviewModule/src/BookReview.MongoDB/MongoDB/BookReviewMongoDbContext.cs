using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace BookReview.MongoDB;

[ConnectionStringName(BookReviewDbProperties.ConnectionStringName)]
public class BookReviewMongoDbContext : AbpMongoDbContext, IBookReviewMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureBookReview();
    }
}
