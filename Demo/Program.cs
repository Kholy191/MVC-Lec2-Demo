namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Services Config

            builder.Services.AddControllersWithViews();

            #endregion

            var app = builder.Build();

            #region Routing

            app.UseRouting();

            app.UseStaticFiles();

            app.MapGet("/", () => "Hello World!");

            

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=index}/{id?}"
                );

            #endregion

            app.Run();
        }
    }
}
