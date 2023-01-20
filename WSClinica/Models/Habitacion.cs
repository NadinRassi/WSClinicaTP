using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WSClinica.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {

        [Key]
        public int IdMedico { get; set; }

        [Range(18, 100, ErrorMessage = "Solo se permiten números entre el 1 y el 100.")]
        public int Numero { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Estado { get; set; }


        public int ClinicaId { get; set; }


        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }


    }
}
