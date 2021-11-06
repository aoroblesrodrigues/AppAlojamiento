﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppAloj.Entidades
{
    public class Revision
    {
        [Key]
        public int IdRevision { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Mensaje { get; set; }

        [Required]
        public int IdReserva { get; set; }

        public string indice { get; set; }


        public Reserva Reserva { get; set; }
    }
}
