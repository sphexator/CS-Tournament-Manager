using CS_Tournament_Manager.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddMediatR(x =>
{
    x.Lifetime = ServiceLifetime.Singleton;
    x.RegisterServicesFromAssembly(typeof(Program).Assembly ??
                                   throw new InvalidOperationException("Couldn't find entry assembly for mediatr"));
});
builder.Services.AddDbContextPool<DbService>(x =>
{
    x.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString"));
    x.ConfigureWarnings(e =>
    {
        e.Default(WarningBehavior.Log);
    });
});

var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();