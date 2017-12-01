# xamarin-ios-zendesk-binding
A Xamarin iOS Binding for Zendesk Support SDK

# How to
1) Clone this project
2) Drag project file (`ZendeskSDK.csproj`) into your solution (or use Right Click -> Add -> Add New Project)
3) Reference it under References in your iOS project

Init the project in AppDelegate:

    var z = ZDKConfig.Instance();
    z.InitializeWithAppId("<app id>", "<zendesk url>", "<mobile key>");
    z.UserIdentity = new ZDKAnonymousIdentity();

    var baseTheme = ZDKTheme.BaseTheme();
    /*
     * Apply a theme
     * baseTheme.PrimaryBackgroundColor = DesignKit.BackgroundColor();
     baseTheme.SecondaryBackgroundColor = DesignKit.BackgroundColor();
     baseTheme.EmptyBackgroundColor = DesignKit.BackgroundColor();
     baseTheme.FontName = new NSString("ProximaNova-Regular");
     baseTheme.BoldFontName = new NSString("ProximaNova-SemiBold");
    */
    baseTheme.Apply();

Then show the support gui (from a UIViewController):

     var model = ZDKHelpCenterOverviewContentModel.defaultContent();
     var helpCenter = new ZDKHelpCenterOverviewController(model);

     helpCenter.NavigationItem.LeftBarButtonItem = new UIBarButtonItem("Annuller", UIBarButtonItemStyle.Plain, (sender, ev) => {
          this.DismissViewController(true, null);
     });

     var nav = new UINavigationController(helpCenter);
     this.PresentViewControllerAsync(nav, true);


#BeAwesome
