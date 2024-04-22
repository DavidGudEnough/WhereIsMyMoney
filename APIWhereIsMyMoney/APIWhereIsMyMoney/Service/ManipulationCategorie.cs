namespace APIWhereIsMyMoney.Service
{
    public class ManipulationCategorie : IDepotCategorie
    {
        private IDepotCategorie m_depotCategory;
        public ManipulationCategorie(IDepotCategorie depotCategory)
        {
            m_depotCategory = depotCategory;
        }
        public void AjouterCategorie(Categorie p_category)
        {
            m_depotCategory.AjouterCategorie(p_category);
        }

        public IEnumerable<Categorie> ObtenirCategories()
        {
            return m_depotCategory.ObtenirCategories();
        }

        public void MAJCategorie(Categorie p_category)
        {
            m_depotCategory.MAJCategorie(p_category);
        }

        public void SupprimerCategorie(int p_id)
        {
            m_depotCategory.SupprimerCategorie(p_id);
        }
    }
}
