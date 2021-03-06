﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaborDeCasa.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoriaNome { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
