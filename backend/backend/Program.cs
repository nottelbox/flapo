using backend.Repository;
using backend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var clientOrigin = "http://localhost:5173";
builder.Services.AddCors(options =>
{
    options.AddPolicy("ClientPolicy", policy =>
    {
        policy
            .WithOrigins(clientOrigin)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<ArticleHttpClient>();
builder.Services.AddScoped<ArticleFilterService>();
builder.Services.AddScoped<ArticleSortingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors("ClientPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
