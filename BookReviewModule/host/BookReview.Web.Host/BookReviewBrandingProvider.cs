using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BookReview;

[Dependency(ReplaceServices = true)]
public class BookReviewBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookReview";
}
