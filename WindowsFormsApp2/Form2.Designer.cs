using System;

namespace WindowsFormsApp2
{
    partial class Form2
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
            this.teslimatControl1 = new WindowsFormsApp2.TeslimatControl();
            this.SuspendLayout();
            // 
            // teslimatControl1
            // 
            this.teslimatControl1.Location = new System.Drawing.Point(3, 2);
            this.teslimatControl1.Name = "teslimatControl1";
            this.teslimatControl1.Size = new System.Drawing.Size(965, 627);
            this.teslimatControl1.TabIndex = 0;
            this.teslimatControl1.Load += new System.EventHandler(this.teslimatControl1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 641);
            this.Controls.Add(this.teslimatControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private TeslimatControl teslimatControl1;

        public EventHandler Form2_Load { get; private set; }
    }
}