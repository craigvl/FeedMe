using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LocuWebAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace LocuWebAPI.Controllers
{
    public class RestuarantController : ApiController
    {
        // GET api/values
        public object Get()
        {

            List<LocuWebAPI.Models.Object> a = new List<LocuWebAPI.Models.Object>();

            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("https://api.locu.com/v1_0/venue/search/?has_menu=TRUE&country=Australia&region=qld&api_key=a1800a6c1db0a037df3a62ad194e3f937e0b25df");
                }
                catch (Exception) {  }

                var data = JObject.Parse(json_data)["objects"];

                a = JsonConvert.DeserializeObject<List<LocuWebAPI.Models.Object>>(data.ToString());
           
            }

            return a;
        }

        // GET api/values/5
        public object Get(string id)
        {
            List<LocuWebAPI.Models.VenueDetails.Object> a = new List<LocuWebAPI.Models.VenueDetails.Object>();

            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("http://api.locu.com/v1_0/venue/"+id+"/?api_key=a1800a6c1db0a037df3a62ad194e3f937e0b25df");
                }

                catch (Exception) { }

                var data = JObject.Parse(json_data)["objects"];
 
                a = JsonConvert.DeserializeObject<List<LocuWebAPI.Models.VenueDetails.Object>>(data.ToString());

            }

            return a;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
