﻿using System.ComponentModel.DataAnnotations;

namespace CSHARP_TEST1.Models
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int CodNacionalidad { get; set; }
        public string Direccion { get; set; }
        public bool Inactivo { get; set; }
        // public ICollection<ClienteDocumentos> ClienteDocumentos { get; set; }
    }
}
