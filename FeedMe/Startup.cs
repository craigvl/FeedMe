﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedMe.Startup))]
namespace FeedMe
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
