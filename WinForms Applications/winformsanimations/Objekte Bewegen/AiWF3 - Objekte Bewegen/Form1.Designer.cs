namespace AiWF3___Objekte_Bewegen
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
            this.components = new System.ComponentModel.Container();
            this.pnl_objekt = new System.Windows.Forms.Panel();
            this.time_bewegung = new System.Windows.Forms.Timer(this.components);
            this.bttn_fang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_objekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_objekt
            // 
            this.pnl_objekt.BackColor = System.Drawing.Color.DarkRed;
            this.pnl_objekt.Controls.Add(this.label1);
            this.pnl_objekt.Location = new System.Drawing.Point(12, 12);
            this.pnl_objekt.Name = "pnl_objekt";
            this.pnl_objekt.Size = new System.Drawing.Size(113, 102);
            this.pnl_objekt.TabIndex = 0;
            // 
            // time_bewegung
            // 
            this.time_bewegung.Interval = 1;
            this.time_bewegung.Tick += new System.EventHandler(this.time_bewegung_Tick);
            // 
            // bttn_fang
            // 
            this.bttn_fang.Location = new System.Drawing.Point(617, 8);
            this.bttn_fang.Name = "bttn_fang";
            this.bttn_fang.Size = new System.Drawing.Size(113, 106);
            this.bttn_fang.TabIndex = 1;
            this.bttn_fang.Text = "fang mich";
            this.bttn_fang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HUIIIIII";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 398);
            this.Controls.Add(this.bttn_fang);
            this.Controls.Add(this.pnl_objekt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_objekt.ResumeLayout(false);
            this.pnl_objekt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_objekt;
        private System.Windows.Forms.Timer time_bewegung;
        private System.Windows.Forms.Button bttn_fang;
        private System.Windows.Forms.Label label1;
    }
}

