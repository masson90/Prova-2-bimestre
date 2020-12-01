using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova_2_bimestre.Models
{
    public class secret
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(255, ErrorMessage ="Maximo de 255 caracteres")]
        [Display(Name = "Texto: ")]
        public string encriptacao { get; set; }


    }
}