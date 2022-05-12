namespace stegano
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttn_open = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bttn_crypt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bttn_decrypt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.textBoxFilePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 158);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bttn_open
            // 
            this.bttn_open.Depth = 0;
            this.bttn_open.Location = new System.Drawing.Point(212, 70);
            this.bttn_open.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_open.Name = "bttn_open";
            this.bttn_open.Primary = true;
            this.bttn_open.Size = new System.Drawing.Size(74, 53);
            this.bttn_open.TabIndex = 14;
            this.bttn_open.Text = "Bild Öffnen";
            this.bttn_open.UseVisualStyleBackColor = true;
            this.bttn_open.Click += new System.EventHandler(this.bttn_open_Click);
            // 
            // bttn_crypt
            // 
            this.bttn_crypt.Depth = 0;
            this.bttn_crypt.Location = new System.Drawing.Point(212, 145);
            this.bttn_crypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_crypt.Name = "bttn_crypt";
            this.bttn_crypt.Primary = true;
            this.bttn_crypt.Size = new System.Drawing.Size(127, 40);
            this.bttn_crypt.TabIndex = 15;
            this.bttn_crypt.Text = "Verschlüsseln";
            this.bttn_crypt.UseVisualStyleBackColor = true;
            this.bttn_crypt.Click += new System.EventHandler(this.bttn_crypt_Click);
            // 
            // bttn_decrypt
            // 
            this.bttn_decrypt.Depth = 0;
            this.bttn_decrypt.Location = new System.Drawing.Point(345, 145);
            this.bttn_decrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_decrypt.Name = "bttn_decrypt";
            this.bttn_decrypt.Primary = true;
            this.bttn_decrypt.Size = new System.Drawing.Size(127, 40);
            this.bttn_decrypt.TabIndex = 16;
            this.bttn_decrypt.Text = "Entschlüsseln";
            this.bttn_decrypt.UseVisualStyleBackColor = true;
            this.bttn_decrypt.Click += new System.EventHandler(this.bttn_decrypt_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(226, 196);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Nachricht:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Depth = 0;
            this.textBoxMessage.Hint = "";
            this.textBoxMessage.Location = new System.Drawing.Point(310, 196);
            this.textBoxMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.PasswordChar = '\0';
            this.textBoxMessage.SelectedText = "";
            this.textBoxMessage.SelectionLength = 0;
            this.textBoxMessage.SelectionStart = 0;
            this.textBoxMessage.Size = new System.Drawing.Size(180, 23);
            this.textBoxMessage.TabIndex = 19;
            this.textBoxMessage.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(196, 62);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 192);
            this.materialDivider1.TabIndex = 20;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Depth = 0;
            this.textBoxFilePath.Hint = "";
            this.textBoxFilePath.Location = new System.Drawing.Point(292, 85);
            this.textBoxFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.PasswordChar = '\0';
            this.textBoxFilePath.SelectedText = "";
            this.textBoxFilePath.SelectionLength = 0;
            this.textBoxFilePath.SelectionStart = 0;
            this.textBoxFilePath.Size = new System.Drawing.Size(226, 23);
            this.textBoxFilePath.TabIndex = 17;
            this.textBoxFilePath.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(196, 129);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(346, 10);
            this.materialDivider2.TabIndex = 21;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(478, 145);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(40, 40);
            this.materialRaisedButton1.TabIndex = 22;
            this.materialRaisedButton1.Text = "X";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 236);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.bttn_decrypt);
            this.Controls.Add(this.bttn_crypt);
            this.Controls.Add(this.bttn_open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "D3 Steganographie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_open;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_crypt;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_decrypt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxMessage;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxFilePath;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}

