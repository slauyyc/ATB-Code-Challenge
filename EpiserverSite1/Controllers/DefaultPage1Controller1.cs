using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiserverSite1.Models.Pages;

namespace EpiserverSite1.Controllers
{
    public class DefaultPage1Controller1 : PageController<DefaultPage1>
    {
        public ActionResult Index(DefaultPage1 currentPage)
        {
            return View(currentPage);
        }
    }
}