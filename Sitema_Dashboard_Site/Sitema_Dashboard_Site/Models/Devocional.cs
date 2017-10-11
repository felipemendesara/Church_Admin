using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sitema_Dashboard_Site.Models
{
    public class Devocional
    {
        [Display(Name = "Código da devocional")]
        [Key]
        public int IdDevocional { get; set; }
        [Required]
        [Display(Name = "Titulo da devocional")]
        public string TituloDevocional { get; set; }
        [Required]
        [Display(Name = "Texto da devocional")]
        public string TextoDevocional { get; set; }
        [Required]
        [Display(Name = "Autor da devocional")]
        public string Autor { get; set; }
        [Required]
        [Display(Name = "Livro base da devocional")]
        public string LivroBase { get; set; }
        [Required]
        [Display(Name = "Capitulo da devocional")]
        public int CapituloBase { get; set; }
        [Display(Name = "Versiculo inicio da devocional")]
        public string VersiculoInicioBase { get; set; }
        [Display(Name = "Versiculo final da devocional")]
        public string VersiculoFinalBase { get; set; }
    }
}