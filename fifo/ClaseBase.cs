using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifo
{
    class ClaseBase
    {
        private int _ciclo;
        ClaseBase _siguiente;
        Random ss = new Random();
        public ClaseBase Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public int Ciclo
        {
            get { return _ciclo; }
            set { _ciclo = value; }
        }
        public ClaseBase()
        {
            _ciclo  = ss.Next(4, 15);
        }
        public override string ToString()
        {
            return "Proceso:  = " + _ciclo;
        }
    }
}
