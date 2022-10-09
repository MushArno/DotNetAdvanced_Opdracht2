namespace Oefening3
{
    partial class CurrencyConvertor
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
            this.TextEuro = new System.Windows.Forms.TextBox();
            this.LabelEuro = new System.Windows.Forms.Label();
            this.LabelPound = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelFrank = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelRupee = new System.Windows.Forms.Label();
            this.TextRupee = new System.Windows.Forms.TextBox();
            this.LabelYen = new System.Windows.Forms.Label();
            this.TextYen = new System.Windows.Forms.TextBox();
            this.LabelDollar = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextEuro
            // 
            this.TextEuro.Location = new System.Drawing.Point(12, 41);
            this.TextEuro.Name = "TextEuro";
            this.TextEuro.Size = new System.Drawing.Size(146, 23);
            this.TextEuro.TabIndex = 0;
            // 
            // LabelEuro
            // 
            this.LabelEuro.AutoSize = true;
            this.LabelEuro.Location = new System.Drawing.Point(12, 23);
            this.LabelEuro.Name = "LabelEuro";
            this.LabelEuro.Size = new System.Drawing.Size(31, 15);
            this.LabelEuro.TabIndex = 1;
            this.LabelEuro.Text = "Euro";
            // 
            // LabelPound
            // 
            this.LabelPound.AutoSize = true;
            this.LabelPound.Location = new System.Drawing.Point(12, 94);
            this.LabelPound.Name = "LabelPound";
            this.LabelPound.Size = new System.Drawing.Size(78, 15);
            this.LabelPound.TabIndex = 3;
            this.LabelPound.Text = "British Pound";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 2;
            // 
            // LabelFrank
            // 
            this.LabelFrank.AutoSize = true;
            this.LabelFrank.Location = new System.Drawing.Point(12, 170);
            this.LabelFrank.Name = "LabelFrank";
            this.LabelFrank.Size = new System.Drawing.Size(82, 15);
            this.LabelFrank.TabIndex = 5;
            this.LabelFrank.Text = "Swedish Frank";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 4;
            // 
            // LabelRupee
            // 
            this.LabelRupee.AutoSize = true;
            this.LabelRupee.Location = new System.Drawing.Point(12, 244);
            this.LabelRupee.Name = "LabelRupee";
            this.LabelRupee.Size = new System.Drawing.Size(76, 15);
            this.LabelRupee.TabIndex = 7;
            this.LabelRupee.Text = "Indian Rupee";
            // 
            // TextRupee
            // 
            this.TextRupee.Location = new System.Drawing.Point(12, 262);
            this.TextRupee.Name = "TextRupee";
            this.TextRupee.Size = new System.Drawing.Size(146, 23);
            this.TextRupee.TabIndex = 6;
            // 
            // LabelYen
            // 
            this.LabelYen.AutoSize = true;
            this.LabelYen.Location = new System.Drawing.Point(12, 319);
            this.LabelYen.Name = "LabelYen";
            this.LabelYen.Size = new System.Drawing.Size(76, 15);
            this.LabelYen.TabIndex = 9;
            this.LabelYen.Text = "Japanese Yen";
            // 
            // TextYen
            // 
            this.TextYen.Location = new System.Drawing.Point(12, 337);
            this.TextYen.Name = "TextYen";
            this.TextYen.Size = new System.Drawing.Size(146, 23);
            this.TextYen.TabIndex = 8;
            // 
            // LabelDollar
            // 
            this.LabelDollar.AutoSize = true;
            this.LabelDollar.Location = new System.Drawing.Point(239, 319);
            this.LabelDollar.Name = "LabelDollar";
            this.LabelDollar.Size = new System.Drawing.Size(55, 15);
            this.LabelDollar.TabIndex = 11;
            this.LabelDollar.Text = "US Dollar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(239, 337);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 23);
            this.textBox5.TabIndex = 10;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(443, 336);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // CurrencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.LabelDollar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.LabelYen);
            this.Controls.Add(this.TextYen);
            this.Controls.Add(this.LabelRupee);
            this.Controls.Add(this.TextRupee);
            this.Controls.Add(this.LabelFrank);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LabelPound);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelEuro);
            this.Controls.Add(this.TextEuro);
            this.Name = "CurrencyConvertor";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextEuro;
        private Label LabelEuro;
        private Label LabelPound;
        private TextBox textBox1;
        private Label LabelFrank;
        private TextBox textBox2;
        private Label LabelRupee;
        private TextBox TextRupee;
        private Label LabelYen;
        private TextBox TextYen;
        private Label LabelDollar;
        private TextBox textBox5;
        private Button btnConvert;
    }
}