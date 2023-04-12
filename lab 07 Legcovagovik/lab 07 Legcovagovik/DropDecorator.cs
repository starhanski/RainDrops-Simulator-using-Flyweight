using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_Legcovagovik
{
    public class DropDecorator : RainDrop
    {
        public DropDecorator(RainDrop rainDrop, Color newcolor)
            : base(rainDrop.X, rainDrop.Y, rainDrop.Size, rainDrop.Color, rainDrop.Speed)
        {
            Color = newcolor;
        }

        public int NewColor { get; set; }
    }

}
