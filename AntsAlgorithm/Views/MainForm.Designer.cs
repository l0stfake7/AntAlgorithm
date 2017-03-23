﻿namespace AntsAlgorithm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxDebug = new System.Windows.Forms.GroupBox();
            this.labelDebug2 = new System.Windows.Forms.Label();
            this.labelDebug1 = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxSelectMode = new System.Windows.Forms.GroupBox();
            this.radioButtonAnt = new System.Windows.Forms.RadioButton();
            this.radioButtonPath = new System.Windows.Forms.RadioButton();
            this.radioButtonNode = new System.Windows.Forms.RadioButton();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.Editor = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.countLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxDebug.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxSelectMode.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Main);
            this.MainTabControl.Controls.Add(this.Editor);
            this.MainTabControl.Controls.Add(this.Settings);
            this.MainTabControl.Location = new System.Drawing.Point(13, 13);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(709, 360);
            this.MainTabControl.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.pictureBox);
            this.Main.Controls.Add(this.groupBoxDebug);
            this.Main.Controls.Add(this.groupBoxActions);
            this.Main.Controls.Add(this.groupBoxSelectMode);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(701, 334);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox.Location = new System.Drawing.Point(7, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(503, 321);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // groupBoxDebug
            // 
            this.groupBoxDebug.Controls.Add(this.countLabel);
            this.groupBoxDebug.Controls.Add(this.labelDebug2);
            this.groupBoxDebug.Controls.Add(this.labelDebug1);
            this.groupBoxDebug.Location = new System.Drawing.Point(516, 231);
            this.groupBoxDebug.Name = "groupBoxDebug";
            this.groupBoxDebug.Size = new System.Drawing.Size(179, 97);
            this.groupBoxDebug.TabIndex = 2;
            this.groupBoxDebug.TabStop = false;
            this.groupBoxDebug.Text = "groupBox3";
            // 
            // labelDebug2
            // 
            this.labelDebug2.AutoSize = true;
            this.labelDebug2.Location = new System.Drawing.Point(7, 44);
            this.labelDebug2.Name = "labelDebug2";
            this.labelDebug2.Size = new System.Drawing.Size(43, 13);
            this.labelDebug2.TabIndex = 1;
            this.labelDebug2.Text = "111111";
            // 
            // labelDebug1
            // 
            this.labelDebug1.AutoSize = true;
            this.labelDebug1.Location = new System.Drawing.Point(7, 20);
            this.labelDebug1.Name = "labelDebug1";
            this.labelDebug1.Size = new System.Drawing.Size(43, 13);
            this.labelDebug1.TabIndex = 0;
            this.labelDebug1.Text = "111111";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonReset);
            this.groupBoxActions.Controls.Add(this.buttonStop);
            this.groupBoxActions.Controls.Add(this.buttonStart);
            this.groupBoxActions.Location = new System.Drawing.Point(516, 113);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(179, 112);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "groupBox2";
            // 
            // groupBoxSelectMode
            // 
            this.groupBoxSelectMode.Controls.Add(this.radioButtonAnt);
            this.groupBoxSelectMode.Controls.Add(this.radioButtonPath);
            this.groupBoxSelectMode.Controls.Add(this.radioButtonNode);
            this.groupBoxSelectMode.Controls.Add(this.radioButtonSelect);
            this.groupBoxSelectMode.Location = new System.Drawing.Point(516, 6);
            this.groupBoxSelectMode.Name = "groupBoxSelectMode";
            this.groupBoxSelectMode.Size = new System.Drawing.Size(179, 100);
            this.groupBoxSelectMode.TabIndex = 0;
            this.groupBoxSelectMode.TabStop = false;
            this.groupBoxSelectMode.Text = "Select mode";
            // 
            // radioButtonAnt
            // 
            this.radioButtonAnt.AutoSize = true;
            this.radioButtonAnt.Location = new System.Drawing.Point(94, 43);
            this.radioButtonAnt.Name = "radioButtonAnt";
            this.radioButtonAnt.Size = new System.Drawing.Size(41, 17);
            this.radioButtonAnt.TabIndex = 3;
            this.radioButtonAnt.Text = "Ant";
            this.radioButtonAnt.UseVisualStyleBackColor = true;
            this.radioButtonAnt.CheckedChanged += new System.EventHandler(this.radioButtonAnt_CheckedChanged);
            // 
            // radioButtonPath
            // 
            this.radioButtonPath.AutoSize = true;
            this.radioButtonPath.Location = new System.Drawing.Point(6, 43);
            this.radioButtonPath.Name = "radioButtonPath";
            this.radioButtonPath.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPath.TabIndex = 2;
            this.radioButtonPath.Text = "Path";
            this.radioButtonPath.UseVisualStyleBackColor = true;
            this.radioButtonPath.CheckedChanged += new System.EventHandler(this.radioButtonPath_CheckedChanged);
            // 
            // radioButtonNode
            // 
            this.radioButtonNode.AutoSize = true;
            this.radioButtonNode.Location = new System.Drawing.Point(94, 20);
            this.radioButtonNode.Name = "radioButtonNode";
            this.radioButtonNode.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNode.TabIndex = 1;
            this.radioButtonNode.Text = "Node";
            this.radioButtonNode.UseVisualStyleBackColor = true;
            this.radioButtonNode.CheckedChanged += new System.EventHandler(this.radioButtonNode_CheckedChanged);
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Checked = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSelect.TabIndex = 0;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.Text = "Select";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            this.radioButtonSelect.CheckedChanged += new System.EventHandler(this.radioButtonSelect_CheckedChanged);
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(701, 360);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(701, 360);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(7, 68);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(60, 13);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "countLabel";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(7, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(74, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(98, 20);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(7, 49);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(74, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "AntsAlgorithm";
            this.MainTabControl.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxDebug.ResumeLayout(false);
            this.groupBoxDebug.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxSelectMode.ResumeLayout(false);
            this.groupBoxSelectMode.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Editor;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.GroupBox groupBoxDebug;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxSelectMode;
        private System.Windows.Forms.RadioButton radioButtonAnt;
        private System.Windows.Forms.RadioButton radioButtonPath;
        private System.Windows.Forms.RadioButton radioButtonNode;
        private System.Windows.Forms.RadioButton radioButtonSelect;
        private System.Windows.Forms.Label labelDebug2;
        private System.Windows.Forms.Label labelDebug1;
        private System.Windows.Forms.Label countLabel;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}
