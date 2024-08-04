
using Microsoft.EntityFrameworkCore;
using PocketBook.Core.IConfiguration;
using PocketBook.Data;

namespace PocketBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // First add DbContext Interceptor for audit
            // ref: https://www.milanjovanovic.tech/blog/how-to-use-ef-core-interceptors
            // ref: https://www.youtube.com/watch?v=mAlO3OuoQvo
            // builder.Services.AddSingleton<UpdateAuditableInterceptor>();
            
            // builder.Services.AddSingleton<InsertOutboxMessagesInterceptor>();

            // Ref: https://dev.to/moe23/step-by-step-repository-pattern-and-unit-of-work-with-asp-net-core-5-3l92
            // Add database service via ApplicationDbContect options           
            builder.Services.AddDbContext<ApplicationDbContext> (options =>   //(sp, options => 
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
                //.AddInterceptors(
                //.sp.GetRequiredService<UpdateAuditableInterceptor>())); //,
                // sp.GetRequiredService<InsertOutboxMessagesInterceptor>())

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Add services to the container.dot

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Adding the Unit of Work to the DI Container
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
