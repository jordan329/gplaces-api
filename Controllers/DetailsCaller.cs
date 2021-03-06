using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace gplaces_api.Controllers
{
    public static class DetailsCaller
    {
        public async static Task<string> call(string placeId){
            string url = "https://maps.googleapis.com/maps/api/place/details/json?placeid={0}&key={1}";
            string apiKey = "AIzaSyAJa6LkYUYMwTNWp-FHPTApedfuly7ZH7I";
            url = String.Format(url, placeId, apiKey);
            
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
            HttpContent httpContent = httpResponse.Content;
            return await httpContent.ReadAsStringAsync();
        }
    }
}