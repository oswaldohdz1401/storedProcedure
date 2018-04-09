using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsContacto
    { 
        //opcion a ejecutar en el SP
        public int opc { get; set; }


        // Propiedades de la clase
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}