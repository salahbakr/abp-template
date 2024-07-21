using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace BookReview;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookReviewHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BookReviewConsoleApiClientModule : AbpModule
{

}
