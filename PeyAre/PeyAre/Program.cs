using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using PeyAre.Components;
using PeyAre.Services;


namespace PeyAre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.AddServiceDefaults();

            // Add MudBlazor services
            builder.Services.AddMudServices();
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<LeaderboardService>();



            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            app.MapDefaultEndpoints();

            //app.MapGet("/api/nationalize/{name}", async (string name) =>
            //{
            //    var httpClient = app.Services.GetRequiredService<HttpClient>();
            //    var response = await httpClient.GetFromJsonAsync<dynamic>($"https://api.nationalize.io?name={name}");
            //    return Results.Ok(response);
            //});

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
