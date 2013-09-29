using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocuWebAPI.Models
{
    public class VenueDetails
    {

        public class Option
        {

            public string price { get; set; }
            public string name { get; set; }

        }

        public class OptionGroup
        {
            public string text { get; set; }
            public string type { get; set; }
            public List<Option> options { get; set; }
        }

        public class Content
        {
            public string text { get; set; }
            public string type { get; set; }
            public List<OptionGroup> option_groups { get; set; }
            public string description { get; set; }
            public string name { get; set; }
            public string price { get; set; }
        }

        public class Subsection
        {
            public string subsection_name { get; set; }
            public List<Content> contents { get; set; }
        }

        public class Section
        {
            public List<Subsection> subsections { get; set; }
            public string section_name { get; set; }
        }

        public class Menu
        {
            public string menu_name { get; set; }
            public List<Section> sections { get; set; }
            public string currency_symbol { get; set; }
        }

        public class OpenHours
        {
            public List<object> Monday { get; set; }
            public List<object> Tuesday { get; set; }
            public List<object> Friday { get; set; }
            public List<object> Wednesday { get; set; }
            public List<object> Thursday { get; set; }
            public List<object> Sunday { get; set; }
            public List<object> Saturday { get; set; }
        }

        public class Object
        {
            public object facebook_url { get; set; }
            public List<Menu> menus { get; set; }
            public string name { get; set; }
            public OpenHours open_hours { get; set; }
            public string locality { get; set; }
            public string street_address { get; set; }
            public List<object> cuisines { get; set; }
            public string region { get; set; }
            public object redirected_from { get; set; }
            public double @long { get; set; }
            public object twitter_id { get; set; }
            public string phone { get; set; }
            public List<object> similar_venues { get; set; }
            public List<string> categories { get; set; }
            public bool has_menu { get; set; }
            public string country { get; set; }
            public double lat { get; set; }
            public string postal_code { get; set; }
            public string id { get; set; }
            public string website_url { get; set; }
            public string resource_uri { get; set; }
        }

    }
}