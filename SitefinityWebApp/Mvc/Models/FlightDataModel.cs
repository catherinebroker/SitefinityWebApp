using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SitefinityWebApp.Mvc.ViewModels;

namespace SitefinityWebApp.Mvc.Models
{
    public class FlightDataModel
    {
        public LaunchViewModel GetViewModel() => Task.Run(() => this.GetLaunchAsync()).Result;

        private async Task<LaunchViewModel> GetLaunchAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.spacex.land/graphql/");
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LaunchViewModel>(jsonString);
            }
        }
    }
}