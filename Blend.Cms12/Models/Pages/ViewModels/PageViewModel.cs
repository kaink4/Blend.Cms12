namespace Blend.Cms12.Models.Pages.ViewModels
{
    public abstract class PageViewModel
    {
        public string? PageTitle { get; set; }
    }

    public class PageViewModel<T> : PageViewModel
    {
        public T Page { get; }

        public PageViewModel(T page)
        {
            Page = page;
        }
    }
}
