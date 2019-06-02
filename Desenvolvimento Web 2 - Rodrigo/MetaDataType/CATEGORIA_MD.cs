using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desenvolvimento_Web_2___Rodrigo.Models
{
    [MetadataType(typeof(CATEGORIA_MD))]
    public partial class CATEGORIA { }


    public partial class CATEGORIA_MD
    {        
        [Required(ErrorMessage = "campo obrigatório")]
        [StringLength(50, ErrorMessage = "Máximo de 50 Caractéres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}