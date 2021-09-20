using Coincap.Models;
using Coincap.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Coincap.Controllers
{
    
    public class CoinCapController : ApiController
    {
        coincapService c = new coincapService();

        [HttpGet]
        public async Task<coincapModel> Get()
        {
            return await c.getData();
        }


        public async Task<List<Datum>> Getfilterdata()
        {
            return await c.filterdata();
        }

    }
}
