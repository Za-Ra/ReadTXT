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


namespace ReadTXT2
{
    public partial class Read_TXT : Form
    {
        ///
        /// 使用系統 kernel32.dll 進行轉換
        ///
        private const int LocaleSystemDefault = 0x0800;
        private const int LcmapSimplifiedChinese = 0x02000000;
        private const int LcmapTraditionalChinese = 0x04000000;

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LCMapString(int locale, int dwMapFlags, string lpSrcStr, int cchSrc,
                                              [Out] string lpDestStr, int cchDest);
        /// <summary>
        ///  Import end
        /// </summary>


        public static TextBox targetText ;
        public static Read_TXT ReadTxtFindWord;

        public Read_TXT()
        {
            ReadTxtFindWord = this;
            InitializeComponent();
            //this.KeyDown += new KeyEventHandler(Form_KeyDown);
            if (!this.toolStripMenuItem_State.Enabled)
            {
                this.statusStrip_Botton.Visible = false;
            }
            this.statusStrip_Botton.Visible = toolStripMenuItem_State.Checked;
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

            System.IO.StreamReader StreamReaderFile =
                new System.IO.StreamReader(files[0], System.Text.Encoding.Default);

            RichTextBox TextTempBox = new RichTextBox();
            while ((line = StreamReaderFile.ReadLine()) != null)
            {
                TextTempBox.Text += line + "\r\n";
            }

            StreamReaderFile.Close();
            this.richTextBox_Text.Text = TextTempBox.Text;
        }

        // Hot keys handler
        //void Form_KeyDown(object sender, KeyEventArgs e)
        //{
        //    ToolStripMenuItem_Recovery.Enabled = true;
        //    switch (e.KeyCode)
        //    {
        //        case Keys.F5:
        //            ToolStripMenuItem_DateTime_Click(sender, e);
        //            break;
        //        case Keys.F3:
        //            ToolStripMenuItem_FindNext_Click(sender, e);
        //            break;
        //        case Keys.Delete:
        //            ToolStripMenuItem_Delete_Click(sender, e);
        //            break;
        //        default:
        //            break;
        //    }
        //    //if (e.Control)
        //    //{
        //    //    switch (e.KeyCode)
        //    //    {
        //    //        case Keys.N:
        //    //            ToolStripMenuItem_FileNewCreate_Click(sender, e);
        //    //            break;
        //    //        case Keys.O:
        //    //            ToolStripMenuItem_FileOpen_Click(sender, e);
        //    //            break;
        //    //        case Keys.S:
        //    //            ToolStripMenuItem_FileSave_Click(sender, e);
        //    //            break;
        //    //        //case Keys.Z:
        //    //        //    ToolStripMenuItem_Recovery_Click(sender, e);
        //    //        //    break;
        //    //        //case Keys.X:
        //    //        //    ToolStripMenuItem_Cut_Click(sender, e);
        //    //        //    break;
        //    //        //case Keys.C:
        //    //        //    ToolStripMenuItem_Copy_Click(sender, e);
        //    //        //    break;

        //    //        //case Keys.V:
        //    //        //    ToolStripMenuItem_Past_Click(sender, e);
        //    //        //    break;
                    
        //    //        //case Keys.A:
        //    //        //    ToolStripMenuItem_SelectAll_Click(sender, e);
        //    //        //    break;

        //    //        //case Keys.F:
        //    //        //    ToolStripMenuItem_FindTarget_Click(sender, e);
        //    //        //    break;

        //    //        //case Keys.H:
        //    //        //    ToolStripMenuItem_Replace_Click(sender, e);
        //    //        //    break;

        //    //        default:
        //    //            break;

        //    //    }

        //    //}

        //}

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

        private void ToolStripMenuItem_FileNewCreate_Click(object sender, EventArgs e)
        {
            this.Text = "Read TXT";
            this.richTextBox_Text.Text = "";
        }

        private void ToolStripMenuItem_FileOpen_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            //openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            //DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;
                this.richTextBox_Text.Text = "";
                // Open the selected file to read.
                //System.IO.Stream fileStream = openFileDialog1.File.OpenRead();
                System.IO.Stream fileStream = openFileDialog.OpenFile();
                System.IO.StreamReader reader = new System.IO.StreamReader(fileStream, System.Text.Encoding.Default);
                string line;
                RichTextBox TextTempBox = new RichTextBox();
                while ((line = reader.ReadLine()) != null)
                {
                    TextTempBox.Text += line + "\r\n";
                }

                fileStream.Close();
                this.richTextBox_Text.Text = TextTempBox.Text;

            }
        }

        private void ToolStripMenuItem_FileSave_Click(object sender, EventArgs e)
        {
            if (this.Text == "Read TXT")
            {
                toolStripMenuItem_FileSaveNew_Click(sender, e);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                Stream myStream;
                saveFileDialog.FileName = this.Text;
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    byte[] tmp = Encoding.Default.GetBytes(richTextBox_Text.Text);
                    myStream.Write(tmp, 0, tmp.Length);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

        }

        private void toolStripMenuItem_FileSaveNew_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = saveFileDialog.FileName;
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    byte[] tmp = Encoding.Default.GetBytes(richTextBox_Text.Text);
                    myStream.Write(tmp, 0, tmp.Length);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {

        }



        private void ToolStripMenuItem_Recovery_Click(object sender, EventArgs e)
        {
            // Determine if last operation can be undone in text box.   
            if (richTextBox_Text.CanUndo == true)
            {
                // Undo the last operation.
                richTextBox_Text.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                richTextBox_Text.ClearUndo();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void ToolStripMenuItem_Cut_Click(object sender, EventArgs e)
        {
            //// Windows Already Have These Function!!

            //// Ensure that text is currently selected in the text box.   
            if (richTextBox_Text.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                richTextBox_Text.Cut();

        }

        private void ToolStripMenuItem_Copy_Click(object sender, EventArgs e)
        {
            //// Windows Already Have These Function!!

            //// Ensure that text is selected in the text box.   
            if (richTextBox_Text.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                richTextBox_Text.Copy();
        }

        private void ToolStripMenuItem_Past_Click(object sender, EventArgs e)
        {
            //// Windows Already Have These Function!!

            //// Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (richTextBox_Text.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    //if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        richTextBox_Text.SelectionStart = richTextBox_Text.SelectionStart + richTextBox_Text.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                richTextBox_Text.Paste();
            }
        }

        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {

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

        private void ToolStripMenuItem_SelectAll_Click(object sender, EventArgs e)
        {
            this.richTextBox_Text.SelectAll();
        }

        private void ToolStripMenuItem_DateTime_Click(object sender, EventArgs e)
        {
            this.richTextBox_Text.Text = DateTime.Now.ToString() ;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
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

        private void ToolStripMenuItem_Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            DialogResult result = fontDialog.ShowDialog();
            //See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog.Font;
                this.richTextBox_Text.Font = font;
            }
        }

        ColorDialog colorDialog = new ColorDialog();
        private void ToolStripMenuItem_ColorFont_Click(object sender, EventArgs e)
        {
            //ColorDialog colorDialog1 = new ColorDialog();
            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.richTextBox_Text.ForeColor = colorDialog.Color;
            }



        }

        private void ToolStripMenuItem_ColorBackGround_Click(object sender, EventArgs e)
        {
            //ColorDialog colorDialog = new ColorDialog();
            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                this.richTextBox_Text.BackColor = colorDialog.Color;
            }
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
