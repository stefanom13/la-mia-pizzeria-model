using la_mia_pizzeria_model;
using Microsoft.EntityFrameworkCore;




namespace la_mia_pizzeria_model
{

    public class PizzaContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredienti> Ingrediente { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizza;Integrated Security=True");
        }


    }


}

