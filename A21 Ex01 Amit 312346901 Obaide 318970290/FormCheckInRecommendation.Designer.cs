namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
     partial class FormCheckInRecommendation
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
            this.backButton = new System.Windows.Forms.Button();
            this.Groups = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.checkInLable = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.buttonsRow = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton.Location = new System.Drawing.Point(0, 613);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(500, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Groups
            // 
            this.Groups.AutoSize = true;
            this.Groups.Location = new System.Drawing.Point(61, 54);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(0, 13);
            this.Groups.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 33);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(10, 10);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(684, 615);
            this.webBrowser.TabIndex = 3;
            // 
            // checkInLable
            // 
            this.checkInLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkInLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInLable.Location = new System.Drawing.Point(0, 0);
            this.checkInLable.Name = "checkInLable";
            this.checkInLable.Size = new System.Drawing.Size(500, 29);
            this.checkInLable.TabIndex = 6;
            this.checkInLable.Text = "checkins";
            this.checkInLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxCheckIns);
            this.splitContainer1.Panel1.Controls.Add(this.backButton);
            this.splitContainer1.Panel1.Controls.Add(this.checkInLable);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonsRow);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(1188, 648);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 13;
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(0, 29);
            this.listBoxCheckIns.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(1990, 584);
            this.listBoxCheckIns.TabIndex = 7;
            this.listBoxCheckIns.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonsRow
            // 
            this.buttonsRow.ColumnCount = 1;
            this.buttonsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.buttonsRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsRow.Location = new System.Drawing.Point(0, 0);
            this.buttonsRow.Name = "buttonsRow";
            this.buttonsRow.RowCount = 1;
            this.buttonsRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsRow.Size = new System.Drawing.Size(684, 29);
            this.buttonsRow.TabIndex = 13;
            // 
            // FormCheckInRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1204, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Groups);
            this.MinimumSize = new System.Drawing.Size(1220, 479);
            this.Name = "FormCheckInRecommendation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckInForm";
            this.Shown += new System.EventHandler(this.FormCheckInRecommendation_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button backButton;
          private System.Windows.Forms.Label Groups;
          private System.Windows.Forms.WebBrowser webBrowser;
          private System.Windows.Forms.Label checkInLable;
          private System.Windows.Forms.SplitContainer splitContainer1;
          private System.Windows.Forms.TableLayoutPanel buttonsRow;
          private System.Windows.Forms.ListBox listBoxCheckIns;
     }
}