using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTXT2
{
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();


            DialogResult result = fontDialog1.ShowDialog();
            //See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                //this.textBox1.Text = string.Format("Font: {0}", font.Name);
                this.textBox1.Font = font;
            }
        }

        private void ToolStripMenuItem_BackGroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
                this.textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void ToolStripMenuItem_FrontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.BackColor = colorDialog1.Color;
                this.textBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
