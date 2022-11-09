using Blend.Cms12.Models.Blocks;
using Blend.Cms12.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace Blend.Cms12.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(SectionMediaBlock), new TemplateModel
            {
                Name = "SectionMediaBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/SectionMediaBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(LinkGridBlock), new TemplateModel
            {
                Name = "LinkGridBlock-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/LinkGridBlock/Index.cshtml"
            });

            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new TemplateModel
            {
                Name = "AbstractContentPage-LinkGrid",
                AvailableWithoutTag = false,
                Tags = new[] {"LinkGrid"},
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }
    }
}
