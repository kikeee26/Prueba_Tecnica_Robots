using Prueba_Tecnica.Clases.Movimientos;
using Prueba_Tecnica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Clases
{
    public class Robot : InstruccionRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Orientacion { get; set; }
        public Tablero Tablero { get; }
        public bool Lost { get; set; } 

        public Robot(int x, int y, char orientacion, bool lost, Tablero tablero)
        {
            X = x;
            Y = y;
            Orientacion = orientacion;
            Lost = lost;
            Tablero = tablero;
        }

        public override string ToString()
        {
            string perdido = (Lost) ? " LOST" : " ";
            string resultado = X + " " + Y + " " + Orientacion + perdido;
            return resultado;
        }



        public InstruccionRobot CrearInstruccion(char instruccion, Tablero tablero)
        {
            switch (instruccion)
            {
                case 'L':
                    return new MovimientoIzquierda(this);
                case 'R':
                    return new MovimientoDerecha(this);
                case 'F':
                    return new MovimientoRecto(this, tablero.posMaxX, tablero.posMaxY);
                default:
                    throw new ArgumentException("Invalid instruction: " + instruccion);
            }
        }

        public void EjecutarMovimiento(Tablero tablero)
        {
            throw new NotImplementedException();
        }
    }
}
