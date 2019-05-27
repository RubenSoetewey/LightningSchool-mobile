using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LightningSchool
{
    public class GetData:IGetData
    {
        public GetData()
        {
        }
        public async Task<string> GetApiData(string endpoint)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(endpoint);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

    }
}
