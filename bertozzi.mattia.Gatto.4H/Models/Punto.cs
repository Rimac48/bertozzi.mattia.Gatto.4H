using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace bertozzi.mattia.Gatto._4H.Models
{
    class Punto
    {
        //variabili private
        int _x;
        int _y;

        //public int X { get; set; }
        //public int Y { get; set; }


        public int X
        {
            get
            {
                return _x;
            }

            set

            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set

            {
                _y = value;
            }
        }



        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
