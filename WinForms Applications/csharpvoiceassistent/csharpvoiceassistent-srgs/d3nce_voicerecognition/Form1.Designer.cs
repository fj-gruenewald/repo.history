namespace d3nce_voicerecognition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_time = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_date = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_weather = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_temp = new MaterialSkin.Controls.MaterialLabel();
            this.brow_main = new System.Windows.Forms.WebBrowser();
            this.lbl_quest = new System.Windows.Forms.Label();
            this.lbl_ans = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.tab_control = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.tab_wiki = new System.Windows.Forms.TabPage();
            this.tab_browser = new System.Windows.Forms.TabPage();
            this.tab_text = new System.Windows.Forms.TabPage();
            this.tab_media = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.media_main = new AxWMPLib.AxWindowsMediaPlayer();
            this.tab_control.SuspendLayout();
            this.tab_home.SuspendLayout();
            this.tab_wiki.SuspendLayout();
            this.tab_browser.SuspendLayout();
            this.tab_text.SuspendLayout();
            this.tab_media.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media_main)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Depth = 0;
            this.lbl_time.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_time.Location = new System.Drawing.Point(8, 18);
            this.lbl_time.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 19);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "time";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Depth = 0;
            this.lbl_date.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_date.Location = new System.Drawing.Point(9, 42);
            this.lbl_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 19);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "date";
            // 
            // lbl_weather
            // 
            this.lbl_weather.AutoSize = true;
            this.lbl_weather.Depth = 0;
            this.lbl_weather.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_weather.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_weather.Location = new System.Drawing.Point(9, 105);
            this.lbl_weather.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_weather.Name = "lbl_weather";
            this.lbl_weather.Size = new System.Drawing.Size(51, 19);
            this.lbl_weather.TabIndex = 5;
            this.lbl_weather.Text = "wetter";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Depth = 0;
            this.lbl_temp.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_temp.Location = new System.Drawing.Point(9, 81);
            this.lbl_temp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(82, 19);
            this.lbl_temp.TabIndex = 6;
            this.lbl_temp.Text = "temperatur";
            // 
            // brow_main
            // 
            this.brow_main.Location = new System.Drawing.Point(6, 6);
            this.brow_main.MinimumSize = new System.Drawing.Size(20, 20);
            this.brow_main.Name = "brow_main";
            this.brow_main.Size = new System.Drawing.Size(748, 292);
            this.brow_main.TabIndex = 7;
            this.brow_main.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // lbl_quest
            // 
            this.lbl_quest.AutoSize = true;
            this.lbl_quest.Font = new System.Drawing.Font("Adobe Caslon Pro", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quest.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_quest.Location = new System.Drawing.Point(2, 70);
            this.lbl_quest.Name = "lbl_quest";
            this.lbl_quest.Size = new System.Drawing.Size(370, 60);
            this.lbl_quest.TabIndex = 8;
            this.lbl_quest.Text = "Frag mich einfach etwas...";
            // 
            // lbl_ans
            // 
            this.lbl_ans.AutoSize = true;
            this.lbl_ans.Font = new System.Drawing.Font("Adobe Caslon Pro", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ans.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ans.Location = new System.Drawing.Point(361, 14);
            this.lbl_ans.Name = "lbl_ans";
            this.lbl_ans.Size = new System.Drawing.Size(307, 49);
            this.lbl_ans.TabIndex = 13;
            this.lbl_ans.Text = "Frag mich einfach etwas...";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "termin";
            // 
            // txt_info
            // 
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.Location = new System.Drawing.Point(6, 6);
            this.txt_info.MaxLength = 50;
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_info.Size = new System.Drawing.Size(748, 291);
            this.txt_info.TabIndex = 16;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_home);
            this.tab_control.Controls.Add(this.tab_wiki);
            this.tab_control.Controls.Add(this.tab_browser);
            this.tab_control.Controls.Add(this.tab_text);
            this.tab_control.Controls.Add(this.tab_media);
            this.tab_control.Controls.Add(this.tabPage6);
            this.tab_control.Depth = 0;
            this.tab_control.Location = new System.Drawing.Point(0, 118);
            this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(769, 330);
            this.tab_control.TabIndex = 17;
            // 
            // tab_home
            // 
            this.tab_home.Controls.Add(this.lbl_date);
            this.tab_home.Controls.Add(this.lbl_time);
            this.tab_home.Controls.Add(this.materialLabel1);
            this.tab_home.Controls.Add(this.lbl_weather);
            this.tab_home.Controls.Add(this.lbl_temp);
            this.tab_home.Location = new System.Drawing.Point(4, 22);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(761, 304);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "tab_home";
            this.tab_home.UseVisualStyleBackColor = true;
            // 
            // tab_wiki
            // 
            this.tab_wiki.Controls.Add(this.txt_info);
            this.tab_wiki.Location = new System.Drawing.Point(4, 22);
            this.tab_wiki.Name = "tab_wiki";
            this.tab_wiki.Padding = new System.Windows.Forms.Padding(3);
            this.tab_wiki.Size = new System.Drawing.Size(761, 304);
            this.tab_wiki.TabIndex = 1;
            this.tab_wiki.Text = "tab_wiki";
            this.tab_wiki.UseVisualStyleBackColor = true;
            // 
            // tab_browser
            // 
            this.tab_browser.Controls.Add(this.brow_main);
            this.tab_browser.Location = new System.Drawing.Point(4, 22);
            this.tab_browser.Name = "tab_browser";
            this.tab_browser.Padding = new System.Windows.Forms.Padding(3);
            this.tab_browser.Size = new System.Drawing.Size(761, 304);
            this.tab_browser.TabIndex = 2;
            this.tab_browser.Text = "tab_browser";
            this.tab_browser.UseVisualStyleBackColor = true;
            // 
            // tab_text
            // 
            this.tab_text.Controls.Add(this.lbl_ans);
            this.tab_text.Location = new System.Drawing.Point(4, 22);
            this.tab_text.Name = "tab_text";
            this.tab_text.Padding = new System.Windows.Forms.Padding(3);
            this.tab_text.Size = new System.Drawing.Size(761, 304);
            this.tab_text.TabIndex = 3;
            this.tab_text.Text = "tab_text";
            this.tab_text.UseVisualStyleBackColor = true;
            // 
            // tab_media
            // 
            this.tab_media.Controls.Add(this.media_main);
            this.tab_media.Location = new System.Drawing.Point(4, 22);
            this.tab_media.Name = "tab_media";
            this.tab_media.Padding = new System.Windows.Forms.Padding(3);
            this.tab_media.Size = new System.Drawing.Size(761, 304);
            this.tab_media.TabIndex = 4;
            this.tab_media.Text = "media";
            this.tab_media.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(761, 304);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // media_main
            // 
            this.media_main.Enabled = true;
            this.media_main.Location = new System.Drawing.Point(3, 6);
            this.media_main.Name = "media_main";
            this.media_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_main.OcxState")));
            this.media_main.Size = new System.Drawing.Size(752, 291);
            this.media_main.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 449);
            this.Controls.Add(this.tab_control);
            this.Controls.Add(this.lbl_quest);
            this.Name = "Form1";
            this.Text = "YouVoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_control.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.tab_home.PerformLayout();
            this.tab_wiki.ResumeLayout(false);
            this.tab_wiki.PerformLayout();
            this.tab_browser.ResumeLayout(false);
            this.tab_text.ResumeLayout(false);
            this.tab_text.PerformLayout();
            this.tab_media.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.media_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_time;
        private MaterialSkin.Controls.MaterialLabel lbl_date;
        private MaterialSkin.Controls.MaterialLabel lbl_weather;
        private MaterialSkin.Controls.MaterialLabel lbl_temp;
        private System.Windows.Forms.WebBrowser brow_main;
        private System.Windows.Forms.Label lbl_quest;
        private System.Windows.Forms.Label lbl_ans;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txt_info;
        private MaterialSkin.Controls.MaterialTabControl tab_control;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tab_wiki;
        private System.Windows.Forms.TabPage tab_browser;
        private System.Windows.Forms.TabPage tab_text;
        private System.Windows.Forms.TabPage tab_media;
        private System.Windows.Forms.TabPage tabPage6;
        private AxWMPLib.AxWindowsMediaPlayer media_main;
    }
}

