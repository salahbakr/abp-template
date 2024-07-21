using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace BookReview.Blazor.WebAssembly;

[DependsOn(
    typeof(BookReviewBlazorModule),
    typeof(BookReviewHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class BookReviewBlazorWebAssemblyModule : AbpModule
{

}
