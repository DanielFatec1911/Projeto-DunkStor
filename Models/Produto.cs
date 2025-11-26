using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DunkStore.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "URL da Imagem")]
        public string ImagemUrl { get; set; } 

    
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
