
using LoginServer.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);




            // Add services to the container.

            builder.Services.AddControllers();


            //injection DataBase

           string connectionstring = builder.Configuration.GetSection("LoginDBConnectionStrings").Value;


           builder.Services.AddDbContext<LoginDemoDbContext>(options => options.UseSqlServer(connectionstring));

           




            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

           

            

        }
    }
}