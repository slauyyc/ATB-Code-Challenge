using System.ComponentModel;
using EPiServer.Core;

namespace EpiserverSite1.Models.Pages
{
    //Creating a class to hold the data for item list
    public class MultiListColumns
    {
        public virtual string Label { get; set; }

        public virtual string Value { get; set; }

        [DisplayName("Image")]
        public virtual ContentReference MyImage {get;set;}
    }
}