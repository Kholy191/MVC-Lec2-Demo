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

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Before");
                await next(); // Call the next middleware
                Console.WriteLine("After");
            });

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/{id}", async context =>
            {
                Console.WriteLine("Done");
                await context.Response.WriteAsync($"Id = {context.Request.RouteValues["id"]}");
            });


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=index}/{id?}/{name?}"
                );

            #endregion

            app.Run();
        }
    }
}
