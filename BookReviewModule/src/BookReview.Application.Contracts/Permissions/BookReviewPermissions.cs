using Volo.Abp.Reflection;

namespace BookReview.Permissions;

public class BookReviewPermissions
{
    public const string GroupName = "BookReview";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BookReviewPermissions));
    }
}
