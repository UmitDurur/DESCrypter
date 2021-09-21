namespace DESSifreleCoz
{
    partial class frmMain
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
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnCoz = new System.Windows.Forms.Button();
            this.txtCikti = new System.Windows.Forms.TextBox();
            this.txtGirdi = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(190, 153);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(111, 23);
            this.btnSifrele.TabIndex = 0;
            this.btnSifrele.Text = "Encrypt";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(190, 182);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(111, 23);
            this.btnCoz.TabIndex = 1;
            this.btnCoz.Text = "Decrypt";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // txtCikti
            // 
            this.txtCikti.Location = new System.Drawing.Point(307, 12);
            this.txtCikti.Multiline = true;
            this.txtCikti.Name = "txtCikti";
            this.txtCikti.Size = new System.Drawing.Size(172, 237);
            this.txtCikti.TabIndex = 2;
            // 
            // txtGirdi
            // 
            this.txtGirdi.Location = new System.Drawing.Point(12, 12);
            this.txtGirdi.Multiline = true;
            this.txtGirdi.Name = "txtGirdi";
            this.txtGirdi.Size = new System.Drawing.Size(172, 237);
            this.txtGirdi.TabIndex = 3;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(190, 107);
            this.txtKey.MaxLength = 8;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(111, 20);
            this.txtKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salt key";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtGirdi);
            this.Controls.Add(this.txtCikti);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.btnSifrele);
            this.Name = "frmMain";
            this.Text = "DES Crypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.TextBox txtCikti;
        private System.Windows.Forms.TextBox txtGirdi;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
    }
}

