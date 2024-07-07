using BlazorAppFullStack.Components;
using BlazorAppFullStack.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddBlazorBootstrap();

builder.Services.AddDbContext<BlazorAppFullStackContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorAppFullStackContext") ?? throw new InvalidOperationException("Connection string 'BlazorAppFullStackContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter(); ;

// Add services to the container.

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
