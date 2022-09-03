using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //Show the Open File dialog.If the user clicks OK,
            //load the picture that the user chose. 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Load(openFileDialog.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture.
            PictureBox.Image = null;
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            //Show the color dialog box.
            //If the user clicks OK,change the PictureBox control's background
            //to the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox.BackColor = colorDialog1.Color;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void StrechCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //If the user selects the Strech check box,
            //change the PictureBox's SizeMode property to "Stretch".
            //If the user clears the check box,change it to "Normal".
            if (StrechCheckBox.Checked)
            {
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                PictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
