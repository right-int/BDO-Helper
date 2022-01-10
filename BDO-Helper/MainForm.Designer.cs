namespace BDO_Helper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.siticonePanelSide = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneButtonCombo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePanelTop = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.siticoneControlBoxMinimize = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBoxClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControlSide = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControlTop = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.siticonePanelCombo = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButtonColorPicker = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.timerCheckForUpdates = new System.Windows.Forms.Timer(this.components);
            this.siticonePanelSide.SuspendLayout();
            this.siticonePanelTop.SuspendLayout();
            this.siticonePanelCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "BDO Helper still running in the background...";
            this.notifyIcon.BalloonTipTitle = "BDO Helper";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BDO Helper";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // siticonePanelSide
            // 
            this.siticonePanelSide.Controls.Add(this.siticoneButton2);
            this.siticonePanelSide.Controls.Add(this.siticoneButtonCombo);
            this.siticonePanelSide.Controls.Add(this.siticonePictureBox1);
            this.siticonePanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanelSide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.siticonePanelSide.Location = new System.Drawing.Point(0, 0);
            this.siticonePanelSide.Name = "siticonePanelSide";
            this.siticonePanelSide.ShadowDecoration.Parent = this.siticonePanelSide;
            this.siticonePanelSide.Size = new System.Drawing.Size(180, 450);
            this.siticonePanelSide.TabIndex = 2;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton2.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.siticoneButton2.CheckedState.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.DisabledState.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoverState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(0, 217);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton2.TabIndex = 3;
            this.siticoneButton2.Text = "FailStack";
            // 
            // siticoneButtonCombo
            // 
            this.siticoneButtonCombo.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButtonCombo.Checked = true;
            this.siticoneButtonCombo.CheckedState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneButtonCombo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.siticoneButtonCombo.CheckedState.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.siticoneButtonCombo.CheckedState.Parent = this.siticoneButtonCombo;
            this.siticoneButtonCombo.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.siticoneButtonCombo.CustomImages.Parent = this.siticoneButtonCombo;
            this.siticoneButtonCombo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButtonCombo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButtonCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButtonCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButtonCombo.DisabledState.Parent = this.siticoneButtonCombo;
            this.siticoneButtonCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.siticoneButtonCombo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButtonCombo.ForeColor = System.Drawing.Color.White;
            this.siticoneButtonCombo.HoverState.Parent = this.siticoneButtonCombo;
            this.siticoneButtonCombo.Location = new System.Drawing.Point(0, 166);
            this.siticoneButtonCombo.Name = "siticoneButtonCombo";
            this.siticoneButtonCombo.ShadowDecoration.Parent = this.siticoneButtonCombo;
            this.siticoneButtonCombo.Size = new System.Drawing.Size(180, 45);
            this.siticoneButtonCombo.TabIndex = 3;
            this.siticoneButtonCombo.Text = "Combo";
            // 
            // siticonePanelTop
            // 
            this.siticonePanelTop.Controls.Add(this.labelVersion);
            this.siticonePanelTop.Controls.Add(this.siticoneControlBoxMinimize);
            this.siticonePanelTop.Controls.Add(this.siticoneControlBoxClose);
            this.siticonePanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.siticonePanelTop.Location = new System.Drawing.Point(180, 0);
            this.siticonePanelTop.Name = "siticonePanelTop";
            this.siticonePanelTop.ShadowDecoration.Parent = this.siticonePanelTop;
            this.siticonePanelTop.Size = new System.Drawing.Size(620, 70);
            this.siticonePanelTop.TabIndex = 3;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(273, 22);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(44, 20);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "0.0.0";
            // 
            // siticoneControlBoxMinimize
            // 
            this.siticoneControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBoxMinimize.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.siticoneControlBoxMinimize.HoverState.Parent = this.siticoneControlBoxMinimize;
            this.siticoneControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.siticoneControlBoxMinimize.Location = new System.Drawing.Point(521, 3);
            this.siticoneControlBoxMinimize.Name = "siticoneControlBoxMinimize";
            this.siticoneControlBoxMinimize.ShadowDecoration.Parent = this.siticoneControlBoxMinimize;
            this.siticoneControlBoxMinimize.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBoxMinimize.TabIndex = 0;
            // 
            // siticoneControlBoxClose
            // 
            this.siticoneControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBoxClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.siticoneControlBoxClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBoxClose.HoverState.Parent = this.siticoneControlBoxClose;
            this.siticoneControlBoxClose.IconColor = System.Drawing.Color.White;
            this.siticoneControlBoxClose.Location = new System.Drawing.Point(572, 3);
            this.siticoneControlBoxClose.Name = "siticoneControlBoxClose";
            this.siticoneControlBoxClose.ShadowDecoration.Parent = this.siticoneControlBoxClose;
            this.siticoneControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBoxClose.TabIndex = 0;
            // 
            // siticoneDragControlSide
            // 
            this.siticoneDragControlSide.TargetControl = this.siticonePanelSide;
            // 
            // siticoneDragControlTop
            // 
            this.siticoneDragControlTop.TargetControl = this.siticonePanelTop;
            // 
            // siticonePanelCombo
            // 
            this.siticonePanelCombo.BackgroundImage = global::BDO_Helper.Properties.Resources.bdo_wallpaper1;
            this.siticonePanelCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siticonePanelCombo.Controls.Add(this.siticoneButtonColorPicker);
            this.siticonePanelCombo.Controls.Add(this.comboBoxClass);
            this.siticonePanelCombo.Controls.Add(this.numericUpDownFontSize);
            this.siticonePanelCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanelCombo.FillColor = System.Drawing.Color.Transparent;
            this.siticonePanelCombo.Location = new System.Drawing.Point(180, 70);
            this.siticonePanelCombo.Name = "siticonePanelCombo";
            this.siticonePanelCombo.ShadowDecoration.Parent = this.siticonePanelCombo;
            this.siticonePanelCombo.Size = new System.Drawing.Size(620, 380);
            this.siticonePanelCombo.TabIndex = 4;
            // 
            // siticoneButtonColorPicker
            // 
            this.siticoneButtonColorPicker.CheckedState.Parent = this.siticoneButtonColorPicker;
            this.siticoneButtonColorPicker.CustomImages.Parent = this.siticoneButtonColorPicker;
            this.siticoneButtonColorPicker.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButtonColorPicker.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButtonColorPicker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButtonColorPicker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButtonColorPicker.DisabledState.Parent = this.siticoneButtonColorPicker;
            this.siticoneButtonColorPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.siticoneButtonColorPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButtonColorPicker.ForeColor = System.Drawing.Color.White;
            this.siticoneButtonColorPicker.HoverState.Parent = this.siticoneButtonColorPicker;
            this.siticoneButtonColorPicker.Location = new System.Drawing.Point(204, 246);
            this.siticoneButtonColorPicker.Name = "siticoneButtonColorPicker";
            this.siticoneButtonColorPicker.ShadowDecoration.Parent = this.siticoneButtonColorPicker;
            this.siticoneButtonColorPicker.Size = new System.Drawing.Size(180, 45);
            this.siticoneButtonColorPicker.TabIndex = 2;
            this.siticoneButtonColorPicker.Text = "Choose Color";
            this.siticoneButtonColorPicker.Click += new System.EventHandler(this.siticoneButtonColorPicker_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Sorceress Succession",
            "Sorceress Awakening",
            "Nova Succession",
            "Nova Awakening",
            "Ninja Succession",
            "Ninja Awakening"});
            this.comboBoxClass.Location = new System.Drawing.Point(204, 51);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(180, 21);
            this.comboBoxClass.TabIndex = 1;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(204, 121);
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(180, 20);
            this.numericUpDownFontSize.TabIndex = 0;
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.numericUpDownFontSize_ValueChanged);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Enabled = false;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(75)))));
            this.siticonePictureBox1.Image = global::BDO_Helper.Properties.Resources.black_desert_icon;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(24, 22);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(132, 107);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 2;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            this.siticonePictureBox1.Click += new System.EventHandler(this.siticonePictureBox1_Click);
            // 
            // timerCheckForUpdates
            // 
            this.timerCheckForUpdates.Enabled = true;
            this.timerCheckForUpdates.Interval = 1000;
            this.timerCheckForUpdates.Tick += new System.EventHandler(this.timerCheckForUpdates_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticonePanelCombo);
            this.Controls.Add(this.siticonePanelTop);
            this.Controls.Add(this.siticonePanelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDO Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.siticonePanelSide.ResumeLayout(false);
            this.siticonePanelTop.ResumeLayout(false);
            this.siticonePanelTop.PerformLayout();
            this.siticonePanelCombo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanelSide;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanelTop;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanelCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControlSide;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControlTop;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBoxClose;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBoxMinimize;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButtonCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButtonColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Timer timerCheckForUpdates;
    }
}

