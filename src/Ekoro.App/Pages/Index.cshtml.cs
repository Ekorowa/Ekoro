namespace Ekoro.App.Pages;

public class IndexModel : AliasPageModel //PageModel
{
    public IndexModel(ILogger<IndexModel> logger, IOrchardHelper orchardHelper) :
        base(logger, orchardHelper, "home")
    {
    }
}
