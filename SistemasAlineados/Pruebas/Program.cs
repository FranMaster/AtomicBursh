using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemasPlanetarios SistemaSolar = new SistemasPlanetarios
            {
                ListadoPlanetas=new List<Planeta>
                {
                    new Planeta (true,1000,"Mercurio",1),
                    new Planeta (true,2000,"Tierra",2),
                    new Planeta (true,3000,"Venus",0)
                }
            };

            int DiasTranscurridos = 0;
            while (true)
            {
               
                Console.WriteLine("Bienvenido Señor Todo poderoso y amo de este sistema Solar.");

                Console.WriteLine();
                foreach (var item in SistemaSolar.ListadoPlanetas)
                {
                    item.DiasOrbita = DiasTranscurridos;
                    item.RecalcularPosicion();
                    Console.WriteLine($"Nombre Planeta:{item.Nombre},Angulo con respecto al eje x:{item.AnguloActual}°,Posicion en eje X:{item.PosicionX},Posicion en eje Y:{item.PosicionY}");
                }
                Console.WriteLine();
                Console.WriteLine("¿Desea continuar? y(Any Key)/n");
                string response = Console.ReadLine();
                if (response == "n") break;
                DiasTranscurridos++;

            }

          

        }
    }
}
