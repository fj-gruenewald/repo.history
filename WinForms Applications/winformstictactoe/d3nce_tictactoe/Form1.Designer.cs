namespace d3nce_tictactoe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.bttn_ns = new System.Windows.Forms.Button();
            this.bttn_beenden = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_draw = new System.Windows.Forms.Label();
            this.bttn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(12, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(100, 100);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(118, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(100, 100);
            this.A01.TabIndex = 1;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(224, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(100, 100);
            this.A02.TabIndex = 2;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(224, 118);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(100, 100);
            this.A12.TabIndex = 5;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(118, 118);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(100, 100);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(12, 118);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(100, 100);
            this.A10.TabIndex = 3;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(224, 224);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(100, 100);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(118, 224);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(100, 100);
            this.A21.TabIndex = 7;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(12, 224);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(100, 100);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // bttn_ns
            // 
            this.bttn_ns.Location = new System.Drawing.Point(353, 157);
            this.bttn_ns.Name = "bttn_ns";
            this.bttn_ns.Size = new System.Drawing.Size(128, 52);
            this.bttn_ns.TabIndex = 9;
            this.bttn_ns.Text = "Neues Spiel";
            this.bttn_ns.UseVisualStyleBackColor = true;
            this.bttn_ns.Click += new System.EventHandler(this.bttn_ns_Click);
            // 
            // bttn_beenden
            // 
            this.bttn_beenden.Location = new System.Drawing.Point(353, 273);
            this.bttn_beenden.Name = "bttn_beenden";
            this.bttn_beenden.Size = new System.Drawing.Size(128, 52);
            this.bttn_beenden.TabIndex = 11;
            this.bttn_beenden.Text = "Beenden";
            this.bttn_beenden.UseVisualStyleBackColor = true;
            this.bttn_beenden.Click += new System.EventHandler(this.bttn_beenden_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(330, 12);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(31, 20);
            this.lbl_x.TabIndex = 12;
            this.lbl_x.Text = "X: ";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_y.Location = new System.Drawing.Point(330, 51);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(26, 20);
            this.lbl_y.TabIndex = 13;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_draw
            // 
            this.lbl_draw.AutoSize = true;
            this.lbl_draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_draw.Location = new System.Drawing.Point(330, 92);
            this.lbl_draw.Name = "lbl_draw";
            this.lbl_draw.Size = new System.Drawing.Size(55, 20);
            this.lbl_draw.TabIndex = 14;
            this.lbl_draw.Text = "Draw:";
            // 
            // bttn_reset
            // 
            this.bttn_reset.Location = new System.Drawing.Point(353, 215);
            this.bttn_reset.Name = "bttn_reset";
            this.bttn_reset.Size = new System.Drawing.Size(128, 52);
            this.bttn_reset.TabIndex = 15;
            this.bttn_reset.Text = "Reset";
            this.bttn_reset.UseVisualStyleBackColor = true;
            this.bttn_reset.Click += new System.EventHandler(this.bttn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 337);
            this.Controls.Add(this.bttn_reset);
            this.Controls.Add(this.lbl_draw);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.bttn_beenden);
            this.Controls.Add(this.bttn_ns);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "SimpleTicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button bttn_ns;
        private System.Windows.Forms.Button bttn_beenden;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_draw;
        private System.Windows.Forms.Button bttn_reset;
    }
}

