using static Interface.Controllers.HomeController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();


var produit1 = new Produit{ Nom = "pates", Prix = 10.99m };
var client1 = new Client{ Nom = "John Doe", email = "john.doe@example.com" };
produit1.Afficher();
client1.Afficher();

IAffichable element = new Client { Nom = "Jane Smith", email = "jane.smith@example.com" };
element.Afficher();