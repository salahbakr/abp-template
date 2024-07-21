using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BookReview;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class BookReviewInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BookReviewInstallerModule>();
        });
    }
}
