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
    public partial class Form_Find : Form
    {
        public Form_Find()
        {
            InitializeComponent();
            button_FindNext.Enabled = false;
        }

        private void When_TextBox_Word_Change(object sender, EventArgs e)
        {
            if (textBox_FindTarget.TextLength == 0)
            {
                button_FindNext.Enabled = false;
            }
            else
            {
                button_FindNext.Enabled = true;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Read_TXT.ReadTxtFindWord.RecordFindIndex = 0;
        }


        

        private void button_FindNext_Click(object sender, EventArgs e)
        {
            Read_TXT.targetText = textBox_FindTarget;
            Read_TXT.FindTargetWordFunction();
            
        }




    }
}
