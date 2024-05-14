﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            hTile1.Tag = MdiLayout.TileHorizontal;
            vTile1.Tag = MdiLayout.TileVertical;
            cascade1.Tag = MdiLayout.Cascade;
            arrangeIcons1.Tag = MdiLayout.ArrangeIcons;
        }

        internal void open1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            Form2 f = new Form2();
            string n = openFileDialog1.FileName;
            Image i = Image.FromFile(n);
            f.pictureBox1.Image = i;
            f.Text = string.Format("{0} ({1}x{2})",
            System.IO.Path.GetFileNameWithoutExtension(n), i.Width, i.Height);
            f.MdiParent = this;
            window1.Visible = true;
            close2.Enabled = resize2.Enabled = stretch2.Enabled = true;
            f.Show();
            }

        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hTile1_Click(object sender, EventArgs e)
        {
            LayoutMdi((MdiLayout)(sender as ToolStripMenuItem).Tag);
        }

        private void close2_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void resize2_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as Form2).resize1_Click(this, null);
        }

        private void stretch2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ActiveMdiChild as Form2).stretch1;
            mi.Checked = !mi.Checked;
        }
    }
}
