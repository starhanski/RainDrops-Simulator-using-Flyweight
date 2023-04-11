using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_Legcovagovik
{
    public class RainDrop
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }
        public int Speed { get; set; }

        public RainDrop(int x, int y, int size, Color color, int speed)
        {
            
            X = x;
            Y = y;
            Size = size;
            Color = color;
            Speed = speed ;
        }
    }
     

      

      

   
}

