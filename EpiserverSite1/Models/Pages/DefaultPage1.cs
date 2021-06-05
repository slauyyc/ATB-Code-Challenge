using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverSite1.Models.Pages
{
    [ContentType]
    public class DefaultPage1 : PageData
    {
        public virtual XhtmlString MainBody { get; set; }

    }
}