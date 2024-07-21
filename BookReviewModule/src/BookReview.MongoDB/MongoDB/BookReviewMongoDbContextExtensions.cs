using Volo.Abp;
using Volo.Abp.MongoDB;

namespace BookReview.MongoDB;

public static class BookReviewMongoDbContextExtensions
{
    public static void ConfigureBookReview(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
