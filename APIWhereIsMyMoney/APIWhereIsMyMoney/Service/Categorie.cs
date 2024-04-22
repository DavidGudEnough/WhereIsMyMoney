namespace APIWhereIsMyMoney.Service
{
    public class Categorie
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }

        public Categorie(int p_id, string p_nom)
        {
            if(p_id < 0)
            {
                throw new ArgumentOutOfRangeException("Le Id ne peut pas etre plus petit que 0");
            }
            if(string.IsNullOrEmpty(p_nom))
            {
                throw new ArgumentNullException("Le nom de la categorie ne peux pas etre vide");
            }
            Id = p_id;
            Nom = p_nom;
        }
    }
}
