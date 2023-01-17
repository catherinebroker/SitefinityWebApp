//using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.ViewModels
{
    public class LaunchViewModel
    {
        [JsonProperty(PropertyName = "flight_number")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string MissionName { get; set; }
    }
}