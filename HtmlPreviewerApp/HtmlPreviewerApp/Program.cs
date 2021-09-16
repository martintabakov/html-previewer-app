using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient; 

namespace HtmlPreviewerApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var connection = new SqlConnection(
                "Data Source=localhost;Initial Catalog=HtmlSamples;Integrated Security=True"
            );

            connection.Open();

             
            using (connection)
            {
                var command = new SqlCommand(
                         "INSERT INTO HtmlSamples (SampleID) VALUES(1)"
                );
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
