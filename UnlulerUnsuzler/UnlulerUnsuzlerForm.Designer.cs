namespace UnlulerUnsuzler
{
    partial class UnlulerUnsuzlerForm
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
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bHesapla = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.tbSesli = new System.Windows.Forms.TextBox();
            this.tbSessiz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbKelime
            // 
            this.tbKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKelime.Location = new System.Drawing.Point(135, 90);
            this.tbKelime.Multiline = true;
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(504, 59);
            this.tbKelime.TabIndex = 0;
            this.tbKelime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(291, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelime Giriniz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sesliler : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(233, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sessizler : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(202, 164);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(166, 37);
            this.bHesapla.TabIndex = 6;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(440, 164);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(166, 37);
            this.bTemizle.TabIndex = 7;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // tbSesli
            // 
            this.tbSesli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSesli.ForeColor = System.Drawing.Color.OrangeRed;
            this.tbSesli.Location = new System.Drawing.Point(378, 240);
            this.tbSesli.Multiline = true;
            this.tbSesli.Name = "tbSesli";
            this.tbSesli.Size = new System.Drawing.Size(284, 35);
            this.tbSesli.TabIndex = 8;
            this.tbSesli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSessiz
            // 
            this.tbSessiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSessiz.ForeColor = System.Drawing.Color.Peru;
            this.tbSessiz.Location = new System.Drawing.Point(378, 305);
            this.tbSessiz.Multiline = true;
            this.tbSessiz.Name = "tbSessiz";
            this.tbSessiz.Size = new System.Drawing.Size(284, 36);
            this.tbSessiz.TabIndex = 9;
            this.tbSessiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UnlulerUnsuzlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(757, 382);
            this.Controls.Add(this.tbSessiz);
            this.Controls.Add(this.tbSesli);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKelime);
            this.Name = "UnlulerUnsuzlerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bHesapla;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.TextBox tbSesli;
        private System.Windows.Forms.TextBox tbSessiz;
    }
}

