using Localization.Resources.AbpUi;
using BookReview.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace BookReview;

[DependsOn(
    typeof(BookReviewApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class BookReviewHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(BookReviewHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<BookReviewResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(BookReviewApplicationModule).Assembly);
        });
    }
}
