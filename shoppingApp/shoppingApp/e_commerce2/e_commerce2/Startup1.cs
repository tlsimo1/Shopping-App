﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(e_commerce2.Startup1))]

namespace e_commerce2
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType=DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath=new PathString("/Pages/Acount/Login")

            });
        }
    }
}
