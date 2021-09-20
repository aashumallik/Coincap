using Coincap.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Coincap.Service
{
    public class coincapService
    {
        HttpClient connection = new HttpClient();
        public async Task<coincapModel> getData()
        {
            
            var response = await connection.GetAsync("https://api.coincap.io/v2/assets");//establishing a connection we URI
            string result = await response.Content.ReadAsStringAsync();//always add await before any async method
            coincapModel deserialize = JsonConvert.DeserializeObject<coincapModel>(result);
            return deserialize;
        }
        public async Task<List<Datum>> filterdata()
        {
            var newdata = await getData();
            var filterdata = newdata.data.Where(x => x.rank == "1" || x.rank == "3").ToList();//always use tolist when using where
            return filterdata;
        }
    }
}