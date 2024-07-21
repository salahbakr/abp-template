using BookReview.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookReview.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookReviewPageModel : AbpPageModel
{
    protected BookReviewPageModel()
    {
        LocalizationResourceType = typeof(BookReviewResource);
        ObjectMapperContext = typeof(BookReviewWebModule);
    }
}
