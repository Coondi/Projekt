namespace Projekt
{
    partial class Form2
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
            this.cbInstrumenty = new System.Windows.Forms.ComboBox();
            this.cbDzwieki = new System.Windows.Forms.ComboBox();
            this.btnPrzegladaj = new System.Windows.Forms.Button();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbInstrumenty
            // 
            this.cbInstrumenty.FormattingEnabled = true;
            this.cbInstrumenty.Location = new System.Drawing.Point(76, 33);
            this.cbInstrumenty.Name = "cbInstrumenty";
            this.cbInstrumenty.Size = new System.Drawing.Size(121, 21);
            this.cbInstrumenty.TabIndex = 0;
            this.cbInstrumenty.SelectedIndexChanged += new System.EventHandler(this.cbInstrumenty_SelectedIndexChanged);
            // 
            // cbDzwieki
            // 
            this.cbDzwieki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDzwieki.FormattingEnabled = true;
            this.cbDzwieki.Location = new System.Drawing.Point(7, 79);
            this.cbDzwieki.Name = "cbDzwieki";
            this.cbDzwieki.Size = new System.Drawing.Size(46, 21);
            this.cbDzwieki.TabIndex = 1;
            this.cbDzwieki.SelectedIndexChanged += new System.EventHandler(this.cbDzwieki_SelectedIndexChanged);
            // 
            // btnPrzegladaj
            // 
            this.btnPrzegladaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrzegladaj.Location = new System.Drawing.Point(657, 78);
            this.btnPrzegladaj.Name = "btnPrzegladaj";
            this.btnPrzegladaj.Size = new System.Drawing.Size(27, 21);
            this.btnPrzegladaj.TabIndex = 2;
            this.btnPrzegladaj.Text = "...";
            this.btnPrzegladaj.UseVisualStyleBackColor = true;
            this.btnPrzegladaj.Click += new System.EventHandler(this.btnPrzegladaj_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezka.Location = new System.Drawing.Point(76, 80);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.Size = new System.Drawing.Size(562, 20);
            this.tbSciezka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dźwięki";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Instrumenty";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZapisz.Location = new System.Drawing.Point(609, 110);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 30);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 152);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.btnPrzegladaj);
            this.Controls.Add(this.cbDzwieki);
            this.Controls.Add(this.cbInstrumenty);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 191);
            this.MinimumSize = new System.Drawing.Size(735, 191);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dźwięki";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInstrumenty;
        private System.Windows.Forms.ComboBox cbDzwieki;
        private System.Windows.Forms.Button btnPrzegladaj;
        private System.Windows.Forms.TextBox tbSciezka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnZapisz;
    }
}