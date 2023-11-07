global using IRDb.Models;
using IRDb.Database;
using IRDb.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins",
    builder =>
    {
        builder.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var connectionString = builder.Configuration.GetConnectionString("MovieDbConnection");
builder.Services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("MyAllowSpecificOrigins");

app.UseAuthorization();

app.MapControllers();


app.Run();
