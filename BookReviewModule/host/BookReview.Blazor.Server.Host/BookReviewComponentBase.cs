using BookReview.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookReview.Blazor.Server.Host;

public abstract class BookReviewComponentBase : AbpComponentBase
{
    protected BookReviewComponentBase()
    {
        LocalizationResource = typeof(BookReviewResource);
    }
}
