﻿namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
     partial class FormFaceLikers
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonUnfriend = new System.Windows.Forms.Button();
            this.labelSortByLikes = new System.Windows.Forms.Label();
            this.listBoxSortFriendsList = new System.Windows.Forms.ListBox();
            this.labelTotalLikes = new System.Windows.Forms.Label();
            this.labelFirstLikedPhoto = new System.Windows.Forms.Label();
            this.labelLastLikedPhoto = new System.Windows.Forms.Label();
            this.labelMostLikedPhoto = new System.Windows.Forms.Label();
            this.labelLeastLikedPhoto = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLeastLikedPhoto = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLastLikedPhoto = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxMostLikedPhoto = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxFirstLikedPhoto = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            this.pictureBoxProfileImage = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastLikedPhoto)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastLikedPhoto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstLikedPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backButton.Location = new System.Drawing.Point(0, 330);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(735, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to main page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(42, 11);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(96, 20);
            this.labelUserName.TabIndex = 16;
            this.labelUserName.Text = "User name";
            // 
            // buttonUnfriend
            // 
            this.buttonUnfriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnfriend.Location = new System.Drawing.Point(182, 276);
            this.buttonUnfriend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnfriend.Name = "buttonUnfriend";
            this.buttonUnfriend.Size = new System.Drawing.Size(176, 52);
            this.buttonUnfriend.TabIndex = 24;
            this.buttonUnfriend.Text = "Unfriend";
            this.buttonUnfriend.UseVisualStyleBackColor = true;
            this.buttonUnfriend.Click += new System.EventHandler(this.buttonUnfriend_Click);
            // 
            // labelSortByLikes
            // 
            this.labelSortByLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelSortByLikes.Location = new System.Drawing.Point(2, 0);
            this.labelSortByLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSortByLikes.Name = "labelSortByLikes";
            this.labelSortByLikes.Size = new System.Drawing.Size(152, 20);
            this.labelSortByLikes.TabIndex = 28;
            this.labelSortByLikes.Text = "Sort by likes";
            // 
            // listBoxSortFriendsList
            // 
            this.listBoxSortFriendsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSortFriendsList.FormattingEnabled = true;
            this.listBoxSortFriendsList.Location = new System.Drawing.Point(2, 26);
            this.listBoxSortFriendsList.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSortFriendsList.Name = "listBoxSortFriendsList";
            this.listBoxSortFriendsList.Size = new System.Drawing.Size(188, 302);
            this.listBoxSortFriendsList.TabIndex = 29;
            this.listBoxSortFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxSortFriendsList_SelectedIndexChanged);
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.Location = new System.Drawing.Point(186, 13);
            this.labelTotalLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new System.Drawing.Size(167, 17);
            this.labelTotalLikes.TabIndex = 39;
            this.labelTotalLikes.Text = "Total likes ";
            // 
            // labelFirstLikedPhoto
            // 
            this.labelFirstLikedPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstLikedPhoto.Location = new System.Drawing.Point(2, 0);
            this.labelFirstLikedPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstLikedPhoto.Name = "labelFirstLikedPhoto";
            this.labelFirstLikedPhoto.Size = new System.Drawing.Size(172, 23);
            this.labelFirstLikedPhoto.TabIndex = 41;
            this.labelFirstLikedPhoto.Text = "First liked photo";
            // 
            // labelLastLikedPhoto
            // 
            this.labelLastLikedPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastLikedPhoto.Location = new System.Drawing.Point(2, 0);
            this.labelLastLikedPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastLikedPhoto.Name = "labelLastLikedPhoto";
            this.labelLastLikedPhoto.Size = new System.Drawing.Size(172, 23);
            this.labelLastLikedPhoto.TabIndex = 42;
            this.labelLastLikedPhoto.Text = "Last liked photo";
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMostLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.Location = new System.Drawing.Point(2, 0);
            this.labelMostLikedPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new System.Drawing.Size(172, 25);
            this.labelMostLikedPhoto.TabIndex = 43;
            this.labelMostLikedPhoto.Text = "Most liked photo";
            // 
            // labelLeastLikedPhoto
            // 
            this.labelLeastLikedPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeastLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeastLikedPhoto.Location = new System.Drawing.Point(2, 0);
            this.labelLeastLikedPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeastLikedPhoto.Name = "labelLeastLikedPhoto";
            this.labelLeastLikedPhoto.Size = new System.Drawing.Size(172, 25);
            this.labelLeastLikedPhoto.TabIndex = 44;
            this.labelLeastLikedPhoto.Text = "Least liked photo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(735, 330);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 52;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelSortByLikes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxSortFriendsList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.506053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.49395F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonUnfriend, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelUserName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalLikes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxProfileImage, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 330);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.labelLeastLikedPhoto, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxLeastLikedPhoto, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(362, 159);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.41379F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.5862F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(176, 113);
            this.tableLayoutPanel6.TabIndex = 53;
            // 
            // pictureBoxLeastLikedPhoto
            // 
            this.pictureBoxLeastLikedPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLeastLikedPhoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxLeastLikedPhoto.Location = new System.Drawing.Point(34, 39);
            this.pictureBoxLeastLikedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLeastLikedPhoto.Name = "pictureBoxLeastLikedPhoto";
            this.pictureBoxLeastLikedPhoto.Size = new System.Drawing.Size(107, 60);
            this.pictureBoxLeastLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeastLikedPhoto.TabIndex = 51;
            this.pictureBoxLeastLikedPhoto.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelLastLikedPhoto, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxLastLikedPhoto, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(362, 45);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.01911F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.98089F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(176, 110);
            this.tableLayoutPanel5.TabIndex = 53;
            // 
            // pictureBoxLastLikedPhoto
            // 
            this.pictureBoxLastLikedPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLastLikedPhoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxLastLikedPhoto.Location = new System.Drawing.Point(34, 36);
            this.pictureBoxLastLikedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLastLikedPhoto.Name = "pictureBoxLastLikedPhoto";
            this.pictureBoxLastLikedPhoto.Size = new System.Drawing.Size(107, 60);
            this.pictureBoxLastLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLastLikedPhoto.TabIndex = 50;
            this.pictureBoxLastLikedPhoto.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelMostLikedPhoto, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxMostLikedPhoto, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(182, 159);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.41379F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.5862F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(176, 113);
            this.tableLayoutPanel4.TabIndex = 53;
            // 
            // pictureBoxMostLikedPhoto
            // 
            this.pictureBoxMostLikedPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMostLikedPhoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(34, 39);
            this.pictureBoxMostLikedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
            this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(107, 60);
            this.pictureBoxMostLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLikedPhoto.TabIndex = 49;
            this.pictureBoxMostLikedPhoto.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelFirstLikedPhoto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxFirstLikedPhoto, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(182, 45);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.01911F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.98089F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 110);
            this.tableLayoutPanel3.TabIndex = 40;
            // 
            // pictureBoxFirstLikedPhoto
            // 
            this.pictureBoxFirstLikedPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxFirstLikedPhoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxFirstLikedPhoto.Location = new System.Drawing.Point(34, 36);
            this.pictureBoxFirstLikedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFirstLikedPhoto.Name = "pictureBoxFirstLikedPhoto";
            this.pictureBoxFirstLikedPhoto.Size = new System.Drawing.Size(107, 60);
            this.pictureBoxFirstLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirstLikedPhoto.TabIndex = 48;
            this.pictureBoxFirstLikedPhoto.TabStop = false;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProfileImage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(36, 70);
            this.pictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(107, 60);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 17;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // FormFaceLikers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 370);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(749, 403);
            this.Name = "FormFaceLikers";
            this.Text = "FormFriendRater";
            this.Shown += new System.EventHandler(this.FormFaceLikers_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastLikedPhoto)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastLikedPhoto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstLikedPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button backButton;
          private System.Windows.Forms.Label labelUserName;
          private PicturesBoxChangeSizeProxy pictureBoxProfileImage;
          private System.Windows.Forms.Button buttonUnfriend;
          private System.Windows.Forms.Label labelSortByLikes;
          private System.Windows.Forms.ListBox listBoxSortFriendsList;
          private System.Windows.Forms.Label labelTotalLikes;
          private System.Windows.Forms.Label labelFirstLikedPhoto;
          private System.Windows.Forms.Label labelLastLikedPhoto;
          private System.Windows.Forms.Label labelMostLikedPhoto;
          private System.Windows.Forms.Label labelLeastLikedPhoto;
          private PicturesBoxChangeSizeProxy pictureBoxFirstLikedPhoto;
          private PicturesBoxChangeSizeProxy pictureBoxMostLikedPhoto;
          private PicturesBoxChangeSizeProxy pictureBoxLastLikedPhoto;
          private PicturesBoxChangeSizeProxy pictureBoxLeastLikedPhoto;
          private System.Windows.Forms.SplitContainer splitContainer1;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
     }
}