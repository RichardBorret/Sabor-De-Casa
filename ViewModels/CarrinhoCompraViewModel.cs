using Microsoft.AspNetCore.Mvc.ModelBinding;
using SaborDeCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaborDeCasa.ViewModels
{
  
    public class CarrinhoCompraViewModel
    {
        public CarrinhoCompra CarrinhoCompra { get; set; }
        public decimal CarrinhoCompraTotal { get; set; }
    }
}
