namespace Ekoro.App.Pages;

public class AboutModel : AliasPageModel //PageModel
{
    public AboutModel(ILogger<AboutModel> logger, IOrchardHelper orchardHelper) :
        base(logger, orchardHelper, "about")
    {
    }
}
