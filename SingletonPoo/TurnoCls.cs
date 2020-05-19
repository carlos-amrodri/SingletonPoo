using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPoo
{
    public class TurnoCls
    {
        public DateTime _fecha { get; set; }
        public ClienteCls _cliente { get; set; }
        public ProfesionalCls _profesional { get; set; }

        public TurnoCls (DateTime fecha, ProfesionalCls profecional, ClienteCls cliente)
        {
            this._fecha = fecha;
            this._profesional = profecional;
            this._cliente = cliente;
        }
    }
}
