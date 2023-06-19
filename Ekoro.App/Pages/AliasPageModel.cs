namespace Ekoro.App.Pages;

public class AliasPageModel : PageModel
{
    private readonly ILogger<AliasPageModel> _logger;
    private readonly IOrchardHelper _orchardHelper;
    private readonly string _alias;

    public ContentItem ContentItem { get; set; }

    public AliasPageModel(ILogger<AliasPageModel> logger, IOrchardHelper orchardHelper, string alias)
    {
        _logger = logger;
        _orchardHelper = orchardHelper;
        _alias = alias;
    }

    public async Task OnGetAsync()
    {
        ContentItem = await _orchardHelper.GetContentItemByAliasAsync(_alias);

        if (ContentItem != null)
        {
            ViewData["Title"] = ContentItem.DisplayText;
            if (ContentItem.Content.SeoMetaPart != null)
            {
                var seo = ContentItem.Content.SeoMetaPart;
                ViewData["Description"] = (string)seo.MetaDescription;
                ViewData["Keywords"] = (string)seo.MetaKeywords;
            }
        }
    }
}
