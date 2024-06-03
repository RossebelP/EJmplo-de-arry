using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace listado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tamoño de la lista");
            int n = int.Parse(Console.ReadLine());
            //con eso estamo llamdo a n 
            int[]lista = new int[n];
            int[]lista2 = new int[n];
            int[] prom = new int[n];
            generar(lista, lista2);
            mostrar(lista, lista2,prom);
            Calcular(lista);    
            Console.ReadKey();
        }
        static void generar(int[] a ,int[]b)
        {
            Random rnd = new Random();
            for (int i = 0; i < a .Length; i++)
            {
                a[i] = rnd.Next(21);
                b[i] = rnd.Next(21);
            }
        }
        static void mostrar(int[] a, int[] b, int[]c)
        {
            Console.WriteLine("\nNota 1\tNota2\tPromedio\tcondicion");
            int prom;
            for (int i = 0;i < a .Length; i++)
            {
                c[i] = (a[i] + b[i])/2;
                prom = (a[i] + b[i]) /2;
                if (c[i]<12) Console.WriteLine(a[i] + "\t" + b[i] + "\t" + c[i] + "\tDesaprobado");
                else Console.WriteLine(a[i] + "\t" + b[i] + "\t" + c[i] + "\tAprobado");
            }  
        }
        static void Calcular(int[] c)
        {
            float suma  = 0, n = c.Length;
            int max = 0;
            int min = 21;

            for (int i = 0; i<c.Length; i++)
            {
                suma += c[i];
                if (c[i] > max) max = c[i];
                if (c[i] < min) min = c[i];
            }
            Console.WriteLine("Promedio " + (suma / c.Length)); 
            Console.WriteLine("nota menor " + max);
            Console.WriteLine("Nota mayor" + min);
        }
    }
}
