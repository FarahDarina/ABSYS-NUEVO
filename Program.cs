using System;
using ABSYS.Components;
using ABSYS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios
builder.Services.AddRazorPages(); // <- necesario para usar _Host.cshtml
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configurar pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();               // <- conecta con Blazor Server
app.MapFallbackToPage("/_Host"); // <- usa _Host.cshtml como página principal

app.Run();

