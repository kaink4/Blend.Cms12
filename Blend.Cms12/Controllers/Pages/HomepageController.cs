using Blend.Cms12.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Blend.Cms12.Controllers.Pages;

public class HomepageController : BasePageController<Homepage>
{
    public IActionResult Index(Homepage currentContent)
    {
        return PageView(currentContent);
    }
}
