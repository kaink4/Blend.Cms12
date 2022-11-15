using Blend.Cms12.Models.Blocks;
using Blend.Cms12.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Blend.Cms12.Controllers.Pages;

public class GeneralPageController : BasePageController<GeneralPage>
{
    private readonly IContentLoader _contentLoader;

    public GeneralPageController(IContentLoader contentLoader)
    {
        _contentLoader = contentLoader;
    }

    public IActionResult Index(GeneralPage currentContent)
    {
        if (currentContent.BottomContentArea is not null)
        {
            var blockReferences = currentContent.BottomContentArea.FilteredItems;
            foreach (var reference in blockReferences)
            {
                var block = _contentLoader.Get<BlockData>(reference.ContentLink);
                if (block is SectionMediaBlock)
                {
                    Console.WriteLine("SectionMediaBlock");
                }
                else if (block is LinkGridBlock)
                {
                    Console.WriteLine("LinkGridBlock");
                }
                else
                {
                    Console.WriteLine("Impossibru");
                }


                //var blockType = block.GetOriginalType();

                //if (blockType == typeof(SectionMediaBlock))
                //{
                //    Console.WriteLine("SectionMediaBlock");
                //}
                //else if (blockType == typeof(LinkGridBlock))
                //{
                //    Console.WriteLine("LinkGridBlock");
                //}
                //else
                //{
                //    Console.WriteLine("Impossibru");
                //}


            }
        }
            return PageView(currentContent);
        
    }
}