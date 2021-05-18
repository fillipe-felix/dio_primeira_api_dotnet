using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dio_primeira_api_dotnet.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
    }
}