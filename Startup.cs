using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HelloWeb
{
    public class MyClass {
      public string From;
      public string Message;
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                MyClass output = new MyClass();
                output.From = "Sage";
                output.Message = "Hi there!";

                string json = JsonConvert.SerializeObject(output);
                return context.Response.WriteAsync(json);
            });
        }
    }
}
