using EPiServer.Core;
using EPiServer.PlugIn;

namespace EpiserverSite1.Models.Pages
{
    [PropertyDefinitionTypePlugIn]
    public class MultiColumnsProperty : PropertyList<MultiListColumns>
    {
    }
}