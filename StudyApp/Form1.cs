using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyApp
{
    public partial class Form1 : Form
    {
        int xMouse;
        int yMouse;
        int ToMove;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            xMouse = e.X;
            yMouse = e.Y;
            ToMove = 1;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ToMove = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ToMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - xMouse, MousePosition.Y - yMouse);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.panel1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
