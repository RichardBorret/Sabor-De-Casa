using Microsoft.AspNetCore.Mvc.ModelBinding;
using SaborDeCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaborDeCasa.ViewModels
{

    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
