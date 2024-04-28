using FithCourseProject.Data.Context;
using FithCourseProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<FifthDbContext>(config =>
{
    config.UseSqlServer(Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IFriendsRepositoryService, FriendsRepositoryService>();

var app = builder.Build();

app.Map("/total-friends", (context) =>
{
   // var friendService = app.Services.GetService<IFriendsRepositoryService>();

    context.Run(async (httpContext) => { await httpContext.Response.WriteAsync($"Friends : Not Implemented "); });
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
