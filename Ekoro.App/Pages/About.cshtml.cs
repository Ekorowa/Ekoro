namespace Ekoro.App.Pages;

public class AboutModel : LiquidPageModel //PageModel
{
    public AboutModel(ILogger<AboutModel> logger, IOrchardHelper orchardHelper) :
        base(logger, orchardHelper, "about")
    {
    }
}
