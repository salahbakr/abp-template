using BookReview.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookReview.Pages;

public abstract class BookReviewPageModel : AbpPageModel
{
    protected BookReviewPageModel()
    {
        LocalizationResourceType = typeof(BookReviewResource);
    }
}
