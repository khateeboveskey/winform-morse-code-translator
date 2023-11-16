using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeTranslator
{
    public partial class frmGuide : Form
    {
        public Point mouseLocation;
        public static frmHistory instance;
        public frmGuide(String englishText, String morseText)
        {
            InitializeComponent();
            if (englishText.Length > 0)
            {
                lblEnglishText.Text = englishText;
                lblMorseText.Text = morseText;
            }
          


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            
        }


        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void frmGuide_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

