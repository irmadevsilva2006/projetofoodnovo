using System.ComponentModel.DataAnnotations;

namespace projetofood.Models
{
    public class Categoria
    {
       
        public int CategoriaId{get;set;}
        [Display (Name = "Nome da Categoria")]
        public string Nome {get;set;}
    }
}