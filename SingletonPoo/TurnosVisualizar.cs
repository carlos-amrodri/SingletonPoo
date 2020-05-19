using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPoo
{
    public class TurnosVisualizar
    {
        public DateTime fecha { get; set; }
        public string profecional { get; set; }
        public string cliente { get; set; }
        public string clientaApellido { get; set; }

        public TurnosVisualizar(DateTime fecha,ProfesionalCls prof, ClienteCls cli)
        {
            this.fecha = fecha;
            this.profecional = prof._nombre;
            this.cliente = cli._nombre;
            this.clientaApellido = cli._apellido;
        }
    }
}
