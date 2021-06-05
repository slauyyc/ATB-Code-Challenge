using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;

namespace EpiserverSite1.Controllers
{
    public class CustomPageController : PageControllerBase<CustomPage>
    {
        //Leverage from PageViewModel to view the results
        //public ActionResult Index(CustomPage currentContent)
        //{
        //    var model = PageViewModel.Create(currentContent);

        //    return View(model);
        //}

        //ViewModel is not working
        //public ActionResult Index(CustomPage currentPage)
        //{
        //    CustomPageViewModel<CustomPage> model = new CustomPageViewModel<CustomPage>(currentPage);
        //    return View(model);
        //}

        private readonly IContentLoader _contentLoader;

        public ActionResult Index(CustomPage currentPage)
        {
            var model = new CustomPageViewModel(currentPage);
            return View(model);
        }
    }
}