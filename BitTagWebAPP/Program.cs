using BitTagUser.CutomerServices;
using BitTagWebAPP.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
var localhost = "https://localhost:7195";
var deployedURI = "https://bittagapi.azurewebsites.net";

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddHttpClient<IOrganizations, Organizations>(
    c =>{c.BaseAddress = new Uri(localhost);}
    );
builder.Services.AddHttpClient<IOrgEmployees, OrgEmployees>(
    c => { c.BaseAddress = new Uri(deployedURI); }
    );
builder.Services.AddHttpClient<IBitTag, BitTags>(
    c => { c.BaseAddress = new Uri(localhost); }
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
