using BitTagDAL;
using BitTagUser.CutomerServices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using BitTagUser.Authentication;

var localhost = "https://localhost:7195";
var deployedURI = "https://bittagapi.azurewebsites.net";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddHttpClient<ICustomer, Customer>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
builder.Services.AddHttpClient<IVehicle, Vehicle>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
builder.Services.AddHttpClient<ICustomerWorkInfo, CustomerWorkInfo>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
builder.Services.AddHttpClient<IOrgs, Orgs>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
builder.Services.AddHttpClient<IBitTagUsers, BitTaaguser>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
//builder.Services.AddHttpClient<IBitTagUser, BitTagsUser>(
//    c => { c.BaseAddress = new Uri("https://localhost:7195"); }
//    );
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<UserAccountService>();
builder.Services.AddScoped<ProtectedSessionStorage>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
