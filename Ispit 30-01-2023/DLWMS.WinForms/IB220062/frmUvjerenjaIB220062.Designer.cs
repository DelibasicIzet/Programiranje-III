namespace DLWMS.WinForms.IB220062
{
    partial class frmUvjerenjaIB220062
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
            this.dgvUvjerenja = new System.Windows.Forms.DataGridView();
            this.btnZahtjev = new System.Windows.Forms.Button();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUvjerenja
            // 
            this.dgvUvjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvjerenja.Location = new System.Drawing.Point(12, 56);
            this.dgvUvjerenja.Name = "dgvUvjerenja";
            this.dgvUvjerenja.RowTemplate.Height = 25;
            this.dgvUvjerenja.Size = new System.Drawing.Size(939, 267);
            this.dgvUvjerenja.TabIndex = 0;
            this.dgvUvjerenja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnZahtjev
            // 
            this.btnZahtjev.Location = new System.Drawing.Point(847, 22);
            this.btnZahtjev.Name = "btnZahtjev";
            this.btnZahtjev.Size = new System.Drawing.Size(104, 28);
            this.btnZahtjev.TabIndex = 1;
            this.btnZahtjev.Text = "Novi zahtjev";
            this.btnZahtjev.UseVisualStyleBackColor = true;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(12, 361);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(276, 23);
            this.cmbVrsta.TabIndex = 2;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(327, 361);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(318, 23);
            this.txtSvrha.TabIndex = 3;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(680, 361);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(128, 23);
            this.txtBroj.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(847, 360);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(104, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 412);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(939, 129);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj zahtjeva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Info:";
            // 
            // frmUvjerenjaIB220062
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.btnZahtjev);
            this.Controls.Add(this.dgvUvjerenja);
            this.Name = "frmUvjerenjaIB220062";
            this.Text = "frmUvjerenjaIB220062";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUvjerenja;
        private Button btnZahtjev;
        private ComboBox cmbVrsta;
        private TextBox txtSvrha;
        private TextBox txtBroj;
        private Button btnDodaj;
        private TextBox txtInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}