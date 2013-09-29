using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Object
namespace LocuWebAPI.Models
{
    public class RestaurantModel
    {
        public string Name { get; set; }
    }

    public class Meta
{
    public int limit { get; set; }
   
}

    public class Object
    {
        public string name { get; set; }
        public string locality { get; set; }
        public string street_address { get; set; }
        public List<object> cuisines { get; set; }
        public string region { get; set; }
        public double @long { get; set; }
        public string phone { get; set; }
        public string postal_code { get; set; }
        public List<object> categories { get; set; }
        public bool has_menu { get; set; }
        public string country { get; set; }
        public double lat { get; set; }
        public string id { get; set; }
        public string website_url { get; set; }
        public string resource_uri { get; set; }
    }

    public class Objects
    {
        public string name { get; set; }
        public string locality { get; set; }
        public string street_address { get; set; }
        public List<object> cuisines { get; set; }
        public string region { get; set; }
        public double @long { get; set; }
        public string phone { get; set; }
        public string postal_code { get; set; }
        public List<object> categories { get; set; }
        public bool has_menu { get; set; }
        public string country { get; set; }
        public double lat { get; set; }
        public string id { get; set; }
        public string website_url { get; set; }
        public string resource_uri { get; set; }
    }

}