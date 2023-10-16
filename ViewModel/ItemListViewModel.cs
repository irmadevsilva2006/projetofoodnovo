using projetofood.Models;

namespace projetofood.ViewModel
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Itens {get;set;}
        public string CategoriaAtual{get;set;}
    }
}