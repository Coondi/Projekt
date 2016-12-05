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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajDźwięki = new System.Windows.Forms.Button();
            this.listaInstrumentów = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Graj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDodajDźwięki
            // 
            this.btnDodajDźwięki.Location = new System.Drawing.Point(12, 214);
            this.btnDodajDźwięki.Name = "btnDodajDźwięki";
            this.btnDodajDźwięki.Size = new System.Drawing.Size(55, 55);
            this.btnDodajDźwięki.TabIndex = 1;
            this.btnDodajDźwięki.Text = "Dodaj dźwięki";
            this.btnDodajDźwięki.UseVisualStyleBackColor = true;
            this.btnDodajDźwięki.Click += new System.EventHandler(this.btnDodajDźwięki_Click);
            // 
            // listaInstrumentów
            // 
            this.listaInstrumentów.FormattingEnabled = true;
            this.listaInstrumentów.Location = new System.Drawing.Point(12, 46);
            this.listaInstrumentów.Name = "listaInstrumentów";
            this.listaInstrumentów.Size = new System.Drawing.Size(120, 124);
            this.listaInstrumentów.TabIndex = 2;
            this.listaInstrumentów.SelectedIndexChanged += new System.EventHandler(this.listaInstrumentów_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz instrumenty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaInstrumentów);
            this.Controls.Add(this.btnDodajDźwięki);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajDźwięki;
        private System.Windows.Forms.CheckedListBox listaInstrumentów;
        private System.Windows.Forms.Label label1;
    }
}

