using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WSClinica.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        public Clinica() { }

        [Key]
        public int IdClinica { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public DateTime FechaInicioAcitivades { get; set; }


        [Required]
        [Column(TypeName = "varchar(60)")]

        public string Email { get; set; }

        public List<Habitacion> Habitaciones { get; set; }

    }
}
