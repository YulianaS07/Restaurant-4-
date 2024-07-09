namespace WseiLab4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBoxGotoweDania = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataInZamowienie = new System.Windows.Forms.TextBox();
            this.dataInCena = new System.Windows.Forms.TextBox();
            this.dataInNrStolika = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxKuchnia = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.listBoxGotoweDania);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataInZamowienie);
            this.tabPage1.Controls.Add(this.dataInCena);
            this.tabPage1.Controls.Add(this.dataInNrStolika);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kelner";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gotowe dania";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(143, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(535, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "Oddaj ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBoxGotoweDania
            // 
            this.listBoxGotoweDania.FormattingEnabled = true;
            this.listBoxGotoweDania.ItemHeight = 20;
            this.listBoxGotoweDania.Location = new System.Drawing.Point(143, 159);
            this.listBoxGotoweDania.Name = "listBoxGotoweDania";
            this.listBoxGotoweDania.Size = new System.Drawing.Size(535, 184);
            this.listBoxGotoweDania.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zamówienie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr stolika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(535, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zamówienie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataInZamowienie
            // 
            this.dataInZamowienie.Location = new System.Drawing.Point(275, 41);
            this.dataInZamowienie.Name = "dataInZamowienie";
            this.dataInZamowienie.Size = new System.Drawing.Size(218, 26);
            this.dataInZamowienie.TabIndex = 2;
            // 
            // dataInCena
            // 
            this.dataInCena.Location = new System.Drawing.Point(516, 41);
            this.dataInCena.Name = "dataInCena";
            this.dataInCena.Size = new System.Drawing.Size(162, 26);
            this.dataInCena.TabIndex = 1;
            // 
            // dataInNrStolika
            // 
            this.dataInNrStolika.Location = new System.Drawing.Point(143, 41);
            this.dataInNrStolika.Name = "dataInNrStolika";
            this.dataInNrStolika.Size = new System.Drawing.Size(116, 26);
            this.dataInNrStolika.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.listBoxKuchnia);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kuchnia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(615, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Odbierz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxKuchnia
            // 
            this.listBoxKuchnia.FormattingEnabled = true;
            this.listBoxKuchnia.ItemHeight = 20;
            this.listBoxKuchnia.Location = new System.Drawing.Point(97, 39);
            this.listBoxKuchnia.Name = "listBoxKuchnia";
            this.listBoxKuchnia.Size = new System.Drawing.Size(615, 304);
            this.listBoxKuchnia.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lista zamówień";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dataInZamowienie;
        private System.Windows.Forms.TextBox dataInCena;
        private System.Windows.Forms.TextBox dataInNrStolika;
        private System.Windows.Forms.ListBox listBoxKuchnia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxGotoweDania;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

