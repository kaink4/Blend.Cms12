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
            RegisterBlock<SectionMediaBlock>(viewTemplateModelRegistrator);
            RegisterBlock<LinkGridBlock>(viewTemplateModelRegistrator);

            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new TemplateModel
            {
                Name = "AbstractContentPage-LinkGrid",
                AvailableWithoutTag = false,
                Tags = new[] { "LinkGrid" },
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }

        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"{typeof(T).Name}-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }

    }
}
