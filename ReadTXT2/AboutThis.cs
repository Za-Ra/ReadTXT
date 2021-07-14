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
    public partial class AboutThis : Form
    {
        public AboutThis()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            CallText();

        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CallText()
        {
            this.label_up.Text = "這隻程式是仿照 Windows 的筆記本做出來的東西，\n" + 
                "只是方便我看文章而已，\n因為筆記本要改顏色不方便。\n\n" + 
                "會陸陸續續把它改的根筆記本差不多的樣子。\n";
            
            
            this.label_down.Text = "這東西不怎麼重要，也不會吃你電腦資源。\n請安心服用。";
        }
    }
}
