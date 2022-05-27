using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ9
{
    public class Serie
    {
        private int num { get; set; }
        private int total { get; set; }
        //private String valor { get; set; }

        private int cant { get; set; }

        public Serie()
        {
            this.num = 0;
            this.total = 0;
            //this.valor = "";
            this.cant = 0;
        }

        public void promedio()
        {
            do
            {
                cant++;
                Console.WriteLine("Escriba un numero");
                String valor = Console.ReadLine();
                num = Convert.ToInt32(valor);
                total = num + total;
            } while (num != 0);
             int resultado = total / (cant - 1);
            Console.WriteLine("El promedio es: " + resultado);
        }


    }
}
