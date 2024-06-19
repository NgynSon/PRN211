var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Schedule}/{action=byDate}/{Id?}");

app.UseSession();
app.Run();