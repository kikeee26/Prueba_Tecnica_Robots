using Prueba_Tecnica;
using Prueba_Tecnica.Clases;
using Prueba_Tecnica.Clases.Movimientos;
using Prueba_Tecnica.Interfaces;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int totalRobots = 0;
        List<Robot> listaRobots = new List<Robot>();

        string[] arrayTablero = Utilidades.LeerPosicion(true);
        Tablero tablero = new Tablero(Convert.ToInt32(arrayTablero[0]), Convert.ToInt32(arrayTablero[1]));

        Console.WriteLine("Cuantos robots vas a usar?");
        totalRobots = Convert.ToInt32(Console.ReadLine());

        for (int cont = 0; cont < totalRobots; cont++)
        {
            Console.WriteLine("Robot Nº" + (cont + 1));

            string[] entradaRobotPos = Utilidades.LeerPosicion(false);
            int x = int.Parse(entradaRobotPos[0]);
            int y = int.Parse(entradaRobotPos[1]);
            char orientacion = char.Parse(entradaRobotPos[2]);
            Robot robot = new Robot(x, y, orientacion, false, tablero);

            char[] movimientoRobot = Utilidades.LeerMovimientos();
            List<InstruccionRobot> instrucciones = new List<InstruccionRobot>();

            foreach (var movimiento in movimientoRobot)
            {
                if (char.TryParse(movimiento.ToString(), out char instruccion))
                {
                    instrucciones.Add(robot.CrearInstruccion(instruccion, tablero));
                }
            }

            bool robotPerdido = false;
            foreach (var instruccion in instrucciones)
            {
                if (robotPerdido)
                {
                    break; 
                }

                instruccion.EjecutarMovimiento(tablero);

                if (robot.Lost)
                {
                    robotPerdido = true;
                }
            }

            listaRobots.Add(robot);
        }

        Console.WriteLine("Resultado: ");
        foreach (Robot r in listaRobots)
        {
            Console.WriteLine(r.ToString());
        }
    }
}
