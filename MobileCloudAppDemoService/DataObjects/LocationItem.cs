using Microsoft.Azure.Mobile.Server;

namespace MobileCloudAppDemoService.DataObjects
{
    public class LocationItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}