﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechBlogCMS.UI.Startup))]
namespace TechBlogCMS.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
