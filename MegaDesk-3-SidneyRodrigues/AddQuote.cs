using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_SidneyRodrigues
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
      

        }

        public void checkFields()
        {
            if ( this.textDepth.Text != "" && this.textWidth.Text != "")
            {
                this.btnSave.Enabled = true;
            }
        }

    

        private void textWidth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textWidth.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a min width of 24 or max of 96 inches" );
                    textWidth.Text = String.Empty;
                    textWidth.BackColor = Color.Red;
                    textWidth.Focus();
                }
                else
                {
                    textWidth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(textWidth.Text, out WidthInput) == false && textWidth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                textWidth.Text = String.Empty;
                textWidth.BackColor = Color.Red;
                textWidth.Focus();
            }
            else
            {
                textWidth.BackColor = System.Drawing.SystemColors.Window;
            }
        }



        private void textDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                textDepth.BackColor = Color.Red;
                textDepth.Focus();
            }
            else
            {
                textDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void textDepth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textDepth.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a min depth of 12 or a max of 48 inches");
                    textDepth.Text = String.Empty;
                    textDepth.BackColor = Color.Red;
                    textDepth.Focus();
                }
            }
            else
            {
                textDepth.BackColor = System.Drawing.SystemColors.Window;
            }

        }

        private void textDepth_Validated(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
 
           
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void textWidth_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }

        private void textDepth_TextChanged(object sender, EventArgs e)
        {
            checkFields();
        }
    }
}
