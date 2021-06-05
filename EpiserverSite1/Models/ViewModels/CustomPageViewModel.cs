using EpiserverSite1.Models.Pages;

namespace EpiserverSite1.Models.ViewModels
{
    public class CustomPageViewModel : PageViewModel<SitePageData>
    {
        public CustomPage CurrentPage { get; set; }

        //Create constructor that accept CustomPage and assign to the current page
        public CustomPageViewModel(CustomPage currentPage) : base(currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}