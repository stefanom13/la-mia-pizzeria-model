
using la_mia_pizzeria_model.Database;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
using (PizzaContext db = new PizzaContext())
{
    //create
    //Pizza nuovaPizza = new Pizza();
    //nuovaPizza.NomePizza = "Margherita";
    //nuovaPizza.Descrizione ="La margherita più buona della città";
    //nuovaPizza.PathImage = "Margherita";
    //nuovaPizza.Prezzo = 5.45f;

    Pizza nuovaPizza = new Pizza("Margherita", "La margherita più buona della città", "pathimage", 5.45f);
    Pizza nuovaPizza1 = new Pizza("Capricciosa", "Super pizza Capricciosa", "pathimage", 6.5f);
    Pizza nuovaPizza2 = new Pizza("Tonno e Cipolla", "Rossi", "pathimage", 6.5f);

    db.Add(nuovaPizza);
    db.Add(nuovaPizza1);
    db.Add(nuovaPizza2);

    db.SaveChanges();

    Console.WriteLine("recupero lista pizze");
    List<Pizza> listPizza = db.Pizzas.ToList<Pizza>();

    foreach(Pizza pizza in listPizza)
    {

        Console.WriteLine(pizza.NomePizza);
        Console.WriteLine(pizza.Descrizione);
        Console.WriteLine(pizza.Prezzo);
        Console.WriteLine("*******");
            
     }

}


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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pizza}/{action=Index}/{id?}");

app.Run();
