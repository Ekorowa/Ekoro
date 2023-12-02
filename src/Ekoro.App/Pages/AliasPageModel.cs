namespace Ekoro.App.Pages;

public class AliasPageModel : BasePageModel
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
        await LoadHtml(_alias);

        ViewData["Title"] = Html.Title;
        ViewData["Description"] = Html.MetaDescription;
        ViewData["Keywords"] = Html.MetaKeywords;
    }

    private async Task LoadHtml(string alias)
    {
        ContentItem = await _orchardHelper.GetContentItemByAliasAsync(alias);

        if (ContentItem != null)
        {
            Html.Title = ContentItem.DisplayText;
            Html.Body = (await _orchardHelper.LiquidToHtmlAsync((string)ContentItem.Content.LiquidPart.Liquid)).GetString();
            if (ContentItem.Content.SeoMetaPart != null)
            {
                var seo = ContentItem.Content.SeoMetaPart;
                Html.MetaDescription = (string)seo.MetaDescription;
                Html.MetaKeywords = (string)seo.MetaKeywords;
            }
        }
    }
}
