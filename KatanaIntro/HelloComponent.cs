using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class HelloComponent
    {
        AppFunc _next;
        public HelloComponent(AppFunc next)
        {
            _next = next;
        }
        public Task Invoke(IDictionary<string,object> environment)
        {
            var resp = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(resp))
            {
                return writer.WriteAsync("Hello");
            }
        }
    }
}
