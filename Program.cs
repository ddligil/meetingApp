using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews(); //Mvc nin özelliklerini kullanabilmem için ekliyorum
var app = builder.Build();

app.UseStaticFiles(); //static filelr için middleware

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
); //controller/action/id? şemasını aktarmak için aslında


app.Run();
