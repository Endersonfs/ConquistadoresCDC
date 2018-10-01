using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCDC.Models
{
    public class SeguroMedico
    {
        [Key]
        public int SeguroID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimemto { get; set; }
        public String NombrePadre { get; set; }
        public bool Estado { get; set; } = true;

    }
}
