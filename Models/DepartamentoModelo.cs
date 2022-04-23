using System.ComponentModel.DataAnnotations; // nos permite usar validadores
namespace Sistema_de_ventas.Models
{
    public class DepartamentoModelo
    {
        public int DEP_ID { get; set; }
        // valor requrido
        [Required(ErrorMessage ="El nombre es requeido")]
        public string DEP_NOMBRE { get; set; }
        
    }
}
