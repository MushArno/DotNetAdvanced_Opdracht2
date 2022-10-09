namespace Oefening1
{
    partial class LaatHoren
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
            this.CheckBoxKoe = new System.Windows.Forms.CheckBox();
            this.CheckBoxSlang = new System.Windows.Forms.CheckBox();
            this.CheckBoxVarken = new System.Windows.Forms.CheckBox();
            this.btnLaatHoren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxKoe
            // 
            this.CheckBoxKoe.AutoSize = true;
            this.CheckBoxKoe.Location = new System.Drawing.Point(12, 12);
            this.CheckBoxKoe.Name = "CheckBoxKoe";
            this.CheckBoxKoe.Size = new System.Drawing.Size(46, 19);
            this.CheckBoxKoe.TabIndex = 0;
            this.CheckBoxKoe.Text = "Koe";
            this.CheckBoxKoe.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSlang
            // 
            this.CheckBoxSlang.AutoSize = true;
            this.CheckBoxSlang.Location = new System.Drawing.Point(12, 37);
            this.CheckBoxSlang.Name = "CheckBoxSlang";
            this.CheckBoxSlang.Size = new System.Drawing.Size(55, 19);
            this.CheckBoxSlang.TabIndex = 1;
            this.CheckBoxSlang.Text = "Slang";
            this.CheckBoxSlang.UseVisualStyleBackColor = true;
            // 
            // CheckBoxVarken
            // 
            this.CheckBoxVarken.AutoSize = true;
            this.CheckBoxVarken.Location = new System.Drawing.Point(12, 62);
            this.CheckBoxVarken.Name = "CheckBoxVarken";
            this.CheckBoxVarken.Size = new System.Drawing.Size(61, 19);
            this.CheckBoxVarken.TabIndex = 2;
            this.CheckBoxVarken.Text = "Varken";
            this.CheckBoxVarken.UseVisualStyleBackColor = true;
            // 
            // btnLaatHoren
            // 
            this.btnLaatHoren.Location = new System.Drawing.Point(64, 87);
            this.btnLaatHoren.Name = "btnLaatHoren";
            this.btnLaatHoren.Size = new System.Drawing.Size(75, 23);
            this.btnLaatHoren.TabIndex = 3;
            this.btnLaatHoren.Text = "Laat horen";
            this.btnLaatHoren.UseVisualStyleBackColor = true;
            this.btnLaatHoren.Click += new System.EventHandler(this.btnLaatHoren_Click);
            // 
            // LaatHoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 126);
            this.Controls.Add(this.btnLaatHoren);
            this.Controls.Add(this.CheckBoxVarken);
            this.Controls.Add(this.CheckBoxSlang);
            this.Controls.Add(this.CheckBoxKoe);
            this.Name = "LaatHoren";
            this.Text = "Laat horen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox CheckBoxKoe;
        private CheckBox CheckBoxSlang;
        private CheckBox CheckBoxVarken;
        private Button btnLaatHoren;
    }
}