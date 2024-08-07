namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            siirYazartxt = new TextBox();
            siirAditxt = new TextBox();
            satirSayisitxt = new TextBox();
            siiriBesteleyentxt = new TextBox();
            bestelendigiTarihtxt = new TextBox();
            button1 = new Button();
            listbox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "şiir yazarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "şiir adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 99);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "satır sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 136);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "şiiri besteleyen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 174);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 4;
            label5.Text = "bestelendiği tarih";
            // 
            // siirYazartxt
            // 
            siirYazartxt.Location = new Point(177, 19);
            siirYazartxt.Name = "siirYazartxt";
            siirYazartxt.Size = new Size(150, 31);
            siirYazartxt.TabIndex = 5;
            // 
            // siirAditxt
            // 
            siirAditxt.Location = new Point(177, 55);
            siirAditxt.Name = "siirAditxt";
            siirAditxt.Size = new Size(150, 31);
            siirAditxt.TabIndex = 6;
            // 
            // satirSayisitxt
            // 
            satirSayisitxt.Location = new Point(177, 93);
            satirSayisitxt.Name = "satirSayisitxt";
            satirSayisitxt.Size = new Size(150, 31);
            satirSayisitxt.TabIndex = 7;
            // 
            // siiriBesteleyentxt
            // 
            siiriBesteleyentxt.Location = new Point(177, 130);
            siiriBesteleyentxt.Name = "siiriBesteleyentxt";
            siiriBesteleyentxt.Size = new Size(150, 31);
            siiriBesteleyentxt.TabIndex = 8;
            // 
            // bestelendigiTarihtxt
            // 
            bestelendigiTarihtxt.Location = new Point(177, 171);
            bestelendigiTarihtxt.Name = "bestelendigiTarihtxt";
            bestelendigiTarihtxt.Size = new Size(150, 31);
            bestelendigiTarihtxt.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(346, 165);
            button1.Name = "button1";
            button1.Size = new Size(128, 37);
            button1.TabIndex = 10;
            button1.Text = "şiiri ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 25;
            listbox.Location = new Point(23, 209);
            listbox.Name = "listbox";
            listbox.Size = new Size(451, 254);
            listbox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(490, 481);
            Controls.Add(listbox);
            Controls.Add(button1);
            Controls.Add(bestelendigiTarihtxt);
            Controls.Add(siiriBesteleyentxt);
            Controls.Add(satirSayisitxt);
            Controls.Add(siirAditxt);
            Controls.Add(siirYazartxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox siirYazartxt;
        private TextBox siirAditxt;
        private TextBox satirSayisitxt;
        private TextBox siiriBesteleyentxt;
        private TextBox bestelendigiTarihtxt;
        private Button button1;
        private ListBox listbox;
    }
}
