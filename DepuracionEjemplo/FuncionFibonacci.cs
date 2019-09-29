using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepuracionEjemplo
{
    public class FuncionFibonacci : Funciones
    {
        public List<int> llenar()
        {
            int i = 0;
            int a= 0;
            int b = 1;
            int c = 0;
            List<int> valores = new List<int>();


            while (i < this.getNumero())
            {
                i++;
                c = a + b;
                valores.Add(c);
                a = b;
                b = c;


            }

            return valores;
        }

    }
}
