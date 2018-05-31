using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifo
{
    class Estructura
    {
        Random prob = new Random();
        ClaseBase nuevo;
        ClaseBase inicio;
        public string Administracion()
        {
            inicio = null;

            int res = 0, temp=0,temp2=0,temp3=0, total=0;
            string info;
            for (int i = 0; i < 300; i++)
            {
                res = prob.Next(1, 101);
                if (res <= 35)
                {
                   nuevo = new ClaseBase();
                    Encolar(nuevo);
                    total += nuevo.Ciclo;
                    temp3++;
                }
                if(ver() != null)
                {
                    ver().Ciclo--;
                    if (ver().Ciclo == 0)
                    {
                        Desencolar();
                        temp2++;
                    }
                }
                else
                {
                    temp++;
                }
            }
            return info = "Vacia: " + temp + " veces, Completados: " + temp2 + " veces, Por Atender:" + (temp3 - temp2) + " Total: " + (total - (300- temp));
        }
        public ClaseBase ver()
        {
            return inicio;
        }
        public void Encolar(ClaseBase nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                encolar(nuevo, inicio);
            }

        }
        private void encolar(ClaseBase nuevo, ClaseBase quien)
        {
            if(quien.Siguiente != null)
            {
                encolar(nuevo, quien.Siguiente);
            }
            else
            {
                quien.Siguiente = nuevo;
            }
        }
        public void Desencolar()
        {
            if(inicio.Siguiente == null)
            {
                inicio = null;
            }
            else
            {
            inicio = inicio.Siguiente;
            }
        }
    }
}
