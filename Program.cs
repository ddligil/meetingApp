using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews(); 
var app = builder.Build();

app.UseStaticFiles(); //static fileler için middleware

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
); 


app.Run();
