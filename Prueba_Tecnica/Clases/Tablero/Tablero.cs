using System;
using System.Collections.Generic;

namespace Prueba_Tecnica.Clases
{
    public class Tablero
    {
        public int posMaxX { get; set; }
        public int posMaxY { get; set; }
        public static List<string> coordenadasPerdidas { get; set; }


        public Tablero(int pos_maxX, int pos_maxY)
        {
            posMaxX = pos_maxX;
            posMaxY = pos_maxY;
            coordenadasPerdidas = new List<string>();
        }

        public bool ValidarCoordenadas(int x, int y)
        {
            return x >= 0 && x <= posMaxX && y >= 0 && y <= posMaxY;
        }

        public static void MarcarCoordenadaPerdida(int x, int y)
        {
            coordenadasPerdidas.Add(x + " " + y);
        }

        public static bool CoordenadaPerdida(int x, int y)
        {
            return coordenadasPerdidas.Contains(x + " " + y);
        }
    }
}
