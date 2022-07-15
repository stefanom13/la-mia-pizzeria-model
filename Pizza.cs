namespace la_mia_pizzeria_model
{
    public class Pizza
    {
        public int Id { get; set; }
        public string NomePizza { get; set; }
        public string Descrizione { get; set; }
        public string PathImage { get; set; }
        public float Prezzo { get; set; }

        public Pizza(int id, string nomePizza, string descrizione, string pathImage, float prezzo)
        {
            Id = id;
            NomePizza = nomePizza;
            Descrizione = descrizione;
            PathImage = pathImage;
            Prezzo = prezzo;
        }
    }
}
