using System.ComponentModel.DataAnnotations;

namespace GerencimanetoMercadorias.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriasId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public ICollection<Produtos> Produtos { get; set; }

    }
}
