 namespace Session2_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add two any service u need to the container
            builder.Services.AddControllersWithViews();
            //builder.Services.AddControllers();
            //builder.Services.AddRazorPages();
            //builder.Services.AddMvc();

            var app = builder.Build();
            app.UseStaticFiles();//Middleware use for Static File
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/Bassim", () => "Hello Bassim");
            //app.MapGet("/SignIn", SignIn);
            ////http://localhost:4555/Movies/GetMovie/1
            app.MapControllerRoute(
                name: "Default",
                pattern:"/{controller=Home}/{action=Index}/{id:int?}"
                );

            app.Run();
        }
        static string SignIn()
        {
            return "signin";
        }
    }
}
