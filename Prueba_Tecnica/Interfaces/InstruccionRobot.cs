using Prueba_Tecnica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica.Interfaces
{
    public interface InstruccionRobot
    {
        InstruccionRobot CrearInstruccion(char instruccion, Clases.Tablero tablero);
        void EjecutarMovimiento(Tablero tablero);

    }
}
