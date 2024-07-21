using Volo.Abp.Modularity;

namespace BookReview;

[DependsOn(
    typeof(BookReviewApplicationModule),
    typeof(BookReviewDomainTestModule)
    )]
public class BookReviewApplicationTestModule : AbpModule
{

}
