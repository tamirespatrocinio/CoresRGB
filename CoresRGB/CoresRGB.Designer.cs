
namespace CoresRGB
{
    partial class CoresRGB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblNumberRed = new System.Windows.Forms.Label();
            this.lblNumberGreen = new System.Windows.Forms.Label();
            this.lblNumberBlue = new System.Windows.Forms.Label();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.lblPainel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paleta de Cores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(87, 100);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(60, 25);
            this.lblRed.TabIndex = 1;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(87, 153);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(60, 25);
            this.lblGreen.TabIndex = 2;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlue.Location = new System.Drawing.Point(87, 206);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(60, 25);
            this.lblBlue.TabIndex = 3;
            // 
            // lblNumberRed
            // 
            this.lblNumberRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberRed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberRed.Location = new System.Drawing.Point(172, 100);
            this.lblNumberRed.Name = "lblNumberRed";
            this.lblNumberRed.Size = new System.Drawing.Size(65, 25);
            this.lblNumberRed.TabIndex = 4;
            this.lblNumberRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberGreen
            // 
            this.lblNumberGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberGreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberGreen.Location = new System.Drawing.Point(172, 153);
            this.lblNumberGreen.Name = "lblNumberGreen";
            this.lblNumberGreen.Size = new System.Drawing.Size(65, 25);
            this.lblNumberGreen.TabIndex = 5;
            this.lblNumberGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberBlue
            // 
            this.lblNumberBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberBlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberBlue.Location = new System.Drawing.Point(172, 206);
            this.lblNumberBlue.Name = "lblNumberBlue";
            this.lblNumberBlue.Size = new System.Drawing.Size(65, 25);
            this.lblNumberBlue.TabIndex = 6;
            this.lblNumberBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.LargeChange = 1;
            this.hScrollBarRed.Location = new System.Drawing.Point(263, 100);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Minimum = 1;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(254, 25);
            this.hScrollBarRed.TabIndex = 7;
            this.hScrollBarRed.Value = 1;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.LargeChange = 1;
            this.hScrollBarGreen.Location = new System.Drawing.Point(263, 153);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Minimum = 1;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(254, 25);
            this.hScrollBarGreen.TabIndex = 8;
            this.hScrollBarGreen.Value = 1;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.LargeChange = 1;
            this.hScrollBarBlue.Location = new System.Drawing.Point(263, 206);
            this.hScrollBarBlue.Minimum = 1;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(254, 25);
            this.hScrollBarBlue.TabIndex = 9;
            this.hScrollBarBlue.Value = 1;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // lblPainel
            // 
            this.lblPainel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPainel.Location = new System.Drawing.Point(87, 272);
            this.lblPainel.Name = "lblPainel";
            this.lblPainel.Size = new System.Drawing.Size(430, 134);
            this.lblPainel.TabIndex = 10;
            // 
            // CoresRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.lblPainel);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.lblNumberBlue);
            this.Controls.Add(this.lblNumberGreen);
            this.Controls.Add(this.lblNumberRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label1);
            this.Name = "CoresRGB";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cores em RGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblNumberRed;
        private System.Windows.Forms.Label lblNumberGreen;
        private System.Windows.Forms.Label lblNumberBlue;
        private System.Windows.Forms.HScrollBar hScrollBarRed;
        private System.Windows.Forms.HScrollBar hScrollBarGreen;
        private System.Windows.Forms.HScrollBar hScrollBarBlue;
        private System.Windows.Forms.Label lblPainel;
    }
}

