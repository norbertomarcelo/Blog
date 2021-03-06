using Blog.Data;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });
builder
    .Services
    .AddDbContext<BlogDataContext>();
builder
    .Services
    .AddTransient<TokenService>();

var app = builder.Build();
app.MapControllers();

app.Run();