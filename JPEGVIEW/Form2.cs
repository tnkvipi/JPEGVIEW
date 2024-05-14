using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPEGVIEW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void open1_Click(object sender, EventArgs e)
        {
            (MdiParent as Form1).open1_Click(this, null);
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit1_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = MdiParent as Form1;
            if (f.MdiChildren.Length == 1)
                f.window1.Visible = f.close2.Enabled = f.resize2.Enabled =
                f.stretch2.Enabled = f.stretch2.Checked = false;
        }

        private void closeAll1_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiParent.MdiChildren)
                f.Close();
        }

        private void stretch1_CheckedChanged(object sender, EventArgs e)
        {
            (MdiParent as Form1).stretch2.Checked = stretch1.Checked;
            if (stretch1.Checked)
            {
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        internal void resize1_Click(object sender, EventArgs e)
        {
            Size sz = ClientSize;
            if (stretch1.Checked)
            {
                int iw = pictureBox1.Image.Width,
                ih = pictureBox1.Image.Height,
                cw = ClientSize.Width,
                ch = ClientSize.Height;
                double x = cw / (double)iw,
                y = ch / (double)ih;
                if (x < y)
                    sz.Height = (int)(x * ih);
                else
                    sz.Width = (int)(y * iw);
            }
            else
                sz = pictureBox1.Size;
            ClientSize = sz;
        }

        private void resizeAll1_Click(object sender, EventArgs e)
        {
            MdiParent.LayoutMdi(MdiLayout.Cascade);
            foreach (Form2 f in MdiParent.MdiChildren)
                f.resize1_Click(f, null);

        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            (MdiParent as Form1).stretch2.Checked = stretch1.Checked;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers != Keys.Control)
                
            return;
            Point p = AutoScrollPosition;
            Size s = pictureBox1.Size;
            p.X = -p.X;
            p.Y = -p.Y;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    p -= new Size(0, 10); break;
                case Keys.Down:
                    p += new Size(0, 10); break;
                case Keys.Left:
                    p -= new Size(10, 0); break;
                case Keys.Right:
                    p += new Size(10, 0); break;
                case Keys.Home:
                    p = Point.Empty; break;
                case Keys.PageDown:
                    p = new Point(s); break;
                case Keys.End:
                    p = new Point(0, s.Height); break;
                case Keys.PageUp:
                    p = new Point(s.Width, 0); break;
            }
            AutoScrollPosition = p;
        }
    }
}
