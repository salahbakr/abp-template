using BookReview.Localization;
using Volo.Abp.Application.Services;

namespace BookReview;

public abstract class BookReviewAppService : ApplicationService
{
    protected BookReviewAppService()
    {
        LocalizationResource = typeof(BookReviewResource);
        ObjectMapperContext = typeof(BookReviewApplicationModule);
    }
}
