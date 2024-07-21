using Volo.Abp.Bundling;

namespace BookReview.Blazor.Host.Client;

public class BookReviewBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
