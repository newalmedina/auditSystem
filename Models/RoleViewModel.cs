using System.ComponentModel.DataAnnotations;

namespace auditSystem.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [Display(Name = "Nombre Rol")]
        public string Name { get; set; }
    }
}