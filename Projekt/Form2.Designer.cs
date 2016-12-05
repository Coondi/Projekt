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
            this.SuspendLayout();
            // 
            // cbInstrumenty
            // 
            this.cbInstrumenty.FormattingEnabled = true;
            this.cbInstrumenty.Location = new System.Drawing.Point(105, 33);
            this.cbInstrumenty.Name = "cbInstrumenty";
            this.cbInstrumenty.Size = new System.Drawing.Size(121, 21);
            this.cbInstrumenty.TabIndex = 0;
            this.cbInstrumenty.SelectedIndexChanged += new System.EventHandler(this.cbInstrumenty_SelectedIndexChanged);
            // 
            // cbDzwieki
            // 
            this.cbDzwieki.FormattingEnabled = true;
            this.cbDzwieki.Location = new System.Drawing.Point(12, 82);
            this.cbDzwieki.Name = "cbDzwieki";
            this.cbDzwieki.Size = new System.Drawing.Size(46, 21);
            this.cbDzwieki.TabIndex = 1;
            this.cbDzwieki.SelectedIndexChanged += new System.EventHandler(this.cbDzwieki_SelectedIndexChanged);
            // 
            // btnPrzegladaj
            // 
            this.btnPrzegladaj.Location = new System.Drawing.Point(572, 80);
            this.btnPrzegladaj.Name = "btnPrzegladaj";
            this.btnPrzegladaj.Size = new System.Drawing.Size(27, 23);
            this.btnPrzegladaj.TabIndex = 2;
            this.btnPrzegladaj.Text = "...";
            this.btnPrzegladaj.UseVisualStyleBackColor = true;
            this.btnPrzegladaj.Click += new System.EventHandler(this.btnPrzegladaj_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Location = new System.Drawing.Point(105, 83);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.Size = new System.Drawing.Size(448, 20);
            this.tbSciezka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dźwięki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Instrumenty";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.btnPrzegladaj);
            this.Controls.Add(this.cbDzwieki);
            this.Controls.Add(this.cbInstrumenty);
            this.MaximizeBox = false;
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
    }
}