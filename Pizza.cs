using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_model
{
    public class Pizza : DbContext
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomePizza { get; set; }
        public string Descrizione { get; set; }
        public string PathImage { get; set; }
        public float Prezzo { get; set; }

        public Pizza(string nomePizza, string descrizione, string pathImage, float prezzo)
        {
            
            NomePizza = nomePizza;
            Descrizione = descrizione;
            PathImage = pathImage;
            Prezzo = prezzo;
        }
    }
}
