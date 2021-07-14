namespace ReadTXT2
{
    partial class Read_TXT
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Read_TXT));
            this.richTextBox_Text = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_Convert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.t2SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FileNewCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_FileSaveNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Recovery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Past = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_FindTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_MoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_DateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AutoNextLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ColorFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ColorBackGround = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToSimplifiedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToTraditionalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_State = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutNotePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Botton = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip_Convert.SuspendLayout();
            this.menuStrip_Top.SuspendLayout();
            this.statusStrip_Botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Text
            // 
            this.richTextBox_Text.BackColor = System.Drawing.Color.Black;
            this.richTextBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Text.ContextMenuStrip = this.contextMenuStrip_Convert;
            this.richTextBox_Text.DetectUrls = false;
            this.richTextBox_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Text.EnableAutoDragDrop = true;
            this.richTextBox_Text.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox_Text.Location = new System.Drawing.Point(0, 24);
            this.richTextBox_Text.MaxLength = 0;
            this.richTextBox_Text.Name = "richTextBox_Text";
            this.richTextBox_Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_Text.Size = new System.Drawing.Size(663, 653);
            this.richTextBox_Text.TabIndex = 0;
            this.richTextBox_Text.Text = "";
            this.richTextBox_Text.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            this.richTextBox_Text.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragEnter);
            this.richTextBox_Text.TextChanged += new System.EventHandler(this.CatchCursorPosition);
            this.richTextBox_Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CatchCursorPosition_MouseEvent);
            // 
            // contextMenuStrip_Convert
            // 
            this.contextMenuStrip_Convert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t2SToolStripMenuItem,
            this.s2TToolStripMenuItem,
            this.changeColorToolStripMenuItem});
            this.contextMenuStrip_Convert.Name = "contextMenuStrip_Convert";
            this.contextMenuStrip_Convert.ShowImageMargin = false;
            this.contextMenuStrip_Convert.Size = new System.Drawing.Size(128, 92);
            // 
            // t2SToolStripMenuItem
            // 
            this.t2SToolStripMenuItem.Name = "t2SToolStripMenuItem";
            this.t2SToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.t2SToolStripMenuItem.Text = "T2S";
            this.t2SToolStripMenuItem.Click += new System.EventHandler(this.t2SToolStripMenuItem_Click);
            // 
            // s2TToolStripMenuItem
            // 
            this.s2TToolStripMenuItem.Name = "s2TToolStripMenuItem";
            this.s2TToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.s2TToolStripMenuItem.Text = "S2T";
            this.s2TToolStripMenuItem.Click += new System.EventHandler(this.s2TToolStripMenuItem_Click);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.changeColorToolStripMenuItem.Text = "ChangeColor";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // menuStrip_Top
            // 
            this.menuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Option,
            this.ToolStripMenuItem_View,
            this.ToolStripMenuItem_Help});
            this.menuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Top.Name = "menuStrip_Top";
            this.menuStrip_Top.Size = new System.Drawing.Size(663, 24);
            this.menuStrip_Top.TabIndex = 1;
            this.menuStrip_Top.Text = "menuStrip_Top";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_FileNewCreate,
            this.ToolStripMenuItem_FileOpen,
            this.ToolStripMenuItem_FileSave,
            this.toolStripMenuItem_FileSaveNew,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(58, 20);
            this.ToolStripMenuItem_File.Text = "檔案(F)";
            // 
            // ToolStripMenuItem_FileNewCreate
            // 
            this.ToolStripMenuItem_FileNewCreate.Name = "ToolStripMenuItem_FileNewCreate";
            this.ToolStripMenuItem_FileNewCreate.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_FileNewCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItem_FileNewCreate.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItem_FileNewCreate.Text = "開新檔案(N)";
            this.ToolStripMenuItem_FileNewCreate.Click += new System.EventHandler(this.ToolStripMenuItem_FileNewCreate_Click);
            // 
            // ToolStripMenuItem_FileOpen
            // 
            this.ToolStripMenuItem_FileOpen.Name = "ToolStripMenuItem_FileOpen";
            this.ToolStripMenuItem_FileOpen.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem_FileOpen.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItem_FileOpen.Text = "開啟舊檔(O)...";
            this.ToolStripMenuItem_FileOpen.Click += new System.EventHandler(this.ToolStripMenuItem_FileOpen_Click);
            // 
            // ToolStripMenuItem_FileSave
            // 
            this.ToolStripMenuItem_FileSave.Name = "ToolStripMenuItem_FileSave";
            this.ToolStripMenuItem_FileSave.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItem_FileSave.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItem_FileSave.Text = "儲存檔案(S)";
            this.ToolStripMenuItem_FileSave.Click += new System.EventHandler(this.ToolStripMenuItem_FileSave_Click);
            // 
            // toolStripMenuItem_FileSaveNew
            // 
            this.toolStripMenuItem_FileSaveNew.Name = "toolStripMenuItem_FileSaveNew";
            this.toolStripMenuItem_FileSaveNew.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem_FileSaveNew.Text = "另存新檔(A)...";
            this.toolStripMenuItem_FileSaveNew.Click += new System.EventHandler(this.toolStripMenuItem_FileSaveNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItem_Exit.Text = "結束(X)";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Recovery,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_Cut,
            this.ToolStripMenuItem_Copy,
            this.ToolStripMenuItem_Past,
            this.ToolStripMenuItem_Delete,
            this.toolStripSeparator3,
            this.ToolStripMenuItem_FindTarget,
            this.ToolStripMenuItem_FindNext,
            this.ToolStripMenuItem_Replace,
            this.ToolStripMenuItem_MoveTo,
            this.toolStripSeparator4,
            this.ToolStripMenuItem_SelectAll,
            this.ToolStripMenuItem_DateTime});
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(59, 20);
            this.ToolStripMenuItem_Edit.Text = "編輯(E)";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // ToolStripMenuItem_Recovery
            // 
            this.ToolStripMenuItem_Recovery.Enabled = false;
            this.ToolStripMenuItem_Recovery.Name = "ToolStripMenuItem_Recovery";
            this.ToolStripMenuItem_Recovery.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Recovery.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItem_Recovery.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Recovery.Text = "復原(Z)";
            this.ToolStripMenuItem_Recovery.Click += new System.EventHandler(this.ToolStripMenuItem_Recovery_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // ToolStripMenuItem_Cut
            // 
            this.ToolStripMenuItem_Cut.Name = "ToolStripMenuItem_Cut";
            this.ToolStripMenuItem_Cut.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItem_Cut.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Cut.Text = "剪下(T)";
            this.ToolStripMenuItem_Cut.Click += new System.EventHandler(this.ToolStripMenuItem_Cut_Click);
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Copy.Text = "複製(C)";
            this.ToolStripMenuItem_Copy.Click += new System.EventHandler(this.ToolStripMenuItem_Copy_Click);
            // 
            // ToolStripMenuItem_Past
            // 
            this.ToolStripMenuItem_Past.Name = "ToolStripMenuItem_Past";
            this.ToolStripMenuItem_Past.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Past.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem_Past.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Past.Text = "貼上(P)";
            this.ToolStripMenuItem_Past.Click += new System.EventHandler(this.ToolStripMenuItem_Past_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Delete.Text = "刪除(L)";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // ToolStripMenuItem_FindTarget
            // 
            this.ToolStripMenuItem_FindTarget.Name = "ToolStripMenuItem_FindTarget";
            this.ToolStripMenuItem_FindTarget.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_FindTarget.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ToolStripMenuItem_FindTarget.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_FindTarget.Text = "尋找(F)...";
            this.ToolStripMenuItem_FindTarget.Click += new System.EventHandler(this.ToolStripMenuItem_FindTarget_Click);
            // 
            // ToolStripMenuItem_FindNext
            // 
            this.ToolStripMenuItem_FindNext.Name = "ToolStripMenuItem_FindNext";
            this.ToolStripMenuItem_FindNext.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_FindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ToolStripMenuItem_FindNext.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_FindNext.Text = "找下一個(N)";
            this.ToolStripMenuItem_FindNext.Click += new System.EventHandler(this.ToolStripMenuItem_FindNext_Click);
            // 
            // ToolStripMenuItem_Replace
            // 
            this.ToolStripMenuItem_Replace.Name = "ToolStripMenuItem_Replace";
            this.ToolStripMenuItem_Replace.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ToolStripMenuItem_Replace.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_Replace.Text = "取代(R)...";
            this.ToolStripMenuItem_Replace.Click += new System.EventHandler(this.ToolStripMenuItem_Replace_Click);
            // 
            // ToolStripMenuItem_MoveTo
            // 
            this.ToolStripMenuItem_MoveTo.Name = "ToolStripMenuItem_MoveTo";
            this.ToolStripMenuItem_MoveTo.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_MoveTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.ToolStripMenuItem_MoveTo.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_MoveTo.Text = "移至(G)...";
            this.ToolStripMenuItem_MoveTo.Click += new System.EventHandler(this.ToolStripMenuItem_MoveTo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(168, 6);
            // 
            // ToolStripMenuItem_SelectAll
            // 
            this.ToolStripMenuItem_SelectAll.Name = "ToolStripMenuItem_SelectAll";
            this.ToolStripMenuItem_SelectAll.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItem_SelectAll.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_SelectAll.Text = "全選(A)";
            this.ToolStripMenuItem_SelectAll.Click += new System.EventHandler(this.ToolStripMenuItem_SelectAll_Click);
            // 
            // ToolStripMenuItem_DateTime
            // 
            this.ToolStripMenuItem_DateTime.Name = "ToolStripMenuItem_DateTime";
            this.ToolStripMenuItem_DateTime.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItem_DateTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ToolStripMenuItem_DateTime.Size = new System.Drawing.Size(171, 22);
            this.ToolStripMenuItem_DateTime.Text = "時間/日期(D)";
            this.ToolStripMenuItem_DateTime.Click += new System.EventHandler(this.ToolStripMenuItem_DateTime_Click);
            // 
            // ToolStripMenuItem_Option
            // 
            this.ToolStripMenuItem_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AutoNextLine,
            this.ToolStripMenuItem_Font,
            this.ToolStripMenuItem_Color,
            this.toolStripSeparator5,
            this.ToSimplifiedToolStripMenuItem1,
            this.ToTraditionalToolStripMenuItem1});
            this.ToolStripMenuItem_Option.Name = "ToolStripMenuItem_Option";
            this.ToolStripMenuItem_Option.Size = new System.Drawing.Size(62, 20);
            this.ToolStripMenuItem_Option.Text = "格式(O)";
            // 
            // ToolStripMenuItem_AutoNextLine
            // 
            this.ToolStripMenuItem_AutoNextLine.Checked = true;
            this.ToolStripMenuItem_AutoNextLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_AutoNextLine.Name = "ToolStripMenuItem_AutoNextLine";
            this.ToolStripMenuItem_AutoNextLine.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_AutoNextLine.Text = "自動換行(W)";
            this.ToolStripMenuItem_AutoNextLine.Click += new System.EventHandler(this.ToolStripMenuItem_AutoNextLine_Click);
            // 
            // ToolStripMenuItem_Font
            // 
            this.ToolStripMenuItem_Font.Name = "ToolStripMenuItem_Font";
            this.ToolStripMenuItem_Font.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_Font.Text = "字型(F)...";
            this.ToolStripMenuItem_Font.Click += new System.EventHandler(this.ToolStripMenuItem_Font_Click);
            // 
            // ToolStripMenuItem_Color
            // 
            this.ToolStripMenuItem_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ColorFont,
            this.ToolStripMenuItem_ColorBackGround});
            this.ToolStripMenuItem_Color.Name = "ToolStripMenuItem_Color";
            this.ToolStripMenuItem_Color.Size = new System.Drawing.Size(144, 22);
            this.ToolStripMenuItem_Color.Text = "色彩(C)";
            // 
            // ToolStripMenuItem_ColorFont
            // 
            this.ToolStripMenuItem_ColorFont.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripMenuItem_ColorFont.Name = "ToolStripMenuItem_ColorFont";
            this.ToolStripMenuItem_ColorFont.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_ColorFont.Text = "前景";
            this.ToolStripMenuItem_ColorFont.Click += new System.EventHandler(this.ToolStripMenuItem_ColorFont_Click);
            // 
            // ToolStripMenuItem_ColorBackGround
            // 
            this.ToolStripMenuItem_ColorBackGround.Name = "ToolStripMenuItem_ColorBackGround";
            this.ToolStripMenuItem_ColorBackGround.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_ColorBackGround.Text = "背景";
            this.ToolStripMenuItem_ColorBackGround.Click += new System.EventHandler(this.ToolStripMenuItem_ColorBackGround_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(141, 6);
            // 
            // ToSimplifiedToolStripMenuItem1
            // 
            this.ToSimplifiedToolStripMenuItem1.Name = "ToSimplifiedToolStripMenuItem1";
            this.ToSimplifiedToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.ToSimplifiedToolStripMenuItem1.Text = "繁->簡";
            this.ToSimplifiedToolStripMenuItem1.Click += new System.EventHandler(this.ToSimplifiedToolStripMenuItem1_Click);
            // 
            // ToTraditionalToolStripMenuItem1
            // 
            this.ToTraditionalToolStripMenuItem1.Name = "ToTraditionalToolStripMenuItem1";
            this.ToTraditionalToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.ToTraditionalToolStripMenuItem1.Text = "簡->繁";
            this.ToTraditionalToolStripMenuItem1.Click += new System.EventHandler(this.ToTraditionalToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem_View
            // 
            this.ToolStripMenuItem_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_State});
            this.ToolStripMenuItem_View.Name = "ToolStripMenuItem_View";
            this.ToolStripMenuItem_View.Size = new System.Drawing.Size(60, 20);
            this.ToolStripMenuItem_View.Text = "檢視(V)";
            // 
            // toolStripMenuItem_State
            // 
            this.toolStripMenuItem_State.Name = "toolStripMenuItem_State";
            this.toolStripMenuItem_State.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem_State.Text = "狀態列(S)";
            this.toolStripMenuItem_State.Click += new System.EventHandler(this.toolStripMenuItem_State_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckHelpToolStripMenuItem,
            this.toolStripSeparator6,
            this.AboutNotePadToolStripMenuItem});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItem_Help.Text = "說明(H)";
            // 
            // CheckHelpToolStripMenuItem
            // 
            this.CheckHelpToolStripMenuItem.Enabled = false;
            this.CheckHelpToolStripMenuItem.Name = "CheckHelpToolStripMenuItem";
            this.CheckHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CheckHelpToolStripMenuItem.Text = "檢視說明(H)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // AboutNotePadToolStripMenuItem
            // 
            this.AboutNotePadToolStripMenuItem.Name = "AboutNotePadToolStripMenuItem";
            this.AboutNotePadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutNotePadToolStripMenuItem.Text = "關於筆記本(A)";
            this.AboutNotePadToolStripMenuItem.Click += new System.EventHandler(this.AboutNotePadToolStripMenuItem_Click);
            // 
            // statusStrip_Botton
            // 
            this.statusStrip_Botton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip_Botton.Location = new System.Drawing.Point(0, 655);
            this.statusStrip_Botton.Name = "statusStrip_Botton";
            this.statusStrip_Botton.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip_Botton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip_Botton.Size = new System.Drawing.Size(663, 22);
            this.statusStrip_Botton.SizingGrip = false;
            this.statusStrip_Botton.TabIndex = 2;
            this.statusStrip_Botton.Text = "statusStrip_Btn";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "right";
            // 
            // Read_TXT
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(663, 677);
            this.ContextMenuStrip = this.contextMenuStrip_Convert;
            this.Controls.Add(this.statusStrip_Botton);
            this.Controls.Add(this.richTextBox_Text);
            this.Controls.Add(this.menuStrip_Top);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip_Top;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Read_TXT";
            this.Text = "Read TXT";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.File_DragEnter);
            this.contextMenuStrip_Convert.ResumeLayout(false);
            this.menuStrip_Top.ResumeLayout(false);
            this.menuStrip_Top.PerformLayout();
            this.statusStrip_Botton.ResumeLayout(false);
            this.statusStrip_Botton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Text;
        private System.Windows.Forms.MenuStrip menuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FileNewCreate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FileOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Option;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Font;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Color;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ColorFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ColorBackGround;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FileSaveNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Recovery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Past;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FindTarget;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FindNext;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Replace;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_MoveTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_DateTime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AutoNextLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_State;
        private System.Windows.Forms.ToolStripMenuItem CheckHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutNotePadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip_Botton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ToSimplifiedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToTraditionalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem t2SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s2TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Convert;
    }
}

