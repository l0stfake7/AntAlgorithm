namespace AntsAlgorithm
{
    partial class MainForm
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
            this.labelDebug = new System.Windows.Forms.Label();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonAnt = new System.Windows.Forms.RadioButton();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.labelDebug2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(12, 443);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(61, 13);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "labelDebug";
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Checked = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(12, 36);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(48, 17);
            this.radioButtonPoint.TabIndex = 1;
            this.radioButtonPoint.TabStop = true;
            this.radioButtonPoint.Text = "point";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(67, 13);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(41, 17);
            this.radioButtonLine.TabIndex = 2;
            this.radioButtonLine.Text = "line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonAnt
            // 
            this.radioButtonAnt.AutoSize = true;
            this.radioButtonAnt.Location = new System.Drawing.Point(67, 36);
            this.radioButtonAnt.Name = "radioButtonAnt";
            this.radioButtonAnt.Size = new System.Drawing.Size(40, 17);
            this.radioButtonAnt.TabIndex = 3;
            this.radioButtonAnt.TabStop = true;
            this.radioButtonAnt.Text = "ant";
            this.radioButtonAnt.UseVisualStyleBackColor = true;
            this.radioButtonAnt.CheckedChanged += new System.EventHandler(this.radioButtonAnt_CheckedChanged);
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(12, 13);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(53, 17);
            this.radioButtonSelect.TabIndex = 4;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.Text = "select";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            this.radioButtonSelect.CheckedChanged += new System.EventHandler(this.radioButtonSelect_CheckedChanged);
            // 
            // labelDebug2
            // 
            this.labelDebug2.AutoSize = true;
            this.labelDebug2.Location = new System.Drawing.Point(248, 442);
            this.labelDebug2.Name = "labelDebug2";
            this.labelDebug2.Size = new System.Drawing.Size(67, 13);
            this.labelDebug2.TabIndex = 5;
            this.labelDebug2.Text = "labelDebug2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 465);
            this.Controls.Add(this.labelDebug2);
            this.Controls.Add(this.radioButtonSelect);
            this.Controls.Add(this.radioButtonAnt);
            this.Controls.Add(this.radioButtonLine);
            this.Controls.Add(this.radioButtonPoint);
            this.Controls.Add(this.labelDebug);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonAnt;
        private System.Windows.Forms.RadioButton radioButtonSelect;
        private System.Windows.Forms.Label labelDebug2;
    }
}

