using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_amatbruno_proyectoBarberTop_p1
{
    internal class dataClass
    {
        //forma1
        public static int[ , ] matrixPrice;

        public static void initMatrix()
        {
            matrixPrice = new int[,] {

                { 6, 8, 6 },
                { 12, 22, 14 },
                { 5, 10, 5 },
                { 20, 35, 30 },
                { 0, 45, 40 }

            };
        }
    }
}
