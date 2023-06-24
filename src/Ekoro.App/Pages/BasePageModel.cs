namespace Ekoro.App.Pages;

public class BasePageModel : PageModel
{
    public HtmlPage Html { get; set; } = new HtmlPage();

    public BasePageModel()
    {
    }
}
