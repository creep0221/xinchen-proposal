using Microsoft.AspNetCore.Mvc.Filters;
using xinchen_web;
using MongoDB.Driver;
using xinchen_web.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionStrings = new ConnectionStrings();
builder.Configuration.GetSection("ConnectionStrings").Bind(connectionStrings);
builder.Services.AddTransient<MongoClient, MongoClient>(provider =>
{
    return new MongoClient(connectionStrings.Mongo);
});
builder.Services.AddScoped<MongoSvc>();


//builder.Services.AddSingleton<MongoClient>(new MongoClient());
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
