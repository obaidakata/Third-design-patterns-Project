namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
     partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelCheckIns = new System.Windows.Forms.Label();
            this.buttonCheckinFeature = new System.Windows.Forms.Button();
            this.buttonFaceLikerFeature = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxBirthday = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxProfileImage = new A21_Ex01_Amit_312346901_Obaide_318970290.PicturesBoxChangeSizeProxy();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SetteingsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(2, 193);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(290, 73);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(2, 55);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(290, 211);
            this.listBoxFriends.TabIndex = 3;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(2, 55);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(290, 211);
            this.listBoxPosts.TabIndex = 4;
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.Location = new System.Drawing.Point(2, 55);
            this.listBoxCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(291, 211);
            this.listBoxCheckIn.TabIndex = 5;
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFriends.Location = new System.Drawing.Point(87, 16);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(120, 20);
            this.labelFriends.TabIndex = 6;
            this.labelFriends.Text = "Fetch Friends";
            this.labelFriends.Click += new System.EventHandler(this.labelFriends_Click);
            // 
            // labelPosts
            // 
            this.labelPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPosts.Location = new System.Drawing.Point(94, 16);
            this.labelPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(105, 20);
            this.labelPosts.TabIndex = 7;
            this.labelPosts.Text = "Fetch Posts";
            this.labelPosts.Click += new System.EventHandler(this.labelPosts_Click);
            // 
            // labelCheckIns
            // 
            this.labelCheckIns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCheckIns.AutoSize = true;
            this.labelCheckIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIns.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCheckIns.Location = new System.Drawing.Point(80, 16);
            this.labelCheckIns.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheckIns.Name = "labelCheckIns";
            this.labelCheckIns.Size = new System.Drawing.Size(135, 20);
            this.labelCheckIns.TabIndex = 8;
            this.labelCheckIns.Text = "Fetch CheckIns";
            this.labelCheckIns.Click += new System.EventHandler(this.labelCheckIns_Click);
            // 
            // buttonCheckinFeature
            // 
            this.buttonCheckinFeature.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCheckinFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckinFeature.Location = new System.Drawing.Point(2, 2);
            this.buttonCheckinFeature.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckinFeature.Name = "buttonCheckinFeature";
            this.buttonCheckinFeature.Size = new System.Drawing.Size(291, 88);
            this.buttonCheckinFeature.TabIndex = 9;
            this.buttonCheckinFeature.Text = "Checkin recommendation";
            this.buttonCheckinFeature.UseVisualStyleBackColor = true;
            this.buttonCheckinFeature.Click += new System.EventHandler(this.buttonCheckinFeature_Click);
            // 
            // buttonFaceLikerFeature
            // 
            this.buttonFaceLikerFeature.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFaceLikerFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaceLikerFeature.Location = new System.Drawing.Point(2, 94);
            this.buttonFaceLikerFeature.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFaceLikerFeature.Name = "buttonFaceLikerFeature";
            this.buttonFaceLikerFeature.Size = new System.Drawing.Size(291, 88);
            this.buttonFaceLikerFeature.TabIndex = 10;
            this.buttonFaceLikerFeature.Text = "FaceLikers";
            this.buttonFaceLikerFeature.UseVisualStyleBackColor = true;
            this.buttonFaceLikerFeature.Click += new System.EventHandler(this.buttonFriendRaterFeature_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 548);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.AutoScroll = true;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.Controls.Add(this.pictureBoxBirthday, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.pictureBoxEmail, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.pictureBoxUserName, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.birthdayTextBox, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.emailTextBox, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(302, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(296, 270);
            this.tableLayoutPanel8.TabIndex = 17;
            // 
            // pictureBoxBirthday
            // 
            this.pictureBoxBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBirthday.Image = global::A21_Ex01_Amit_312346901_Obaide_318970290.Properties.Resources.birthday;
            this.pictureBoxBirthday.Location = new System.Drawing.Point(2, 182);
            this.pictureBoxBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBirthday.Name = "pictureBoxBirthday";
            this.pictureBoxBirthday.Size = new System.Drawing.Size(55, 86);
            this.pictureBoxBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBirthday.TabIndex = 20;
            this.pictureBoxBirthday.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEmail.Image = global::A21_Ex01_Amit_312346901_Obaide_318970290.Properties.Resources.eMail;
            this.pictureBoxEmail.Location = new System.Drawing.Point(2, 92);
            this.pictureBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(55, 86);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 19;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxUserName
            // 
            this.pictureBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUserName.Image = global::A21_Ex01_Amit_312346901_Obaide_318970290.Properties.Resources.id;
            this.pictureBoxUserName.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserName.Name = "pictureBoxUserName";
            this.pictureBoxUserName.Size = new System.Drawing.Size(55, 86);
            this.pictureBoxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserName.TabIndex = 16;
            this.pictureBoxUserName.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.Location = new System.Drawing.Point(62, 35);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(231, 19);
            this.nameTextBox.TabIndex = 21;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdayTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.birthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.birthdayTextBox.Location = new System.Drawing.Point(62, 215);
            this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(231, 19);
            this.birthdayTextBox.TabIndex = 22;
            this.birthdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdayTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.birthdayTextBox_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.emailTextBox.Location = new System.Drawing.Point(62, 125);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(231, 19);
            this.emailTextBox.TabIndex = 23;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonLogout, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxProfileImage, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 268);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProfileImage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxProfileImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(79, 44);
            this.pictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(135, 103);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 2;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.buttonCheckinFeature, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonFaceLikerFeature, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.SetteingsButton, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(603, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.49054F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.49054F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.01893F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(295, 268);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // SetteingsButton
            // 
            this.SetteingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetteingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SetteingsButton.Location = new System.Drawing.Point(3, 193);
            this.SetteingsButton.Name = "SetteingsButton";
            this.SetteingsButton.Size = new System.Drawing.Size(289, 72);
            this.SetteingsButton.TabIndex = 11;
            this.SetteingsButton.Text = "Setteings";
            this.SetteingsButton.UseVisualStyleBackColor = true;
            this.SetteingsButton.Click += new System.EventHandler(this.SetteingsButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.labelFriends, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.listBoxFriends, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(294, 268);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.labelPosts, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.listBoxPosts, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(303, 277);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(294, 268);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.labelCheckIns, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.listBoxCheckIn, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(603, 277);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(295, 268);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(915, 575);
            this.Name = "FormMain";
            this.Text = "My desktop App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.Button buttonLogout;
          private PicturesBoxChangeSizeProxy pictureBoxProfileImage;
          private System.Windows.Forms.ListBox listBoxFriends;
          private System.Windows.Forms.ListBox listBoxPosts;
          private System.Windows.Forms.ListBox listBoxCheckIn;
          private System.Windows.Forms.Label labelFriends;
          private System.Windows.Forms.Label labelPosts;
          private System.Windows.Forms.Label labelCheckIns;
          private System.Windows.Forms.Button buttonCheckinFeature;
          private System.Windows.Forms.Button buttonFaceLikerFeature;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
          private System.Windows.Forms.PictureBox pictureBoxUserName;
          private System.Windows.Forms.PictureBox pictureBoxBirthday;
          private System.Windows.Forms.PictureBox pictureBoxEmail;
          private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.BindingSource userBindingSource;
          private System.Windows.Forms.TextBox birthdayTextBox;
          private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button SetteingsButton;
    }
}