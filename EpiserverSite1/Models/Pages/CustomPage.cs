using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;

namespace EpiserverSite1.Models.Pages
{
    //Creating Custom Page extending for SitePage and added page icon when creating new page
    [ContentType(DisplayName = "CustomPage", GUID = "c04b5374-58d5-4e70-90dc-bce396c062ff", Description = "ATB Code Challenge 2021")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    [SiteImageUrl("~/Static/gfx/ATBlogo.PNG")]

    public class CustomPage : SitePageData
    {
        //Display order is increment of 10 for easier adjustment
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "Add a heading.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString Heading { get; set; }

        [Display(
            Name = "Image",
            Description = "Add an image (optional)",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Main Body",
            Description = "Add description in the main body",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "List Items",
            Description = "Add items to list",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<MultiListColumns>))]
        public virtual IList<MultiListColumns> ItemList { get; set; }
    }
}