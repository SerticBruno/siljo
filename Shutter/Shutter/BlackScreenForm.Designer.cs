namespace Shutter
{
    partial class BlackScreenForm
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
            this.tooltipLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tooltipLbl
            // 
            this.tooltipLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tooltipLbl.AutoSize = true;
            this.tooltipLbl.BackColor = System.Drawing.Color.Transparent;
            this.tooltipLbl.Font = new System.Drawing.Font("DS-Digital", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tooltipLbl.ForeColor = System.Drawing.Color.White;
            this.tooltipLbl.Location = new System.Drawing.Point(269, 9);
            this.tooltipLbl.Name = "tooltipLbl";
            this.tooltipLbl.Size = new System.Drawing.Size(265, 21);
            this.tooltipLbl.TabIndex = 0;
            this.tooltipLbl.Text = "PRESS ESC TO EXIT FULLSCREEN";
            this.tooltipLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlackScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shutter.Properties.Resources.blackScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tooltipLbl);
            this.Name = "BlackScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BlackScreenForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BlackScreenForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tooltipLbl;
    }
}