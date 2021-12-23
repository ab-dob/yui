using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПрогаСло
{
    public partial class Form1 : Form
    {
        readonly int w = Screen.PrimaryScreen.Bounds.Width;
        readonly int h = Screen.PrimaryScreen.Bounds.Height;
        readonly int ws = Screen.PrimaryScreen.WorkingArea.Width;
        readonly int hs = Screen.PrimaryScreen.WorkingArea.Height;

        Size size = SystemInformation.PrimaryMonitorSize;
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\ПрогаСло.cur");
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
            textBox2.Text = Screen.PrimaryScreen.WorkingArea.Width.ToString() + "X" + Screen.PrimaryScreen.WorkingArea.Height.ToString();
            textBox3.Text = "Отсутствует";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LeftDown_Click(object sender, EventArgs e)
        {
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height);
            textBox3.Text = "Слева снизу";
        }

        private void RightTop_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width, 0);
            textBox3.Text = "Справо сверху";
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            Left = ws / 2 - Width / 2;
            Top = hs / 2 - Height / 2;
            textBox3.Text = "По центру";
        }

        private void LeftTop_Click(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            textBox3.Text = "Слева сверху";
        }

        private void RightDown_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            textBox3.Text = "Справо снизу";
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (Location.X < 0)
            {
                Location = new Point(0, Location.Y);
            }
            if (Location.Y < 0)
            {
                Location = new Point(Location.X, 0);
            }
            if (Location.X + Size.Width > size.Width)
            {
                Location = new Point(size.Width - Size.Width, Location.Y);
            }
            if (Location.Y + Size.Height > size.Height)
            {
                Location = new Point(Location.X, size.Height - Size.Height);
            }
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void Recover_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void RollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void Standart_Click(object sender, EventArgs e)
        {
            Width = 800;
            Height = 480;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void SizeF_Click(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 600;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void SizeS_Click(object sender, EventArgs e)
        {
            Width = 750;
            Height = 400;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Width = Width + 10;
            Height = Height + 10;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Width = Width - 10;
            Height = Height - 10;
            textBox1.Text = Width.ToString() + "X" + Height.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
