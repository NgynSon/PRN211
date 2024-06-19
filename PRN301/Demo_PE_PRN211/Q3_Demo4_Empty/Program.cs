namespace Q3_Demo4_Empty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);/////////////////
            builder.Services.AddControllersWithViews();
            var app = builder.Build();//////////////////


            /*app.MapGet("/", () => "Hello World!");*/
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=List}/{id?}");

            app.Run();
        }
    }
}