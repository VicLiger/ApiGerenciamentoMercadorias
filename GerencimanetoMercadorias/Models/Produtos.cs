using System.ComponentModel.DataAnnotations;

namespace GerencimanetoMercadorias.Models
{
    public class Produtos
    {
        [Key]
        public int ProdutosId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required]
        public int Estoque { get; set; }

        [Required]
        public decimal Preco {  get; set; }

        [Required]
        public DateTime UltimaAlteracao { get; set; }

        public int CategoriaId { get; set; }
        public Categorias Categorias { get; set; }

        public Produtos()
        {
            UltimaAlteracao = DateTime.Now;
        }

    }
}
