using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace BookReview.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(BookReviewBlazorModule)
    )]
public class BookReviewBlazorServerModule : AbpModule
{

}
