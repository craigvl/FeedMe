using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeedMe.Models;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FeedMe.Controllers
{
    public class RestaurantController : Controller
    {
        public ActionResult Index()
        {
            List<FeedMe.Models.Restaurant> a = new List<FeedMe.Models.Restaurant>();

            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("http://localhost:7343/api/Restuarant");
                }
                catch (Exception) { }

                //var data = JObject.Parse(json_data);

                a = JsonConvert.DeserializeObject<List<FeedMe.Models.Restaurant>>(json_data.ToString());

            }

            return View(a);
        }

        public ActionResult Menu(string id)
        {


            List<FeedMe.Models.RestaurantDetails> a = new List<FeedMe.Models.RestaurantDetails>();

            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString("http://localhost:7343/api/Restuarant/"+id);
                }
                catch (Exception) { }

                //var data = JObject.Parse(json_data);

                a = JsonConvert.DeserializeObject<List<FeedMe.Models.RestaurantDetails>>(json_data.ToString());

            }

            return View(a);

        }

        public ActionResult About()
        {   
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}