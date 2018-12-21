using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<HelloComponent>();
            //app.Run(ctx =>
            //{
              //  return ctx.Response.WriteAsync("Hello");
            //}
               // );
        }
    }
}
