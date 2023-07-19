using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica
{
    public class Utilidades
    {
        public static string[] LeerPosicion(bool posicionInicial)
        {
            while (true)
            {
                if (posicionInicial) Console.WriteLine("Dime cuanto ocupara el tablero: ");
                else Console.WriteLine("Dime la posicion inicial y su orientación: ");

                string entrada = Console.ReadLine();

                string[] entradaRobotPos = entrada.Split(' ');

                if (entradaRobotPos.Length > 0)
                {
                    return entradaRobotPos;
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta.");
                }
            }
        }
        public static char[] LeerMovimientos()
        {
            while (true)
            {
                Console.WriteLine("Ahora escribe los movimientos:");
                string entrada = Console.ReadLine();

                char[] entradaRobotPos = entrada.ToCharArray();

                if (entradaRobotPos.Length > 0)
                {
                    return entradaRobotPos;
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta.");
                }

                foreach (char c in entradaRobotPos) 
                { 
                    Console.WriteLine(c); 
                }

                
            }
        }
    }
}
