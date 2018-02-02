using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HelloWeb
{
    public class MyClass {
      public string MyString;
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
                MyClass output = new MyClass();
                output.MyString = "Hello there!";

                string json = JsonConvert.SerializeObject(output);
                return context.Response.WriteAsync(json);
            });
        }
    }
}
