namespace ReadTXT2
{
    partial class AboutThis
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label_up = new System.Windows.Forms.Label();
            this.label_down = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(484, 362);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 471;
            this.lineShape1.Y1 = 76;
            this.lineShape1.Y2 = 76;
            // 
            // label_up
            // 
            this.label_up.AutoSize = true;
            this.label_up.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_up.Location = new System.Drawing.Point(109, 98);
            this.label_up.Name = "label_up";
            this.label_up.Size = new System.Drawing.Size(54, 20);
            this.label_up.TabIndex = 1;
            this.label_up.Text = "label1";
            // 
            // label_down
            // 
            this.label_down.AutoSize = true;
            this.label_down.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_down.Location = new System.Drawing.Point(109, 224);
            this.label_down.Name = "label_down";
            this.label_down.Size = new System.Drawing.Size(45, 20);
            this.label_down.TabIndex = 2;
            this.label_down.Text = "label";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(397, 327);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "確定";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReadTXT2.Properties.Resources.Samitare;
            this.pictureBox1.Location = new System.Drawing.Point(18, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AboutThis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label_down);
            this.Controls.Add(this.label_up);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AboutThis";
            this.Text = "About This";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label_up;
        private System.Windows.Forms.Label label_down;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}