using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaRepositorio.Entidades
{
    public class Clientes
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Clientes()
        {
            IdCliente = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
        }
    }
}
