﻿namespace easyPokerHUD
{
    partial class StatsWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VPIP = new System.Windows.Forms.Label();
            this.PFR = new System.Windows.Forms.Label();
            this.AFq = new System.Windows.Forms.Label();
            this.handsplayed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VPIP
            // 
            this.VPIP.AutoSize = true;
            this.VPIP.BackColor = System.Drawing.Color.Transparent;
            this.VPIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.VPIP.ForeColor = System.Drawing.Color.White;
            this.VPIP.Location = new System.Drawing.Point(4, 1);
            this.VPIP.Name = "VPIP";
            this.VPIP.Size = new System.Drawing.Size(39, 20);
            this.VPIP.TabIndex = 0;
            this.VPIP.Text = "100";
            this.VPIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PFR
            // 
            this.PFR.AutoSize = true;
            this.PFR.BackColor = System.Drawing.Color.Transparent;
            this.PFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.PFR.ForeColor = System.Drawing.Color.White;
            this.PFR.Location = new System.Drawing.Point(49, 1);
            this.PFR.Name = "PFR";
            this.PFR.Size = new System.Drawing.Size(39, 20);
            this.PFR.TabIndex = 1;
            this.PFR.Text = "100";
            this.PFR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AFq
            // 
            this.AFq.AutoSize = true;
            this.AFq.BackColor = System.Drawing.Color.Transparent;
            this.AFq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.AFq.ForeColor = System.Drawing.Color.White;
            this.AFq.Location = new System.Drawing.Point(94, 1);
            this.AFq.Name = "AFq";
            this.AFq.Size = new System.Drawing.Size(39, 20);
            this.AFq.TabIndex = 2;
            this.AFq.Text = "100";
            this.AFq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // handsplayed
            // 
            this.handsplayed.AutoSize = true;
            this.handsplayed.BackColor = System.Drawing.Color.Transparent;
            this.handsplayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.handsplayed.ForeColor = System.Drawing.Color.Gray;
            this.handsplayed.Location = new System.Drawing.Point(139, 1);
            this.handsplayed.Name = "handsplayed";
            this.handsplayed.Size = new System.Drawing.Size(39, 20);
            this.handsplayed.TabIndex = 3;
            this.handsplayed.Text = "100";
            this.handsplayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.VPIP);
            this.Controls.Add(this.PFR);
            this.Controls.Add(this.handsplayed);
            this.Controls.Add(this.AFq);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "StatsWindow";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Size = new System.Drawing.Size(182, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label VPIP;
        public System.Windows.Forms.Label PFR;
        public System.Windows.Forms.Label AFq;
        public System.Windows.Forms.Label handsplayed;
    }
}
