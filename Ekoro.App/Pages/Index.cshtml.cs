namespace Ekoro.App.Pages;

public class IndexModel : LiquidPageModel //PageModel
{
    public IndexModel(ILogger<IndexModel> logger, IOrchardHelper orchardHelper) :
        base(logger, orchardHelper, "home")
    {
    }
}
