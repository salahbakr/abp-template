using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace BookReview.Pages;

public class IndexModel : BookReviewPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
