using System.ComponentModel.DataAnnotations;

namespace DunkStore.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }

        // Relacionamento: Uma categoria tem vários produtos
        public List<Produto>? Produtos { get; set; }
    }
}
