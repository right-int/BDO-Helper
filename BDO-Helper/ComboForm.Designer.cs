namespace BDO_Helper
{
    partial class ComboForm
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
            this.labelCombo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.BackColor = System.Drawing.Color.Transparent;
            this.labelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombo.ForeColor = System.Drawing.Color.Blue;
            this.labelCombo.Location = new System.Drawing.Point(38, 42);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(36, 20);
            this.labelCombo.TabIndex = 0;
            this.labelCombo.Text = "test";
            // 
            // ComboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.labelCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComboForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ComboForm";
            this.Load += new System.EventHandler(this.ComboForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCombo;
    }
}