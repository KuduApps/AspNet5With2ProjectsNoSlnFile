using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using ClassLibrary;

namespace AspNet5With2ProjectsAndSlnFile
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async ctx =>
            {
                ctx.Response.ContentType = "text/plain";
                await ctx.Response.WriteAsync(Class1.WelcomeMessage);
            });
        }
    }
}
