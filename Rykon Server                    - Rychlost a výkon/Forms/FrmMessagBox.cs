using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykonServer.Forms
{
    public partial class FrmMessagBox : Form
    {
        public FrmMessagBox(string title , string msg , string imagepath="")
        {
            InitializeComponent();
            this.Text = title;
            this.richTextBox1.Text = msg;
            if (System.IO.File.Exists(imagepath))
                LoadImage(imagepath);
        }

        private void LoadImage(string imagepath)
        {

            try
            {
                this.pictureBox1.Image = Image.FromFile(imagepath);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }
        }

        private void FrmMessagBox_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
