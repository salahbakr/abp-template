using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookReview.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class BookReviewBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookReview";
}
