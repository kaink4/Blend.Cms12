using Blend.Cms12.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Blend.Cms12.Controllers.Pages;

public class GeneralPageController : PageController<GeneralPage>
{
    public IActionResult Index(GeneralPage currentContent)
    {
        return View(currentContent);
    }
}
