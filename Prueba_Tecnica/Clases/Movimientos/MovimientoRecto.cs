using Prueba_Tecnica.Interfaces;
using System.Linq;

namespace Prueba_Tecnica.Clases.Movimientos
{
    public class MovimientoRecto : InstruccionRobot
    {
        private readonly Robot robot;
        private readonly int posMaxX;
        private readonly int posMaxY;

        public MovimientoRecto(Robot robot, int posMaxX, int posMaxY)
        {
            this.robot = robot;
            this.posMaxX = posMaxX;
            this.posMaxY = posMaxY;
        }

        public InstruccionRobot CrearInstruccion(char instruccion, Tablero tablero)
        {
            return ((InstruccionRobot)robot).CrearInstruccion(instruccion, tablero);
        }

        public void EjecutarMovimiento(Tablero tablero)
        {
            if (robot.Lost)
            {
                return;
            }

            int proximaPosX = robot.X;
            int proximaPosY = robot.Y;

            if (robot.Orientacion == 'N')
            {
                proximaPosY++;
            }
            else if (robot.Orientacion == 'S')
            {
                proximaPosY--;
            }
            else if (robot.Orientacion == 'E')
            {
                proximaPosX++;
            }
            else if (robot.Orientacion == 'W')
            {
                proximaPosX--;
            }

            if (!tablero.ValidarCoordenadas(proximaPosX, proximaPosY))
            {
                if (!Tablero.CoordenadaPerdida(proximaPosX, proximaPosY))
                {
                    robot.Lost = true;
                    Tablero.MarcarCoordenadaPerdida(proximaPosX, proximaPosY);
                }
                return;
            }

            robot.X = proximaPosX;
            robot.Y = proximaPosY;
        }

    }
}
