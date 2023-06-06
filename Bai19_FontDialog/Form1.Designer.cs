namespace Bai19_FontDialog
{
    partial class Form1
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
			this.txtText = new System.Windows.Forms.TextBox();
			this.btnChonFont = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtText
			// 
			this.txtText.Location = new System.Drawing.Point(37, 39);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(575, 34);
			this.txtText.TabIndex = 0;
			// 
			// btnChonFont
			// 
			this.btnChonFont.Location = new System.Drawing.Point(193, 109);
			this.btnChonFont.Name = "btnChonFont";
			this.btnChonFont.Size = new System.Drawing.Size(265, 48);
			this.btnChonFont.TabIndex = 1;
			this.btnChonFont.Text = "Chọn &font";
			this.btnChonFont.UseVisualStyleBackColor = true;
			this.btnChonFont.Click += new System.EventHandler(this.btnChonFont_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(650, 176);
			this.Controls.Add(this.btnChonFont);
			this.Controls.Add(this.txtText);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Red;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài 19: Font Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnChonFont;
    }
}

