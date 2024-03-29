﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimento_Web_2___Rodrigo.Models
{
    [MetadataType(typeof(PRODUTO_MD))]
    public partial class PRODUTO { }


    public class PRODUTO_MD
    {
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "campo obrigatório")]
        [StringLength(50, ErrorMessage ="Máximo de 50 Caractéres")]
        public string Descricao { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "campo obrigatório")]
        //[MaxLength(18, ErrorMessage ="Máximo 18 caractéres")]
        public decimal Valor { get; set; }


        [DisplayName("Categoria")]
        [Required(ErrorMessage = "campo obrigatório")]
        public int CategoriaId { get; set; }
    }
}