﻿using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace BookReview.Web.Menus;

public class BookReviewMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(BookReviewMenus.Prefix, displayName: "BookReview", "~/BookReview", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
