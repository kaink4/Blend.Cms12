using Blend.Cms12.Models.Pages;
using Blend.Cms12.Models.Pages.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Blend.Cms12.Controllers.Pages
{
    public class BasePageController<T> : PageController<T> where T : AbstractContentPage
    {
        protected IActionResult PageView(T model)
        {
            var viewModel = new PageViewModel<T>(model);

            viewModel.PageTitle ??= string.IsNullOrEmpty(model.PageTitle)
                ? model.Name
                : model.PageTitle;

            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", viewModel);
        }
    }
}
