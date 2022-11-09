using Blend.Cms12.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages;

[ContentType(
    DisplayName = "General Page",
    Description = "General Page description",
    GroupName = "General Content",
    GUID = "f1d33bf5-6f4b-47ec-8de6-bf0dd827862f")]
public class GeneralPage : AbstractContentPage
{
    [Display(
        Name = "Headline",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual string? Headline { get; set; }

    [Display(
        Name = "HeadlineSlug",
        GroupName = SystemTabNames.Content,
        Order = 20)]
    public virtual string? HeadlineSlug { get; set; }

    [Display(
        Name = "Body",
        GroupName = SystemTabNames.Content,
        Order = 30)]
    public virtual XhtmlString? Body { get; set; }

    [Display(
        Name="Bottom Content Area",
        GroupName = SystemTabNames.Content,
        Order = 40)]
    [AllowedTypes(AllowedTypes = new[] {typeof(SectionMediaBlock), typeof(LinkGridBlock)})]
    public virtual ContentArea?  BottomContentArea { get; set; }
}
