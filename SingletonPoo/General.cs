using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPoo
{
    //Esta clase es una clase que ofrece una instancia unica para toda la solucion
    public class General
    {
        private static General _shared = null;

        // el constructor es privado para no poder instanciar desde afuera
        private General() {
            profesionales = new List<ProfesionalCls>();
            clientes = new List<ClienteCls>();
            turnos = new List<TurnoCls>();
        } 

        public static General shared //esta es la variable por la cual se accede a la instancia
        {
            get
            {
                if(_shared == null)
                {
                    _shared = new General();
                }

                return _shared;
            }
        }

        //Aqui guardo lo que nececito
        List<ProfesionalCls> profesionales;
        List<ClienteCls> clientes;
        List<TurnoCls> turnos;

        public void addProfecionales(ProfesionalCls profecional)
        {
            profesionales.Add(profecional);
        }
        public List<ProfesionalCls> getProfecionales()
        {
            return this.profesionales;
        }

        public void addCliente(ClienteCls cli)
        {
            clientes.Add(cli);
        }
        public List<ClienteCls> getClientes()
        {
            return clientes;
        }
        public void addTurno(TurnoCls turno)
        {
            turnos.Add(turno);
        }
        public List<TurnoCls> getTurno()
        {
            return turnos;
        }

        public List<TurnosVisualizar> getTurnosMostrar()
        {
            List<TurnosVisualizar> listado = new List<TurnosVisualizar>();
            foreach(TurnoCls tur in turnos)
            {
                TurnosVisualizar mostrar = new TurnosVisualizar(tur._fecha, tur._profesional, tur._cliente);
                listado.Add(mostrar);
            }
            return listado;
        }
    }
}
