using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_Legcovagovik
{
    public partial class Form1 : Form
    {
        private List<RainDrop> rainDrops;
        private Random random = new Random();
        

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            rainDrops = new List<RainDrop>();

            // Додавання випадкових крапель дощу
            for (int i = 0; i < 200; i++)
            {
                int size = random.Next(10, 30);
                int x = random.Next(0, ClientSize.Width);
                int y = random.Next(0, ClientSize.Height);
                int speed = random.Next(3, 7);

                Color color = Color.FromArgb(167, 184, 196);
               
                RainDrop rainDrop = new RainDrop(x, y, size, color, speed);
                Color newcolor = Color.FromArgb(random.Next(100, 255), random.Next(100, 255), random.Next(100, 255));
                DropDecorator decoratedRainDrop = new DropDecorator(rainDrop, newcolor);
                rainDrops.Add(decoratedRainDrop);
                rainDrops.Add(rainDrop);
            }
        }
        


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }
       public void Draw(Graphics g)
        {
            foreach (RainDrop rainDrop in rainDrops)
            {
                
                g.FillEllipse(new SolidBrush(rainDrop.Color), rainDrop.X, rainDrop.Y, rainDrop.Size/9, rainDrop.Size);
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (RainDrop rainDrop in rainDrops)
            {
                
                rainDrop.Y += rainDrop.Speed;
                if (rainDrop.Y > ClientSize.Height + rainDrop.Size)
                {
                    rainDrop.Y = -rainDrop.Size;
                    rainDrop.X = random.Next(0, ClientSize.Width);
                }
            }

            
            Invalidate(); 
        }
    }
}
