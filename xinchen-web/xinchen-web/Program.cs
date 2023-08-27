using Microsoft.AspNetCore.Mvc.Filters;
using xinchen_web;
using MongoDB.Driver;
using xinchen_web.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using xinchen_web.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var connectionStrings = new ConnectionStrings();
builder.Configuration.GetSection("ConnectionStrings").Bind(connectionStrings);
var marketSetting = new MarketSetting();
builder.Configuration.AddJsonFile("marketsetting.json");
builder.Configuration.GetSection("MarketSetting").Bind(marketSetting);
builder.Services.AddSingleton(marketSetting);
var t = marketSetting.MarketDetail;
builder.Services.AddTransient<MongoClient, MongoClient>(provider =>
{
    return new MongoClient(connectionStrings.Mongo);
});
builder.Services.AddScoped<MongoSvc>();
builder.Services.AddSingleton<MarketDescription>();

//builder.Services.AddSingleton<MongoClient>(new MongoClient());
// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AllowAnonymousToPage("/Index");
    options.Conventions.AuthorizePage("/Document");
    options.Conventions.AuthorizePage("/Proposal");

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options => { options.LoginPath = new PathString("/Index"); } //设置登录页面为/Login
);
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


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
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

app.Run();
