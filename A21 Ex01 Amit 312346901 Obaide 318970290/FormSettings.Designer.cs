namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    partial class FormSettings
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorLabel = new System.Windows.Forms.Label();
            this.currentBackColor = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.currentFontLabel = new System.Windows.Forms.Label();
            this.currentFont = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonColor.Location = new System.Drawing.Point(66, 172);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(184, 34);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "click me to pick new color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.colorLabel.Location = new System.Drawing.Point(62, 21);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(212, 20);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Current background color";
            // 
            // currentBackColor
            // 
            this.currentBackColor.Location = new System.Drawing.Point(66, 72);
            this.currentBackColor.Name = "currentBackColor";
            this.currentBackColor.Size = new System.Drawing.Size(184, 77);
            this.currentBackColor.TabIndex = 3;
            // 
            // buttonFont
            // 
            this.buttonFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFont.Location = new System.Drawing.Point(438, 172);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(184, 34);
            this.buttonFont.TabIndex = 4;
            this.buttonFont.Text = "click me to change the font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // currentFontLabel
            // 
            this.currentFontLabel.AutoSize = true;
            this.currentFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.currentFontLabel.Location = new System.Drawing.Point(448, 21);
            this.currentFontLabel.Name = "currentFontLabel";
            this.currentFontLabel.Size = new System.Drawing.Size(106, 20);
            this.currentFontLabel.TabIndex = 5;
            this.currentFontLabel.Text = "Current font";
            // 
            // currentFont
            // 
            this.currentFont.AutoSize = true;
            this.currentFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.currentFont.Location = new System.Drawing.Point(448, 72);
            this.currentFont.Name = "currentFont";
            this.currentFont.Size = new System.Drawing.Size(57, 20);
            this.currentFont.TabIndex = 6;
            this.currentFont.Text = "label2";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.resetButton.Location = new System.Drawing.Point(258, 296);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(186, 34);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.currentFont);
            this.Controls.Add(this.currentFontLabel);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.currentBackColor);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Panel currentBackColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Label currentFontLabel;
        private System.Windows.Forms.Label currentFont;
        private System.Windows.Forms.Button resetButton;
    }
}