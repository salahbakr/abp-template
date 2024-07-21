using BookReview.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookReview.Permissions;

public class BookReviewPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookReviewPermissions.GroupName, L("Permission:BookReview"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookReviewResource>(name);
    }
}
