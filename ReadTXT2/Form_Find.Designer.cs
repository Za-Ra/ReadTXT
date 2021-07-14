namespace ReadTXT2
{
    partial class Form_Find
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
            this.label_FindTarget = new System.Windows.Forms.Label();
            this.textBox_FindTarget = new System.Windows.Forms.TextBox();
            this.button_FindNext = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_UpperDifferent = new System.Windows.Forms.CheckBox();
            this.groupBox_FindDirection = new System.Windows.Forms.GroupBox();
            this.radioButton_Up = new System.Windows.Forms.RadioButton();
            this.radioButton_Down = new System.Windows.Forms.RadioButton();
            this.groupBox_FindDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FindTarget
            // 
            this.label_FindTarget.AutoSize = true;
            this.label_FindTarget.Location = new System.Drawing.Point(12, 9);
            this.label_FindTarget.Name = "label_FindTarget";
            this.label_FindTarget.Size = new System.Drawing.Size(95, 24);
            this.label_FindTarget.TabIndex = 0;
            this.label_FindTarget.Text = "尋找目標 :";
            // 
            // textBox_FindTarget
            // 
            this.textBox_FindTarget.Location = new System.Drawing.Point(139, 6);
            this.textBox_FindTarget.Name = "textBox_FindTarget";
            this.textBox_FindTarget.Size = new System.Drawing.Size(270, 33);
            this.textBox_FindTarget.TabIndex = 1;
            this.textBox_FindTarget.TextChanged += new System.EventHandler(this.When_TextBox_Word_Change);
            // 
            // button_FindNext
            // 
            this.button_FindNext.Location = new System.Drawing.Point(415, 6);
            this.button_FindNext.Name = "button_FindNext";
            this.button_FindNext.Size = new System.Drawing.Size(113, 32);
            this.button_FindNext.TabIndex = 2;
            this.button_FindNext.Text = "找下一個";
            this.button_FindNext.UseVisualStyleBackColor = true;
            this.button_FindNext.TextChanged += new System.EventHandler(this.When_TextBox_Word_Change);
            this.button_FindNext.Click += new System.EventHandler(this.button_FindNext_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(415, 45);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(113, 31);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox_UpperDifferent
            // 
            this.checkBox_UpperDifferent.AutoSize = true;
            this.checkBox_UpperDifferent.Location = new System.Drawing.Point(12, 69);
            this.checkBox_UpperDifferent.Name = "checkBox_UpperDifferent";
            this.checkBox_UpperDifferent.Size = new System.Drawing.Size(162, 28);
            this.checkBox_UpperDifferent.TabIndex = 4;
            this.checkBox_UpperDifferent.Text = "大小寫視為相異";
            this.checkBox_UpperDifferent.UseVisualStyleBackColor = true;
            // 
            // groupBox_FindDirection
            // 
            this.groupBox_FindDirection.Controls.Add(this.radioButton_Down);
            this.groupBox_FindDirection.Controls.Add(this.radioButton_Up);
            this.groupBox_FindDirection.Location = new System.Drawing.Point(184, 45);
            this.groupBox_FindDirection.Name = "groupBox_FindDirection";
            this.groupBox_FindDirection.Size = new System.Drawing.Size(225, 58);
            this.groupBox_FindDirection.TabIndex = 5;
            this.groupBox_FindDirection.TabStop = false;
            this.groupBox_FindDirection.Text = "搜尋方向";
            // 
            // radioButton_Up
            // 
            this.radioButton_Up.AutoSize = true;
            this.radioButton_Up.Location = new System.Drawing.Point(6, 24);
            this.radioButton_Up.Name = "radioButton_Up";
            this.radioButton_Up.Size = new System.Drawing.Size(66, 28);
            this.radioButton_Up.TabIndex = 0;
            this.radioButton_Up.Text = "向上";
            this.radioButton_Up.UseVisualStyleBackColor = true;
            // 
            // radioButton_Down
            // 
            this.radioButton_Down.AutoSize = true;
            this.radioButton_Down.Checked = true;
            this.radioButton_Down.Location = new System.Drawing.Point(122, 23);
            this.radioButton_Down.Name = "radioButton_Down";
            this.radioButton_Down.Size = new System.Drawing.Size(66, 28);
            this.radioButton_Down.TabIndex = 1;
            this.radioButton_Down.TabStop = true;
            this.radioButton_Down.Text = "向下";
            this.radioButton_Down.UseVisualStyleBackColor = true;
            // 
            // Form_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 115);
            this.Controls.Add(this.groupBox_FindDirection);
            this.Controls.Add(this.checkBox_UpperDifferent);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_FindNext);
            this.Controls.Add(this.textBox_FindTarget);
            this.Controls.Add(this.label_FindTarget);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_Find";
            this.Text = "尋找";
            this.groupBox_FindDirection.ResumeLayout(false);
            this.groupBox_FindDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FindTarget;
        private System.Windows.Forms.TextBox textBox_FindTarget;
        private System.Windows.Forms.Button button_FindNext;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox_UpperDifferent;
        private System.Windows.Forms.GroupBox groupBox_FindDirection;
        private System.Windows.Forms.RadioButton radioButton_Down;
        private System.Windows.Forms.RadioButton radioButton_Up;
    }
}