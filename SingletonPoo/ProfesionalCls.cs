using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPoo
{
    public class ProfesionalCls
    {
        public int _dni { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }

        public ProfesionalCls(int dni, string nombre, string apellido)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
