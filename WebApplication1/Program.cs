
using Microsoft.EntityFrameworkCore;
using Quiz_Platform.BL.Managers.Quizzes;
using Quiz_Platform.DAL.Models;
using Quiz_Platform.DAL.Repositories.QuizRepository;
using Quiz_Platform.DAL.Repositories.UnitOfWork;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //register customer server 
            var connectionString = builder.Configuration.GetConnectionString("QuizDb");

            builder.Services.AddDbContext<QuizSystemContext>(options =>
               options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IQuizRepository, QuizRepository>();
            builder.Services.AddScoped<IQuizManager, QuizManager>();


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
