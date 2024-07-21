using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace BookReview;

[DependsOn(
    typeof(BookReviewDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class BookReviewApplicationContractsModule : AbpModule
{

}
