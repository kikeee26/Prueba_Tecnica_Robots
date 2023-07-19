using Prueba_Tecnica.Interfaces;

namespace Prueba_Tecnica.Clases.Movimientos
{
    public class MovimientoDerecha : InstruccionRobot
    {
        private readonly Robot robot;

        public MovimientoDerecha(Robot robot)
        {
            this.robot = robot;
        }

        public InstruccionRobot CrearInstruccion(char instruccion, Tablero tablero)
        {
            return ((InstruccionRobot)robot).CrearInstruccion(instruccion, tablero);
        }

        public void EjecutarMovimiento(Tablero tablero)
        {
            if (this.robot.Orientacion == 'N')
            {
                this.robot.Orientacion = 'E';
            }
            else if (this.robot.Orientacion == 'W')
            {
                this.robot.Orientacion = 'N';
            }
            else if (this.robot.Orientacion == 'S')
            {
                this.robot.Orientacion = 'W';
            }
            else if (this.robot.Orientacion == 'E')
            {
                this.robot.Orientacion = 'S';
            }
        }
    }
}
