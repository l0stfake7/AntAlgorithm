namespace AntsAlgorithm.Views
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("test1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("test2");
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxDebug = new System.Windows.Forms.GroupBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.labelDebug2 = new System.Windows.Forms.Label();
            this.labelDebug1 = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxSelectMode = new System.Windows.Forms.GroupBox();
            this.radioButtonAnt = new System.Windows.Forms.RadioButton();
            this.radioButtonPath = new System.Windows.Forms.RadioButton();
            this.radioButtonNode = new System.Windows.Forms.RadioButton();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.Editor = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.groupBoxVisualisation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.groupBoxTheme = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSettingsLanguage = new System.Windows.Forms.GroupBox();
            this.radioButtonDeutch = new System.Windows.Forms.RadioButton();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonPolish = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialogTheme = new System.Windows.Forms.ColorDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MainTabControl.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxDebug.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxSelectMode.SuspendLayout();
            this.Settings.SuspendLayout();
            this.groupBoxVisualisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxTheme.SuspendLayout();
            this.groupBoxSettingsLanguage.SuspendLayout();
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
            this.groupBoxDebug.Text = "Debug Info";
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
            this.groupBoxActions.Controls.Add(this.buttonSave);
            this.groupBoxActions.Controls.Add(this.buttonReset);
            this.groupBoxActions.Controls.Add(this.buttonStop);
            this.groupBoxActions.Controls.Add(this.buttonStart);
            this.groupBoxActions.Location = new System.Drawing.Point(516, 113);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(179, 112);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(98, 48);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            // groupBoxSelectMode
            // 
            this.groupBoxSelectMode.Controls.Add(this.listView1);
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
            this.Editor.Size = new System.Drawing.Size(701, 334);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.groupBoxVisualisation);
            this.Settings.Controls.Add(this.groupBoxTheme);
            this.Settings.Controls.Add(this.groupBoxSettingsLanguage);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(701, 334);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // groupBoxVisualisation
            // 
            this.groupBoxVisualisation.Controls.Add(this.label2);
            this.groupBoxVisualisation.Controls.Add(this.trackBarSpeed);
            this.groupBoxVisualisation.Location = new System.Drawing.Point(214, 7);
            this.groupBoxVisualisation.Name = "groupBoxVisualisation";
            this.groupBoxVisualisation.Size = new System.Drawing.Size(200, 100);
            this.groupBoxVisualisation.TabIndex = 2;
            this.groupBoxVisualisation.TabStop = false;
            this.groupBoxVisualisation.Text = "Visualisation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 44);
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(188, 45);
            this.trackBarSpeed.TabIndex = 1;
            this.trackBarSpeed.Value = 5;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // groupBoxTheme
            // 
            this.groupBoxTheme.Controls.Add(this.button1);
            this.groupBoxTheme.Controls.Add(this.label1);
            this.groupBoxTheme.Location = new System.Drawing.Point(7, 114);
            this.groupBoxTheme.Name = "groupBoxTheme";
            this.groupBoxTheme.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTheme.TabIndex = 1;
            this.groupBoxTheme.TabStop = false;
            this.groupBoxTheme.Text = "Theme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBoxSettingsLanguage
            // 
            this.groupBoxSettingsLanguage.Controls.Add(this.radioButtonDeutch);
            this.groupBoxSettingsLanguage.Controls.Add(this.radioButtonEnglish);
            this.groupBoxSettingsLanguage.Controls.Add(this.radioButtonPolish);
            this.groupBoxSettingsLanguage.Location = new System.Drawing.Point(7, 7);
            this.groupBoxSettingsLanguage.Name = "groupBoxSettingsLanguage";
            this.groupBoxSettingsLanguage.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSettingsLanguage.TabIndex = 0;
            this.groupBoxSettingsLanguage.TabStop = false;
            this.groupBoxSettingsLanguage.Text = "Language";
            // 
            // radioButtonDeutch
            // 
            this.radioButtonDeutch.AutoSize = true;
            this.radioButtonDeutch.Location = new System.Drawing.Point(7, 68);
            this.radioButtonDeutch.Name = "radioButtonDeutch";
            this.radioButtonDeutch.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDeutch.TabIndex = 2;
            this.radioButtonDeutch.Text = "Deutch";
            this.radioButtonDeutch.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Checked = true;
            this.radioButtonEnglish.Location = new System.Drawing.Point(7, 44);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEnglish.TabIndex = 1;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // radioButtonPolish
            // 
            this.radioButtonPolish.AutoSize = true;
            this.radioButtonPolish.Location = new System.Drawing.Point(7, 20);
            this.radioButtonPolish.Name = "radioButtonPolish";
            this.radioButtonPolish.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPolish.TabIndex = 0;
            this.radioButtonPolish.Text = "Polish";
            this.radioButtonPolish.UseVisualStyleBackColor = true;
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
            // colorDialogTheme
            // 
            this.colorDialogTheme.AnyColor = true;
            this.colorDialogTheme.FullOpen = true;
            this.colorDialogTheme.ShowHelp = true;
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(7, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 27);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.Settings.ResumeLayout(false);
            this.groupBoxVisualisation.ResumeLayout(false);
            this.groupBoxVisualisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxTheme.ResumeLayout(false);
            this.groupBoxTheme.PerformLayout();
            this.groupBoxSettingsLanguage.ResumeLayout(false);
            this.groupBoxSettingsLanguage.PerformLayout();
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxSettingsLanguage;
        private System.Windows.Forms.RadioButton radioButtonDeutch;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.RadioButton radioButtonPolish;
        private System.Windows.Forms.GroupBox groupBoxTheme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialogTheme;
        private System.Windows.Forms.GroupBox groupBoxVisualisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.ListView listView1;
    }
}

