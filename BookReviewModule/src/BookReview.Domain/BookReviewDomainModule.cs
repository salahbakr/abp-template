using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace BookReview;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(BookReviewDomainSharedModule)
)]
public class BookReviewDomainModule : AbpModule
{

}
