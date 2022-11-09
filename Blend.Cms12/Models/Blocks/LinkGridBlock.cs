using Blend.Cms12.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks
{
    [ContentType(
        DisplayName ="Link Grid Block",
        GUID = "d0c87d1c-a99a-4232-83d8-83cbc2650de8")]
    public class LinkGridBlock : BlockData
    {
        [Display(
            Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(AllowedTypes = new [] { typeof(AbstractContentPage) })]
        public virtual ContentArea? Links { get; set; }
    }
}
