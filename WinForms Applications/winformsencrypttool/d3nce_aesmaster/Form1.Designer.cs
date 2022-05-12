namespace d3nce_aesmaster
{
    partial class main
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
            this.txt_ver = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unv = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_verschlussel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bttn_entschlussel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bttn_clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.com_art = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_ver
            // 
            this.txt_ver.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_ver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ver.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_ver.Location = new System.Drawing.Point(12, 238);
            this.txt_ver.Name = "txt_ver";
            this.txt_ver.Size = new System.Drawing.Size(354, 96);
            this.txt_ver.TabIndex = 11;
            this.txt_ver.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Verschlüsselte Nachricht:";
            // 
            // txt_unv
            // 
            this.txt_unv.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_unv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_unv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unv.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_unv.Location = new System.Drawing.Point(12, 101);
            this.txt_unv.Name = "txt_unv";
            this.txt_unv.Size = new System.Drawing.Size(354, 96);
            this.txt_unv.TabIndex = 8;
            this.txt_unv.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nachricht:";
            // 
            // bttn_verschlussel
            // 
            this.bttn_verschlussel.Depth = 0;
            this.bttn_verschlussel.Location = new System.Drawing.Point(385, 101);
            this.bttn_verschlussel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_verschlussel.Name = "bttn_verschlussel";
            this.bttn_verschlussel.Primary = true;
            this.bttn_verschlussel.Size = new System.Drawing.Size(115, 96);
            this.bttn_verschlussel.TabIndex = 14;
            this.bttn_verschlussel.Text = "Verschlüsseln";
            this.bttn_verschlussel.UseVisualStyleBackColor = true;
            this.bttn_verschlussel.Click += new System.EventHandler(this.bttn_verschlussel_Click);
            // 
            // bttn_entschlussel
            // 
            this.bttn_entschlussel.Depth = 0;
            this.bttn_entschlussel.Location = new System.Drawing.Point(385, 238);
            this.bttn_entschlussel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_entschlussel.Name = "bttn_entschlussel";
            this.bttn_entschlussel.Primary = true;
            this.bttn_entschlussel.Size = new System.Drawing.Size(115, 96);
            this.bttn_entschlussel.TabIndex = 15;
            this.bttn_entschlussel.Text = "Entschlüsseln";
            this.bttn_entschlussel.UseVisualStyleBackColor = true;
            this.bttn_entschlussel.Click += new System.EventHandler(this.bttn_entschlussel_Click);
            // 
            // bttn_clear
            // 
            this.bttn_clear.Depth = 0;
            this.bttn_clear.Location = new System.Drawing.Point(12, 360);
            this.bttn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Primary = true;
            this.bttn_clear.Size = new System.Drawing.Size(354, 32);
            this.bttn_clear.TabIndex = 16;
            this.bttn_clear.Text = "Clear";
            this.bttn_clear.UseVisualStyleBackColor = true;
            this.bttn_clear.Click += new System.EventHandler(this.bttn_clear_Click);
            // 
            // com_art
            // 
            this.com_art.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.com_art.Cursor = System.Windows.Forms.Cursors.Default;
            this.com_art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_art.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.com_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_art.ForeColor = System.Drawing.SystemColors.Menu;
            this.com_art.FormattingEnabled = true;
            this.com_art.Items.AddRange(new object[] {
            "AES256",
            "AES128",
            "Leetspeak",
            "Caesar Chiffre",
            ""});
            this.com_art.Location = new System.Drawing.Point(372, 360);
            this.com_art.Name = "com_art";
            this.com_art.Size = new System.Drawing.Size(128, 28);
            this.com_art.TabIndex = 18;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 409);
            this.Controls.Add(this.com_art);
            this.Controls.Add(this.bttn_clear);
            this.Controls.Add(this.bttn_entschlussel);
            this.Controls.Add(this.bttn_verschlussel);
            this.Controls.Add(this.txt_ver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_unv);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "AESMASTER";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_unv;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_verschlussel;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_entschlussel;
        private MaterialSkin.Controls.MaterialRaisedButton bttn_clear;
        private System.Windows.Forms.ComboBox com_art;
    }
}

