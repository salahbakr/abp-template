using Volo.Abp.Modularity;

namespace BookReview;

[DependsOn(
    typeof(BookReviewDomainModule),
    typeof(BookReviewTestBaseModule)
)]
public class BookReviewDomainTestModule : AbpModule
{

}
