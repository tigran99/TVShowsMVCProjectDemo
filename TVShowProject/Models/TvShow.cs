using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TVShowProject.Models
{
    public class TvShow
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public decimal Rating { get; set; }

        public string ImdbUrl { get; set; }

        [DefaultValue("image/img")]
        public string ImagePath { get; set; }
    }

    public enum Genre
    {
        Drama,
        Comedy,
        Romance,
        [Display(Name = "Romantic Comedy")]
        RomCom,
        Crime,
        Mystery
    }
}
