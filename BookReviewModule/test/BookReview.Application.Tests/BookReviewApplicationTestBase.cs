using Volo.Abp.Modularity;

namespace BookReview;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class BookReviewApplicationTestBase<TStartupModule> : BookReviewTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
