﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{

   public class Startup
        {
            public void Configure(IApplicationBuilder app)
            {
                app.Run( context => 
                    {
                        return context.Response.WriteAsync("Hello DotNetCore on the web");
                    }
                );
            }
        }
    public class Program
    {

        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseStartup<Startup>().UseUrls("http://*:5000")
                        .Build();

            host.Run();


            // Console.WriteLine("Hey, welcome to the dotnet world. Your Name?");
            // var name = Console.ReadLine();
            // Console.WriteLine($" Hey {name}, I hope your core journey takesoff to new heights!!!");
        }
    }
}
