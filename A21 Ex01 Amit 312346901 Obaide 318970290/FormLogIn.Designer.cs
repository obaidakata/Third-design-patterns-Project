namespace FaceLikers
{
     partial class FormLogIn
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
               if(disposing && (components != null))
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
               this.buttonLogin = new BlinkButton();
               this.SuspendLayout();
               // 
               // buttonLogin
               // 
               this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogin.Location = new System.Drawing.Point(238, 278);
               this.buttonLogin.Name = "buttonLogin";
               this.buttonLogin.Size = new System.Drawing.Size(387, 114);
               this.buttonLogin.TabIndex = 2;
               this.buttonLogin.Text = "Login";
               this.buttonLogin.UseVisualStyleBackColor = false;
               this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // FormLogIn
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(951, 709);
               this.Controls.Add(this.buttonLogin);
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.MinimumSize = new System.Drawing.Size(964, 739);
               this.Name = "FormLogIn";
               this.Text = "FormLogIn";
               this.ResumeLayout(false);

          }

          #endregion

          private BlinkButton buttonLogin;
     }
}