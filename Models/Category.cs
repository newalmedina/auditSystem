using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auditSystem.Models
{
    public class Category
    {
        [Key] //esto hace que este campo sea primary key en la BD
        public int Id { get; set; }

        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        [Display(Name = "Descripción")]
        //  [Required(ErrorMessage = "El campo descripción es obligatorio")]
        public string Description { get; set; }


        [DefaultValue(false)]
        [Display(Name = "Activo")]
        [Required(ErrorMessage = "El campo activo es obligatorio")]
        public bool Active { get; set; }


        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha creación")]
        [DefaultValue(null)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime? Created_at { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha modificación")]
        [DefaultValue(null)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime? Updated_at { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha eliminación")]
        [DefaultValue(null)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy HH:mm}")]
        public DateTime? Deleted_at { get; set; }
    }
}