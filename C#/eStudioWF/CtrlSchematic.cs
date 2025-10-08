using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eStudioWF
{
    public partial class CtrlSchematic : UserControl
    {
        public CtrlSchematic() 
        {
            InitializeComponent();
        }

        private void CtrlSchematic_Paint(object sender, PaintEventArgs e) 
        {
            Control control = (Control)sender;
            Rectangle clientRect = control.ClientRectangle;

            Graphics g = e.Graphics;

            // int gridSize = 12; // smallest w/ line being 2 width
            int gridSize = 15; 

            this.DrawBackGroundGrid(g, clientRect, gridSize);

            // 1, 6, 11, 16
            using (Pen pen = new Pen(Color.Black, 1))
            {
                this.DrawNOTGate(g, pen, gridSize, 4, 1);
                this.DrawInverterGate(g, pen, gridSize, 4, 6);

                this.DrawANDGate(g, pen, gridSize, 4, 11);
                this.DrawNANDGate(g, pen, gridSize, 4, 16);

                this.DrawORGate(g, pen, gridSize, 4, 21);
                this.DrawNORGate(g, pen, gridSize, 4, 26);

                this.DrawChip(g, pen, gridSize, 15, 3, 40, 14);
                this.DrawChip(g, pen, gridSize, 40, 3, 20, 10);
                this.DrawChip(g, pen, gridSize, 41, 25, 16, 8);
            }
        }

        private void DrawBackGroundGrid(Graphics g, Rectangle rect, int gridSize) 
        {
            using (Pen gridPen = new Pen(Color.LightGray))
            {
                for (int x = 0; x < rect.Width; x += gridSize)
                    g.DrawLine(gridPen, x, 0, x, rect.Height);

                for (int y = 0; y < rect.Height; y += gridSize)
                    g.DrawLine(gridPen, 0, y, rect.Width, y);
            }
        }

        private void DrawNOTGate(Graphics g, Pen pen, int gridSize, int x, int y) 
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx, gy + (4 * gridSize));
            g.DrawLine(pen, gx, gy, gx + (4 * gridSize), gy + (2 * gridSize));

            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (4 * gridSize), gy + (2 * gridSize));

            g.DrawLine(pen, gx - (2 * gridSize), gy + (2 * gridSize), gx, gy + (2 * gridSize));
            g.DrawLine(pen, gx + (4 * gridSize), gy + (2 * gridSize), gx + (6 * gridSize), gy + (2 * gridSize));
        }
        private void DrawInverterGate(Graphics g, Pen pen, int gridSize, int x, int y)
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx, gy + (4 * gridSize));
            g.DrawLine(pen, gx, gy, gx + (4 * gridSize), gy + (2 * gridSize));

            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (4 * gridSize), gy + (2 * gridSize));

            g.DrawLine(pen, gx - (2 * gridSize), gy + (2 * gridSize), gx, gy + (2 * gridSize));

            this.DrawCircle(g, pen, gx + (4 * gridSize) + (gridSize / 4), gy + (2 * gridSize), gridSize / 4);

            g.DrawLine(pen, gx + (4 * gridSize) + (gridSize / 2), gy + (2 * gridSize), gx + (6 * gridSize), gy + (2 * gridSize));
        }

        private void DrawANDGate(Graphics g, Pen pen, int gridSize, int x, int y)
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx + (3 * gridSize), gy);
            g.DrawLine(pen, gx, gy, gx, gy + (4 * gridSize));
            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (3 * gridSize), gy + (4 * gridSize));

            g.DrawArc(pen, gx + (1 * gridSize) - 1, gy, 4 * gridSize, 4 * gridSize, 270, 180);

            g.DrawLine(pen, gx - (2 * gridSize), gy + (1 * gridSize), gx, gy + (1 * gridSize));
            g.DrawLine(pen, gx - (2 * gridSize), gy + (3 * gridSize), gx, gy + (3 * gridSize));

            g.DrawLine(pen, gx + (5 * gridSize), gy + (2 * gridSize), gx + (7 * gridSize), gy + (2 * gridSize));
        }
        private void DrawNANDGate(Graphics g, Pen pen, int gridSize, int x, int y)
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx + (3 * gridSize), gy);
            g.DrawLine(pen, gx, gy, gx, gy + (4 * gridSize));
            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (3 * gridSize), gy + (4 * gridSize));

            g.DrawArc(pen, gx + (1 * gridSize) - 1, gy, 4 * gridSize, 4 * gridSize, 270, 180);

            g.DrawLine(pen, gx - (2 * gridSize), gy + (1 * gridSize), gx, gy + (1 * gridSize));
            g.DrawLine(pen, gx - (2 * gridSize), gy + (3 * gridSize), gx, gy + (3 * gridSize));

            this.DrawCircle(g, pen, gx + (5 * gridSize) + (gridSize / 4), gy + (2 * gridSize), gridSize / 4);

            g.DrawLine(pen, gx + (5 * gridSize) + (gridSize / 2), gy + (2 * gridSize), gx + (7 * gridSize), gy + (2 * gridSize));
        }

        private void DrawORGate(Graphics g, Pen pen, int gridSize, int x, int y) 
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx + (2 * gridSize), gy);
            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (2 * gridSize), gy + (4 * gridSize));

            g.DrawArc(pen, gx - (1 * gridSize), gy, 2 * gridSize, 4 * gridSize, 270, 180);

            g.DrawArc(pen, gx - (2 * gridSize) - 1, gy, 8 * gridSize, 8 * gridSize, 270, 60);
            g.DrawArc(pen, gx - (2 * gridSize) - 1, gy - (4 * gridSize), 8 * gridSize, 8 * gridSize, 30, 60);

            g.DrawLine(pen, gx - (2 * gridSize), gy + (1 * gridSize), gx + (1 * gridSize), gy + (1 * gridSize));
            g.DrawLine(pen, gx - (2 * gridSize), gy + (3 * gridSize), gx + (1 * gridSize), gy + (3 * gridSize));

            double dgx = (gx + (6 * gridSize)) - ((gridSize / 5) * 3);
            g.DrawLine(pen, (int)dgx, gy + (2 * gridSize), gx + (7 * gridSize), gy + (2 * gridSize));
        }
        private void DrawNORGate(Graphics g, Pen pen, int gridSize, int x, int y) 
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            g.DrawLine(pen, gx, gy, gx + (2 * gridSize), gy);
            g.DrawLine(pen, gx, gy + (4 * gridSize), gx + (2 * gridSize), gy + (4 * gridSize));

            g.DrawArc(pen, gx - (1 * gridSize), gy, 2 * gridSize, 4 * gridSize, 270, 180);

            g.DrawArc(pen, gx - (2 * gridSize) - 1, gy, 8 * gridSize, 8 * gridSize, 270, 60);
            g.DrawArc(pen, gx - (2 * gridSize) - 1, gy - (4 * gridSize), 8 * gridSize, 8 * gridSize, 30, 60);

            g.DrawLine(pen, gx - (2 * gridSize), gy + (1 * gridSize), gx + (1 * gridSize), gy + (1 * gridSize));
            g.DrawLine(pen, gx - (2 * gridSize), gy + (3 * gridSize), gx + (1 * gridSize), gy + (3 * gridSize));

            double dgx = (gx + (6 * gridSize)) - ((gridSize / 5) * 3);

            this.DrawCircle(g, pen, (int)dgx + (gridSize / 4), gy + (2 * gridSize), gridSize / 4);

            dgx += (gridSize / 2);

            g.DrawLine(pen, (int)dgx, gy + (2 * gridSize), gx + (7 * gridSize), gy + (2 * gridSize));
        }

        private void DrawChip(Graphics g, Pen pen, int gridSize, int x, int y, int pins, int width)
        {
            int gx = x * gridSize;
            int gy = y * gridSize;

            int hpy = gy + (pins * gridSize);
            int chip_width = width * gridSize;

            g.DrawLine(pen, gx, gy, gx + chip_width, gy);
            g.DrawLine(pen, gx, gy, gx, hpy);
            g.DrawLine(pen, gx + chip_width, gy, gx + chip_width, hpy);
            g.DrawLine(pen, gx, hpy, gx + chip_width, hpy);

            for (int pin = 0; pin < pins; pin += 2)
            {
                g.DrawLine(pen, gx - gridSize, gy + (pin * gridSize) + (gridSize / 2), gx, gy + (pin * gridSize) + (gridSize / 2));
                g.DrawLine(pen, gx - gridSize, gy + (pin * gridSize) + (gridSize / 2) + gridSize, gx, gy + (pin * gridSize) + (gridSize / 2) + gridSize);
                g.DrawLine(pen, gx - gridSize, gy + (pin * gridSize) + (gridSize / 2), gx - gridSize, gy + (pin * gridSize) + (gridSize / 2) + gridSize);

                g.DrawLine(pen, gx + chip_width, gy + (pin * gridSize) + (gridSize / 2), gx + chip_width + gridSize, gy + (pin * gridSize) + (gridSize / 2));
                g.DrawLine(pen, gx + chip_width, gy + (pin * gridSize) + (gridSize / 2) + gridSize, gx + chip_width + gridSize, gy + (pin * gridSize) + (gridSize / 2) + gridSize);
                g.DrawLine(pen, gx + chip_width + gridSize, gy + (pin * gridSize) + (gridSize / 2), gx + chip_width + gridSize, gy + (pin * gridSize) + (gridSize / 2) + gridSize);
            }
        }

        public void DrawCircle(Graphics g, Pen pen, float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}
