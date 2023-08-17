using BitTagDAL;
using BitTagUser.CutomerServices;
using BitTagUser.Data;
using BitTagWebAPP.CutomerServices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient<ICustomer, Customer>(
    c => { c.BaseAddress = new Uri("https://localhost:7125"); }
    );
builder.Services.AddHttpClient<IVehicle, Vehicle>(
    c => { c.BaseAddress = new Uri("https://localhost:7125"); }
    );
builder.Services.AddHttpClient<IOrgs, Orgs>(
    c => { c.BaseAddress = new Uri("https://localhost:7125"); }
    );
builder.Services.AddHttpClient<ICustomerWorkInfo, CustomerWorkInfo>(
    c => { c.BaseAddress = new Uri("https://localhost:7125"); }
    );
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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
