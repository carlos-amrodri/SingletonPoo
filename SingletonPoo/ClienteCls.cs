using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPoo
{
    public class ClienteCls
    {
        public int _legajo { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }

        public ClienteCls(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
