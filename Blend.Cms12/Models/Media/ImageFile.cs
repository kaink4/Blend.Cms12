using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Media;

[ContentType(
    DisplayName = "Image",
    GUID = "5fe543f1-a2f9-406a-8135-69b5eeb8f7d3")]
[MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
public class ImageFile : ImageData
{
    [Display(
        Name = "Alternate Text")]
    public virtual string? AltText { get; set; }
}

