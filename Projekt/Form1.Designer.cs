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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGraj
            // 
            this.btnGraj.Location = new System.Drawing.Point(298, 255);
            this.btnGraj.Name = "btnGraj";
            this.btnGraj.Size = new System.Drawing.Size(90, 29);
            this.btnGraj.TabIndex = 0;
            this.btnGraj.Text = "Graj";
            this.btnGraj.UseVisualStyleBackColor = true;
            this.btnGraj.Click += new System.EventHandler(this.btnGraj_Click);
            // 
            // btnDodajDźwięki
            // 
            this.btnDodajDźwięki.Location = new System.Drawing.Point(2, 255);
            this.btnDodajDźwięki.Name = "btnDodajDźwięki";
            this.btnDodajDźwięki.Size = new System.Drawing.Size(90, 29);
            this.btnDodajDźwięki.TabIndex = 1;
            this.btnDodajDźwięki.Text = "Dodaj dźwięki";
            this.btnDodajDźwięki.UseVisualStyleBackColor = true;
            this.btnDodajDźwięki.Click += new System.EventHandler(this.btnDodajDźwięki_Click);
            // 
            // listaInstrumentów
            // 
            this.listaInstrumentów.FormattingEnabled = true;
            this.listaInstrumentów.Location = new System.Drawing.Point(2, 46);
            this.listaInstrumentów.Name = "listaInstrumentów";
            this.listaInstrumentów.Size = new System.Drawing.Size(120, 124);
            this.listaInstrumentów.TabIndex = 2;
            this.listaInstrumentów.SelectedIndexChanged += new System.EventHandler(this.listaInstrumentów_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz instrumenty";
            // 
            // btnZapiszDzwieki
            // 
            this.btnZapiszDzwieki.Location = new System.Drawing.Point(98, 255);
            this.btnZapiszDzwieki.Name = "btnZapiszDzwieki";
            this.btnZapiszDzwieki.Size = new System.Drawing.Size(90, 29);
            this.btnZapiszDzwieki.TabIndex = 4;
            this.btnZapiszDzwieki.Text = "Zapisz dźwięki";
            this.btnZapiszDzwieki.UseVisualStyleBackColor = true;
            this.btnZapiszDzwieki.Click += new System.EventHandler(this.btnZapiszDzwieki_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dodaj melodię";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnZapiszDzwieki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaInstrumentów);
            this.Controls.Add(this.btnDodajDźwięki);
            this.Controls.Add(this.btnGraj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

