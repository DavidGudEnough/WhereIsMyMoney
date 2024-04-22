namespace APIWhereIsMyMoney.Service
{
    public interface IDepotCategorie
    {
        public void AjouterCategorie(Categorie p_category);
        public IEnumerable<Categorie> ObtenirCategories();
        public void MAJCategorie(Categorie p_category);
        public void SupprimerCategorie(int p_id);
    }
}
