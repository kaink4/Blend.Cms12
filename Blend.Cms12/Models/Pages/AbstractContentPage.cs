using System.ComponentModel.DataAnnotations;

namespace Blend.Cms12.Models.Pages;

public abstract class AbstractContentPage : PageData
{
    [Display(
        Name = "Page Title",
        GroupName = "SEO",
        Order = 10)]
    public virtual string? PageTitle { get; set; } 

    [Display(
        Name = "MetaDescription",
        GroupName = "SEO",
        Order = 20)]
    public virtual string? MetaDescription { get; set; }
}
