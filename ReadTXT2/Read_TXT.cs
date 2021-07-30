using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Documents; //// in PresentationFramework & PresentationCore & WindowsBase & SystemXaml
//using System.Windows.Documents.TextPointer; //// in PresentationFramework
using System.Drawing.Printing;
using ReadTXT2;

namespace ReadTXT2
{
    public partial class Read_TXT : Form
    {
        /// <summary>
        /// 使用系統 kernel32.dll 進行轉換
        /// </summary>

        private const int LocaleSystemDefault = 0x0800;
        private const int LcmapSimplifiedChinese = 0x02000000;
        private const int LcmapTraditionalChinese = 0x04000000;

        /// <summary>
        /// 使用OS的kernel.dll做為簡繁轉換工具。
        /// <para>只要有裝OS就可以使用，不用額外引用dll，但只能做逐字轉換，無法進行詞意的轉換</para>
        /// <para>所以無法將電腦轉成計算機</para>
        /// </summary>
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LCMapString(int locale, int dwMapFlags, string lpSrcStr, int cchSrc,
                                              [Out] string lpDestStr, int cchDest);
        /// <summary>
        /// Import end
        /// </summary>


        public static TextBox targetText ;
        public static Read_TXT ReadTxtFindWord;

        public Menu TopMenu;

        public Read_TXT()
        {
            
            ReadTxtFindWord = this;
            InitializeComponent();
            if (!this.toolStripMenuItem_State.Enabled)
            {
                this.statusStrip_Botton.Visible = false;
            }
            this.statusStrip_Botton.Visible = toolStripMenuItem_State.Checked;
            TopMenu = new ReadTXT2.Menu(richTextBox_Text);

            ///// This step make Drag Drop will not crate a icon on text inside !!!!
            richTextBox_Text.EnableAutoDragDrop = false;
            richTextBox_Text.AllowDrop = true;
            richTextBox_Text.DragDrop += File_DragDrop;
            
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            // 確定使用者抓進來的是檔案
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                // 允許拖拉動作繼續 (這時滑鼠游標應該會顯示 +)
                e.Effect = DragDropEffects.All;
            }
        }

        private void File_DragDrop(object sender, DragEventArgs e)
        {
            this.richTextBox_Text.Text = "";
            string line;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //string[] fileName = files[0].Split('\\');

            this.Text = files[0];

            StreamReader StreamReaderFile_EncodingStyle = new StreamReader(files[0], true);

            StreamReader StreamReaderFile =
                new StreamReader(files[0], StreamReaderFile_EncodingStyle.CurrentEncoding);

            RichTextBox TextTempBox = new RichTextBox();
            while ((line = StreamReaderFile.ReadLine()) != null)
            {
                TextTempBox.Text += line + "\r\n";
            }

            StreamReaderFile.Close();
            this.richTextBox_Text.Text = TextTempBox.Text;
        }

        /// <summary>
        /// TraditionalChinese Converter Tool Code;
        /// </summary>
        /// <param name="argSource"></param>
        /// <returns></returns>
        public static string ToSimplified(string argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapSimplifiedChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }

        public static string ToTraditional(string argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapTraditionalChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }

        /// <summary>
        /// Analize Cursor position
        /// </summary>
        /// 
        private void CatchCursorPosition(object sender, EventArgs e)
        {
            int RichTextBox_Column, RichTextBox_Row;

            RichTextBox_Row = 1 + this.richTextBox_Text.GetLineFromCharIndex(this.richTextBox_Text.SelectionStart);
            RichTextBox_Column = 1 + this.richTextBox_Text.SelectionStart
                - (this.richTextBox_Text.GetFirstCharIndexFromLine(this.richTextBox_Text.GetLineFromCharIndex(this.richTextBox_Text.SelectionStart)));

            toolStripStatusLabel1.Text = "Row " + RichTextBox_Row + " , Column " + RichTextBox_Column;
        }

        private void CatchCursorPosition_MouseEvent(object sender, MouseEventArgs e)
        {
            CatchCursorPosition(sender, e);
        }


        /// <summary>
        /// Catch Select String
        /// </summary>
        /// 
        private string SelectedStringFromRichTextBox(System.Windows.Controls.RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            return textRange.Text;
        }

        private void writeMsg(RichTextBox rtb, string msg1, Color color1 = new Color())
        {

            rtb.SelectionColor = Color.Red;
            rtb.AppendText(msg1);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItem_Function_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;

            switch(TSMI.Name)
            {
                case "ToolStripMenuItem_FileNewCreate":
                    this.Text = "Read TXT";
                    this.richTextBox_Text.Text = "";
                    break;

                case "ToolStripMenuItem_FileOpen":
                    string getFileName = "";
                    RichTextBox RTB = TopMenu.M_File.File_Open(ref getFileName);
                    if (RTB != null)
                    {
                        this.richTextBox_Text.Text = RTB.Text;
                        this.Text = getFileName;
                    }
                    break;

                case "ToolStripMenuItem_FileSave":
                    this.Text = TopMenu.M_File.Save_File(this.Text, this.richTextBox_Text);
                    break;

                case "toolStripMenuItem_FileSaveNew":
                    this.Text = TopMenu.M_File.Save_New_File(this.Text, this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_Exit":
                    this.Close();
                    break;
            }


        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItem_Edit_Function_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;

            switch (TSMI.Name)
            {
                #region Normal Function
                case "ToolStripMenuItem_Recovery":
                case "ToolStripMenuItem_Mouse_R_Recover":
                    this.richTextBox_Text = TopMenu.M_Edit.Recovery(this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_Cut":
                case "ToolStripMenuItem_Mouse_R_Cut":
                    this.richTextBox_Text = TopMenu.M_Edit.Cut(this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_Copy":
                case "ToolStripMenuItem_Mouse_R_Copy":
                    this.richTextBox_Text = TopMenu.M_Edit.Copy(this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_Past":
                case "ToolStripMenuItem_Mouse_R_Past":
                    this.richTextBox_Text = TopMenu.M_Edit.Past(this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_Delete":
                    this.richTextBox_Text = TopMenu.M_Edit.Delete(this.richTextBox_Text);
                    break;

                case "ToolStripMenuItem_SelectAll":
                case "ToolStripMenuItem_Mouse_R_SelectAll":
                    this.richTextBox_Text.SelectAll();
                    break;
                #endregion


                #region Find Target Window


                #endregion



                case "ToolStripMenuItem_DateTime":
                    this.richTextBox_Text = TopMenu.M_Edit.Show_DateTime(this.richTextBox_Text);
                    break;


            }



        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItem_FindTarget_Click(object sender, EventArgs e)
        {
            SearchDialog();
        }

        private void ToolStripMenuItem_FindNext_Click(object sender, EventArgs e)
        {

        }
        private void ToolStripMenuItem_Replace_Click(object sender, EventArgs e)
        {
            
        }
        private void ToolStripMenuItem_MoveTo_Click(object sender, EventArgs e)
        {

        }
        private void SearchDialog()
        {
            Form_Find FindWord = new Form_Find();
            FindWord.Show();
        }
        private void HighlightString(string stringToHighlight)
        {
            // Code here to search your text and highlight a string.
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        private void ToolStripMenuItem_Option_Function_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;

            switch (TSMI.Name)
            {

                case "ToolStripMenuItem_Font":
                    this.Font = TopMenu.M_Option.FontChange(this.Font);
                    break;

                case "ToolStripMenuItem_ColorFont":
                    this.richTextBox_Text.ForeColor = TopMenu.M_Option.ColorChange(this.richTextBox_Text.ForeColor);
                    break;
                case "ToolStripMenuItem_ColorBackGround":
                    this.richTextBox_Text.BackColor = TopMenu.M_Option.ColorChange(this.richTextBox_Text.BackColor);
                    break;


            }
        }



        private void ToolStripMenuItem_AutoNextLine_Click(object sender, EventArgs e)
        {
            this.richTextBox_Text.WordWrap = !this.richTextBox_Text.WordWrap;
            ToolStripMenuItem_AutoNextLine.Checked = this.richTextBox_Text.WordWrap;

            this.toolStripMenuItem_State.Enabled = !this.richTextBox_Text.WordWrap;

            if (!this.toolStripMenuItem_State.Enabled)
            {
                this.statusStrip_Botton.Visible = false;
            }
            this.statusStrip_Botton.Visible = toolStripMenuItem_State.Checked;
        }



        private void ToSimplifiedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox_Text.Text = ToSimplified(richTextBox_Text.Text);
        }

        private void ToTraditionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox_Text.Text = ToTraditional(richTextBox_Text.Text);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem_State_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_State.Checked = !toolStripMenuItem_State.Checked;
            this.statusStrip_Botton.Visible = toolStripMenuItem_State.Checked;

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void AboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutThis aboutthis = new AboutThis();
            aboutthis.Show();
        }




        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void t2SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Text.Text =  ToSimplified(richTextBox_Text.Text);
        }

        private void s2TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Text.Text = ToTraditional(richTextBox_Text.Text);
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string selectMsg = SelectedStringFromRichTextBox(this.richTextBox_Text);

            System.Windows.Forms.RichTextBox a = new RichTextBox();
            System.Windows.Controls.RichTextBox b = new System.Windows.Controls.RichTextBox();
            //TextBoxBase c;
            //c = a;
            //b = c;

            //b.Document;
            

            

        }





        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int RecordFindIndex;
        public static void FindTargetWordFunction()
        {
            ReadTxtFindWord.RecordFindIndex = ReadTxtFindWord.FindMyText(targetText.Text, ReadTxtFindWord.RecordFindIndex, ReadTxtFindWord.richTextBox_Text.TextLength);
            ReadTxtFindWord.Focus();
        }

        public int FindMyText(string searchText, int searchStart, int searchEnd)
        {
            // Initialize the return value to false by default.
            int returnValue = -1;

            // Ensure that a search string and a valid starting point are specified.
            if (searchText.Length > 0 && searchStart >= 0)
            {
                // Ensure that a valid ending value is provided.
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Obtain the location of the search string in richTextBox1.
                    int indexToText = ReadTxtFindWord.richTextBox_Text.Find(searchText, searchStart, searchEnd, RichTextBoxFinds.MatchCase);
                    // Determine whether the text was found in richTextBox1.
                    if (indexToText >= 0)
                    {
                        // Return the index to the specified search text.
                        returnValue = indexToText;
                    }
                }
            }

            return returnValue;
        }



    }
}
