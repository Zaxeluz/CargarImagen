using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Rene_Llega_Tarde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    Image<Bgr, byte> imgInpute = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = imgInpute.Bitmap;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void slirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
