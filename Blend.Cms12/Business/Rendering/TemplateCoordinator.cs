using Blend.Cms12.Models.Blocks;
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
        }
    }
}
