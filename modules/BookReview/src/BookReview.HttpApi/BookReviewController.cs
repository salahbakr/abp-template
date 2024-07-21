using BookReview.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookReview;

public abstract class BookReviewController : AbpControllerBase
{
    protected BookReviewController()
    {
        LocalizationResource = typeof(BookReviewResource);
    }
}
