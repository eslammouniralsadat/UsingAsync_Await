namespace AppUsingAsync_Await
{
    partial class FrmMain
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
            this.BtnProcess = new System.Windows.Forms.Button();
            this.lbltext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(88, 107);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(193, 69);
            this.BtnProcess.TabIndex = 0;
            this.BtnProcess.Text = "Process File";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(158, 239);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(38, 15);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 408);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.BtnProcess);
            this.Name = "FrmMain";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnProcess;
        private Label lbltext;
    }
}