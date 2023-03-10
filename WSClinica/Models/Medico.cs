using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WSClinica.Models
{

    [Table("Medico")]
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]

        [ForeignKey("Nombre")]
        public Especialidad Especialidad { get; set; }

        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int Matricula { get; set; }

        public List<Paciente> Pacientes { get; set; }
    }
}
