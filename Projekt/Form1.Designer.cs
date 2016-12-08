namespace Projekt
{
    partial class Form1
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
            this.btnGraj = new System.Windows.Forms.Button();
            this.btnDodajDźwięki = new System.Windows.Forms.Button();
            this.listaInstrumentów = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZapiszDzwieki = new System.Windows.Forms.Button();
            this.tbMelodia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGraj
            // 
            this.btnGraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraj.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGraj.Location = new System.Drawing.Point(442, 219);
            this.btnGraj.Name = "btnGraj";
            this.btnGraj.Size = new System.Drawing.Size(60, 60);
            this.btnGraj.TabIndex = 0;
            this.btnGraj.Text = "Graj";
            this.btnGraj.UseVisualStyleBackColor = false;
            this.btnGraj.Click += new System.EventHandler(this.btnGraj_Click);
            // 
            // btnDodajDźwięki
            // 
            this.btnDodajDźwięki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajDźwięki.Location = new System.Drawing.Point(2, 239);
            this.btnDodajDźwięki.Name = "btnDodajDźwięki";
            this.btnDodajDźwięki.Size = new System.Drawing.Size(90, 40);
            this.btnDodajDźwięki.TabIndex = 1;
            this.btnDodajDźwięki.Text = "Dodaj dźwięki";
            this.btnDodajDźwięki.UseVisualStyleBackColor = true;
            this.btnDodajDźwięki.Click += new System.EventHandler(this.btnDodajDźwięki_Click);
            // 
            // listaInstrumentów
            // 
            this.listaInstrumentów.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listaInstrumentów.FormattingEnabled = true;
            this.listaInstrumentów.Location = new System.Drawing.Point(5, 25);
            this.listaInstrumentów.Name = "listaInstrumentów";
            this.listaInstrumentów.Size = new System.Drawing.Size(120, 169);
            this.listaInstrumentów.TabIndex = 2;
            this.listaInstrumentów.SelectedIndexChanged += new System.EventHandler(this.listaInstrumentów_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz instrumenty";
            // 
            // btnZapiszDzwieki
            // 
            this.btnZapiszDzwieki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZapiszDzwieki.Location = new System.Drawing.Point(98, 239);
            this.btnZapiszDzwieki.Name = "btnZapiszDzwieki";
            this.btnZapiszDzwieki.Size = new System.Drawing.Size(90, 40);
            this.btnZapiszDzwieki.TabIndex = 4;
            this.btnZapiszDzwieki.Text = "Zapisz dźwięki";
            this.btnZapiszDzwieki.UseVisualStyleBackColor = true;
            this.btnZapiszDzwieki.Click += new System.EventHandler(this.btnZapiszDzwieki_Click);
            // 
            // tbMelodia
            // 
            this.tbMelodia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMelodia.Location = new System.Drawing.Point(134, 25);
            this.tbMelodia.Multiline = true;
            this.tbMelodia.Name = "tbMelodia";
            this.tbMelodia.Size = new System.Drawing.Size(370, 57);
            this.tbMelodia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dodaj melodię";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uwaga: Dźwięk C2 jest użyty w programie jako Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMelodia);
            this.Controls.Add(this.btnZapiszDzwieki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaInstrumentów);
            this.Controls.Add(this.btnDodajDźwięki);
            this.Controls.Add(this.btnGraj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 330);
            this.MinimumSize = new System.Drawing.Size(530, 330);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orkiestra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraj;
        private System.Windows.Forms.Button btnDodajDźwięki;
        private System.Windows.Forms.CheckedListBox listaInstrumentów;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZapiszDzwieki;
        private System.Windows.Forms.TextBox tbMelodia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

