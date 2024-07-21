using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using BookReview.EntityFrameworkCore;

namespace BookReview;

[DependsOn(
    typeof(BookReviewDomainModule),
    typeof(BookReviewApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class BookReviewApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<BookReviewApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<BookReviewApplicationModule>(validate: true);
        });

        context.Services.AddAbpDbContext<BookReviewDbContext>(options =>
        {
            // Add default repositories only for aggregate roots
            options.AddDefaultRepositories(includeAllEntities: true);
        });
    }
}
