namespace Lab2
{
    partial class Bai3
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
            this.btnInput = new System.Windows.Forms.Button();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(151, 12);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(193, 66);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "INPUT FILE";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // rtbFile
            // 
            this.rtbFile.Location = new System.Drawing.Point(12, 95);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.ReadOnly = true;
            this.rtbFile.Size = new System.Drawing.Size(687, 519);
            this.rtbFile.TabIndex = 1;
            this.rtbFile.Text = "";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(384, 12);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(193, 66);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "OUTPUT FILE";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // frmB3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 638);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.btnInput);
            this.Name = "frmB3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.Button btnOutput;
    }
}