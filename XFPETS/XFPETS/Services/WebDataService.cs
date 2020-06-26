using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using XFPETS.Models;
using XFPETS.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebDataService))]
namespace XFPETS.Services
{
    public class WebDataService : IDataService
    {
        HttpClient httpClient;

        HttpClient Client => httpClient ?? (httpClient = new HttpClient());

        public async Task<IEnumerable<Pets>> GetPetsAsync()
        {
            var json = await Client.GetStringAsync("https://raw.githubusercontent.com/BryanOroxon/GifInMotion/master/GifInMotion/GifInMotion/Data/pets.json");
            var all = Pets.FromJson(json);
            return all;
        }
    }
}