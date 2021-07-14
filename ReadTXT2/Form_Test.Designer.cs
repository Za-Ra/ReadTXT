namespace ReadTXT2
{
    partial class Form_Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FrontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BackGroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(537, 432);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip_Top
            // 
            this.menuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Option});
            this.menuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Top.Name = "menuStrip_Top";
            this.menuStrip_Top.Size = new System.Drawing.Size(537, 24);
            this.menuStrip_Top.TabIndex = 1;
            this.menuStrip_Top.Text = "menuStrip_Top";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_SaveFile,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem_File.Text = "檔案";
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_OpenFile.Text = "開新檔案";
            // 
            // ToolStripMenuItem_SaveFile
            // 
            this.ToolStripMenuItem_SaveFile.Name = "ToolStripMenuItem_SaveFile";
            this.ToolStripMenuItem_SaveFile.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_SaveFile.Text = "儲存檔案";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Exit.Text = "結束";
            // 
            // ToolStripMenuItem_Option
            // 
            this.ToolStripMenuItem_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Font,
            this.ToolStripMenuItem_Color});
            this.ToolStripMenuItem_Option.Name = "ToolStripMenuItem_Option";
            this.ToolStripMenuItem_Option.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem_Option.Text = "格式";
            // 
            // ToolStripMenuItem_Font
            // 
            this.ToolStripMenuItem_Font.Name = "ToolStripMenuItem_Font";
            this.ToolStripMenuItem_Font.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Font.Text = "字型";
            this.ToolStripMenuItem_Font.Click += new System.EventHandler(this.ToolStripMenuItem_Font_Click);
            // 
            // ToolStripMenuItem_Color
            // 
            this.ToolStripMenuItem_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_FrontColor,
            this.ToolStripMenuItem_BackGroundColor});
            this.ToolStripMenuItem_Color.Name = "ToolStripMenuItem_Color";
            this.ToolStripMenuItem_Color.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Color.Text = "色彩";
            // 
            // ToolStripMenuItem_FrontColor
            // 
            this.ToolStripMenuItem_FrontColor.Name = "ToolStripMenuItem_FrontColor";
            this.ToolStripMenuItem_FrontColor.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_FrontColor.Text = "前景";
            this.ToolStripMenuItem_FrontColor.Click += new System.EventHandler(this.ToolStripMenuItem_FrontColor_Click);
            // 
            // ToolStripMenuItem_BackGroundColor
            // 
            this.ToolStripMenuItem_BackGroundColor.Name = "ToolStripMenuItem_BackGroundColor";
            this.ToolStripMenuItem_BackGroundColor.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_BackGroundColor.Text = "背景";
            this.ToolStripMenuItem_BackGroundColor.Click += new System.EventHandler(this.ToolStripMenuItem_BackGroundColor_Click);
            // 
            // Form_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip_Top);
            this.MainMenuStrip = this.menuStrip_Top;
            this.Name = "Form_Test";
            this.Text = "Form_Test";
            this.menuStrip_Top.ResumeLayout(false);
            this.menuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Option;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Font;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Color;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FrontColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BackGroundColor;
    }
}