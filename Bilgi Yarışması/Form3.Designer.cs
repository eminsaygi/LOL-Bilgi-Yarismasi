namespace Bilgi_Yarışması
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.iTalk_Toggle1 = new iTalk.iTalk_Toggle();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ses :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Toggle1
            // 
            this.iTalk_Toggle1.Location = new System.Drawing.Point(63, 18);
            this.iTalk_Toggle1.Name = "iTalk_Toggle1";
            this.iTalk_Toggle1.Size = new System.Drawing.Size(41, 23);
            this.iTalk_Toggle1.TabIndex = 0;
            this.iTalk_Toggle1.Text = "iTalk_Toggle1";
            this.iTalk_Toggle1.Toggled = true;
            this.iTalk_Toggle1.Type = iTalk.iTalk_Toggle._Type.YesNo;
            this.iTalk_Toggle1.ToggledChanged += new iTalk.iTalk_Toggle.ToggledChangedEventHandler(this.iTalk_Toggle1_ToggledChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(130, 51);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iTalk_Toggle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Toggle iTalk_Toggle1;
        private System.Windows.Forms.Label label2;
    }
}