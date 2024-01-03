namespace DLWMS.WinForms.IB220062
{
    partial class frmStudentIB220062
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
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.lblImeStudenta = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStudent
            // 
            this.pbStudent.Location = new System.Drawing.Point(84, 37);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(252, 276);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 0;
            this.pbStudent.TabStop = false;
            // 
            // lblImeStudenta
            // 
            this.lblImeStudenta.AutoSize = true;
            this.lblImeStudenta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImeStudenta.Location = new System.Drawing.Point(170, 334);
            this.lblImeStudenta.Name = "lblImeStudenta";
            this.lblImeStudenta.Size = new System.Drawing.Size(72, 30);
            this.lblImeStudenta.TabIndex = 1;
            this.lblImeStudenta.Text = "label1";
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProsjek.Location = new System.Drawing.Point(170, 380);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(72, 30);
            this.lblProsjek.TabIndex = 4;
            this.lblProsjek.Text = "label2";
            // 
            // frmStudentIB220062
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 452);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblImeStudenta);
            this.Controls.Add(this.pbStudent);
            this.Name = "frmStudentIB220062";
            this.Text = "frmStudentIB220062";
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbStudent;
        private Label lblImeStudenta;
        private Label lblProsjek;
    }
}