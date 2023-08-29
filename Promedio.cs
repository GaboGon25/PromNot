using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PromNot
{
    public class Promedio
    {
        public string nombre;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;

        public double notabaja()
        {
            int menor = int.MaxValue;

            if (nota1 < nota2) menor = nota1; else menor = nota2;
            if (nota3 < menor) menor = nota3;
            if (nota4 < menor) menor = nota4;
            return menor;
        }


        public double promedio()
        {
            return (nota1 + nota2 + nota3 + nota4 - notabaja()) / 3.0;
        }

        public string condicion()
        {
            double prome = promedio();
            if (prome > 90)
            {
                return "EXCELENTE";
            }
            else if (prome > 80 && prome <= 90)
            {
                return "MUY BUENO";
            }
            else if (prome > 70 && prome <= 80)
            {
                return "BUENO";
            }
            else if (prome > 60 && prome <= 70)
            {
                return "REGULAR";
            }
            else if (prome <= 60)
            {
                return "REPROBADO";
            }
            return "";

        }
        
        
    }
}
