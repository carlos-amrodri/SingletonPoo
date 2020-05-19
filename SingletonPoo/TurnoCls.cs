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
        public ProfecionalCls _profecional { get; set; }

        public TurnoCls (DateTime fecha, ProfecionalCls profecional, ClienteCls cliente)
        {
            this._fecha = fecha;
            this._profecional = profecional;
            this._cliente = cliente;
        }
    }
}
