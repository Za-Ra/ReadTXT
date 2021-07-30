using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTXT2
{
    public class Menu
    {

        public Menu_File M_File;
        public Menu_Edit M_Edit;
        public Menu_Option M_Option;
        public Menu_View M_View;
        public Menu_Help M_Help;

        public RichTextBox MR_TextBox;

        public Menu(RichTextBox parent_RichTextBox)
        {
            M_File = new Menu_File();
            M_Edit = new Menu_Edit();
            M_Option = new Menu_Option();
            M_View = new Menu_View();
            M_Help = new Menu_Help();
            MR_TextBox = parent_RichTextBox;
        }


    }


    public class Menu_File
    {
        public void New_Create()
        {
            // Skip....
        }

        public RichTextBox File_Open(ref string openFileName)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            //openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            // DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileName = openFileDialog.FileName;
                // Open the selected file to read.
                // System.IO.Stream fileStream = openFileDialog1.File.OpenRead();
                Stream fileStream = openFileDialog.OpenFile();
                StreamReader Get_Encode_Format = new StreamReader(fileStream, true);
                StreamReader reader = new StreamReader(fileStream, Get_Encode_Format.CurrentEncoding);

                string line;
                RichTextBox TextTempBox = new RichTextBox();
                while ((line = reader.ReadLine()) != null)
                {
                    TextTempBox.Text += line + "\r\n";
                }

                fileStream.Close();
                //this.richTextBox_Text.Text = TextTempBox.Text;
                return TextTempBox;
            }
            return null;
        }

        public string Save_New_File(string text_Title, RichTextBox Save_Rich_TextBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter swriter = new StreamWriter(saveFileDialog.FileName);
                swriter.WriteLine(Save_Rich_TextBox.Text);
                swriter.Close();
                return saveFileDialog.FileName;
            }
            return text_Title;

            ////// Old Solution , this will make Encode style problem
            //this.Text = saveFileDialog.FileName;
            //if ((myStream = saveFileDialog.OpenFile()) != null)
            //{
            //    byte[] tmp = Encoding.Default.GetBytes(Save_Rich_TextBox.Text);
            //    myStream.Write(tmp, 0, tmp.Length);
            //    Code to write the stream goes here.
            //   myStream.Close();
            //}
        }

        public string Save_File(string text_Title, RichTextBox Save_Rich_TextBox)
        {
            string Title_Name = text_Title;
            if (Title_Name == "Read TXT")
            {
                Title_Name = Save_New_File(text_Title, Save_Rich_TextBox);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = text_Title;
                StreamWriter swriter = new StreamWriter(saveFileDialog.FileName);
                swriter.WriteLine(Save_Rich_TextBox.Text);
                swriter.Close();
                //Stream myStream;
                //if ((myStream = saveFileDialog.OpenFile()) != null)
                //{
                //    byte[] tmp = Encoding.Default.GetBytes(Save_Rich_TextBox.Text);
                //    myStream.Write(tmp, 0, tmp.Length);
                //    // Code to write the stream goes here.
                //    myStream.Close();
                //}

            }
            return Title_Name;
        }

    }

    public class Menu_Edit
    {
        public RichTextBox Recovery(RichTextBox RTB)
        {
            // Determine if last operation can be undone in text box.   
            if (RTB.CanUndo == true)
            {
                // Undo the last operation.
                RTB.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                RTB.ClearUndo();
            }
            return RTB;
        }

        public RichTextBox Cut(RichTextBox RTB)
        {
            //// Windows Already Have These Function!!

            //// Ensure that text is currently selected in the text box.   
            if (RTB.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                RTB.Cut();

            return RTB;
        }

        public RichTextBox Copy(RichTextBox RTB)
        {
            //// Windows Already Have These Function!!

            //// Ensure that text is selected in the text box.   
            if (RTB.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                RTB.Copy();

            return RTB;
        }

        public RichTextBox Past(RichTextBox RTB)
        {
            //// Windows Already Have These Function!!

            //// Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (RTB.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    //if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                    // Move selection to the point after the current selection and paste.
                    RTB.SelectionStart = RTB.SelectionStart + RTB.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                RTB.Paste();
            }
            return RTB;
        }

        public RichTextBox Delete(RichTextBox RTB)
        {
            RTB.SelectedText = "";
            return RTB;
        }


        public RichTextBox Show_DateTime(RichTextBox RTB)
        {
            RTB.SelectedText = DateTime.Now.ToString();
            return RTB;
        }

    }

    public class Menu_Option
    {


        public Font FontChange(Font P_Font)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = P_Font;

            DialogResult result = fontDialog.ShowDialog();
            //See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                P_Font = fontDialog.Font;
            }
            return P_Font;
        }

        public Color ColorChange(Color Original_Color)
        {
            Color Choosed_Color = Original_Color;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = Original_Color;
            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                Choosed_Color = colorDialog.Color;
            }
            return Choosed_Color;
        }

    }


    public class Menu_View
    {

    }

    public class Menu_Help
    {

    }






}
