using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaborDeCasa.Models
{
    [Table("Lanches")]
    public class Lanche
    {        
        public int LancheId { get; set; }


        [Display(Name = "Informe o nome")]
        [StringLength(80, MinimumLength = 10)]
        public string Nome { get; set; }


        [MinLength(20)]
        [MaxLength(250)]
        public string DescricaoCurta { get; set; }


        [MaxLength(250)]
        public string DescricaoDetalhada { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Preco { get; set; }

        [Required]
        public bool IsLanchePreferido { get; set; }
        [Required]
        public bool EmEstoque { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
