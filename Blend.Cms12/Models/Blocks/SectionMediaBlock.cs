using EPiServer.DataAnnotations;
using EPiServer.Web;
using Org.BouncyCastle.Crypto.Engines;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Blocks;

[ContentType(
    DisplayName = "Section Media Block",
    GUID ="c2d10805-4ea2-4c88-a97d-f5d66ae16542")]
public class SectionMediaBlock : BlockData
{
    [Display(
        Name = "Headline",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? Headline { get; set; }

    [Display(
        Name = "Body",
        GroupName = SystemTabNames.Content,
        Order = 20)]
    public virtual XhtmlString? Body { get; set; }

    [Display(
        Name = "Image",
        GroupName = SystemTabNames.Content,
        Order = 30)]
    [UIHint(UIHint.Image)]
    public virtual ContentReference? Image { get; set; }
}
