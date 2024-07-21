using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BookReview;

[DependsOn(
    typeof(BookReviewApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class BookReviewHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BookReviewApplicationContractsModule).Assembly,
            BookReviewRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BookReviewHttpApiClientModule>();
        });

    }
}
