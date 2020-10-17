using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

// C#9 顶级语句
//Console.WriteLine("12313123");
//int index = 0;
//index++;
//Console.WriteLine("index:{0}", index);

namespace Sample01.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(weBuilder =>
                {
                    weBuilder.UseStartup<Startup>();
                }).UseAutofac();
    }
}
