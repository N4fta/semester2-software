
namespace StreamingMusicApp
{
    partial class mainForm
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
            tbControl = new System.Windows.Forms.TabControl();
            tbPgLogin = new System.Windows.Forms.TabPage();
            tbLoginPassword = new System.Windows.Forms.MaskedTextBox();
            btShowAllUsers = new System.Windows.Forms.Button();
            ckbRegister = new System.Windows.Forms.CheckBox();
            lblLoginAddress = new System.Windows.Forms.Label();
            lblLoginEmail = new System.Windows.Forms.Label();
            tbLoginAddress = new System.Windows.Forms.TextBox();
            tbLoginEmail = new System.Windows.Forms.TextBox();
            lblLoginPassword = new System.Windows.Forms.Label();
            lblLoginUsername = new System.Windows.Forms.Label();
            btLogin = new System.Windows.Forms.Button();
            btRegister = new System.Windows.Forms.Button();
            tbLoginUsername = new System.Windows.Forms.TextBox();
            tbPgUserInfo = new System.Windows.Forms.TabPage();
            btLogout = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tbUserFavourites = new System.Windows.Forms.TextBox();
            tbUserAddress = new System.Windows.Forms.TextBox();
            tbUserEmail = new System.Windows.Forms.TextBox();
            tbUserName = new System.Windows.Forms.TextBox();
            tbPgSongs = new System.Windows.Forms.TabPage();
            cbSongsPlaylist = new System.Windows.Forms.ComboBox();
            btSongsSetToPlaylist = new System.Windows.Forms.Button();
            lblSongsDuration = new System.Windows.Forms.Label();
            lblSongsArtist = new System.Windows.Forms.Label();
            lblSongsTitle = new System.Windows.Forms.Label();
            cbGenreFilter = new System.Windows.Forms.ComboBox();
            lblNumberOfSongs = new System.Windows.Forms.Label();
            lbSongs = new System.Windows.Forms.ListBox();
            cbPlaylistFilter = new System.Windows.Forms.ComboBox();
            tbPgAddSong = new System.Windows.Forms.TabPage();
            cbAddSongGenre = new System.Windows.Forms.ComboBox();
            btAddSong = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nupAddSongDuration = new System.Windows.Forms.NumericUpDown();
            tbAddSongTitle = new System.Windows.Forms.TextBox();
            tbAddSongArtist = new System.Windows.Forms.TextBox();
            lblAppName = new System.Windows.Forms.Label();
            btAddPlaylist = new System.Windows.Forms.Button();
            tbAddPlaylistName = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            tbControl.SuspendLayout();
            tbPgLogin.SuspendLayout();
            tbPgUserInfo.SuspendLayout();
            tbPgSongs.SuspendLayout();
            tbPgAddSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAddSongDuration).BeginInit();
            SuspendLayout();
            // 
            // tbControl
            // 
            tbControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbControl.Controls.Add(tbPgLogin);
            tbControl.Controls.Add(tbPgUserInfo);
            tbControl.Controls.Add(tbPgSongs);
            tbControl.Controls.Add(tbPgAddSong);
            tbControl.Location = new System.Drawing.Point(12, 42);
            tbControl.Name = "tbControl";
            tbControl.SelectedIndex = 0;
            tbControl.Size = new System.Drawing.Size(364, 484);
            tbControl.TabIndex = 0;
            tbControl.SelectedIndexChanged += cbPlaylistFilter_SelectedIndexChanged;
            // 
            // tbPgLogin
            // 
            tbPgLogin.Controls.Add(tbLoginPassword);
            tbPgLogin.Controls.Add(btShowAllUsers);
            tbPgLogin.Controls.Add(ckbRegister);
            tbPgLogin.Controls.Add(lblLoginAddress);
            tbPgLogin.Controls.Add(lblLoginEmail);
            tbPgLogin.Controls.Add(tbLoginAddress);
            tbPgLogin.Controls.Add(tbLoginEmail);
            tbPgLogin.Controls.Add(lblLoginPassword);
            tbPgLogin.Controls.Add(lblLoginUsername);
            tbPgLogin.Controls.Add(btLogin);
            tbPgLogin.Controls.Add(btRegister);
            tbPgLogin.Controls.Add(tbLoginUsername);
            tbPgLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbPgLogin.Location = new System.Drawing.Point(4, 24);
            tbPgLogin.Name = "tbPgLogin";
            tbPgLogin.Padding = new System.Windows.Forms.Padding(3);
            tbPgLogin.Size = new System.Drawing.Size(356, 456);
            tbPgLogin.TabIndex = 0;
            tbPgLogin.Text = "Login";
            tbPgLogin.UseVisualStyleBackColor = true;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLoginPassword.Location = new System.Drawing.Point(124, 126);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.PasswordChar = '*';
            tbLoginPassword.Size = new System.Drawing.Size(197, 25);
            tbLoginPassword.TabIndex = 13;
            tbLoginPassword.Text = "1234";
            // 
            // btShowAllUsers
            // 
            btShowAllUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btShowAllUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btShowAllUsers.Location = new System.Drawing.Point(6, 421);
            btShowAllUsers.Name = "btShowAllUsers";
            btShowAllUsers.Size = new System.Drawing.Size(90, 29);
            btShowAllUsers.TabIndex = 12;
            btShowAllUsers.Text = "All Users";
            btShowAllUsers.UseVisualStyleBackColor = true;
            btShowAllUsers.Click += btShowAllUsers_Click;
            // 
            // ckbRegister
            // 
            ckbRegister.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ckbRegister.AutoSize = true;
            ckbRegister.Location = new System.Drawing.Point(130, 180);
            ckbRegister.Name = "ckbRegister";
            ckbRegister.Size = new System.Drawing.Size(77, 23);
            ckbRegister.TabIndex = 10;
            ckbRegister.Text = "Register";
            ckbRegister.UseVisualStyleBackColor = true;
            ckbRegister.CheckedChanged += ckbRegister_CheckedChanged;
            // 
            // lblLoginAddress
            // 
            lblLoginAddress.AutoSize = true;
            lblLoginAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLoginAddress.Location = new System.Drawing.Point(45, 265);
            lblLoginAddress.Name = "lblLoginAddress";
            lblLoginAddress.Size = new System.Drawing.Size(58, 19);
            lblLoginAddress.TabIndex = 9;
            lblLoginAddress.Text = "Address";
            lblLoginAddress.Visible = false;
            // 
            // lblLoginEmail
            // 
            lblLoginEmail.AutoSize = true;
            lblLoginEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLoginEmail.Location = new System.Drawing.Point(45, 220);
            lblLoginEmail.Name = "lblLoginEmail";
            lblLoginEmail.Size = new System.Drawing.Size(41, 19);
            lblLoginEmail.TabIndex = 8;
            lblLoginEmail.Text = "Email";
            lblLoginEmail.Visible = false;
            // 
            // tbLoginAddress
            // 
            tbLoginAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLoginAddress.Location = new System.Drawing.Point(122, 262);
            tbLoginAddress.Name = "tbLoginAddress";
            tbLoginAddress.Size = new System.Drawing.Size(199, 25);
            tbLoginAddress.TabIndex = 7;
            tbLoginAddress.Visible = false;
            // 
            // tbLoginEmail
            // 
            tbLoginEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLoginEmail.Location = new System.Drawing.Point(122, 217);
            tbLoginEmail.Name = "tbLoginEmail";
            tbLoginEmail.Size = new System.Drawing.Size(199, 25);
            tbLoginEmail.TabIndex = 6;
            tbLoginEmail.Visible = false;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLoginPassword.Location = new System.Drawing.Point(45, 132);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new System.Drawing.Size(67, 19);
            lblLoginPassword.TabIndex = 5;
            lblLoginPassword.Text = "Password";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLoginUsername.Location = new System.Drawing.Point(45, 93);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new System.Drawing.Size(71, 19);
            lblLoginUsername.TabIndex = 4;
            lblLoginUsername.Text = "Username";
            // 
            // btLogin
            // 
            btLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btLogin.Location = new System.Drawing.Point(234, 175);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(81, 31);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btRegister
            // 
            btRegister.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btRegister.Location = new System.Drawing.Point(232, 304);
            btRegister.Name = "btRegister";
            btRegister.Size = new System.Drawing.Size(83, 31);
            btRegister.TabIndex = 2;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Visible = false;
            btRegister.Click += btRegister_Click;
            // 
            // tbLoginUsername
            // 
            tbLoginUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbLoginUsername.Location = new System.Drawing.Point(124, 90);
            tbLoginUsername.Name = "tbLoginUsername";
            tbLoginUsername.Size = new System.Drawing.Size(197, 25);
            tbLoginUsername.TabIndex = 0;
            tbLoginUsername.Text = "Test";
            // 
            // tbPgUserInfo
            // 
            tbPgUserInfo.Controls.Add(btLogout);
            tbPgUserInfo.Controls.Add(label9);
            tbPgUserInfo.Controls.Add(label8);
            tbPgUserInfo.Controls.Add(label7);
            tbPgUserInfo.Controls.Add(label6);
            tbPgUserInfo.Controls.Add(tbUserFavourites);
            tbPgUserInfo.Controls.Add(tbUserAddress);
            tbPgUserInfo.Controls.Add(tbUserEmail);
            tbPgUserInfo.Controls.Add(tbUserName);
            tbPgUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbPgUserInfo.Location = new System.Drawing.Point(4, 24);
            tbPgUserInfo.Name = "tbPgUserInfo";
            tbPgUserInfo.Padding = new System.Windows.Forms.Padding(3);
            tbPgUserInfo.Size = new System.Drawing.Size(356, 456);
            tbPgUserInfo.TabIndex = 1;
            tbPgUserInfo.Text = "UserInfo";
            tbPgUserInfo.UseVisualStyleBackColor = true;
            // 
            // btLogout
            // 
            btLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btLogout.Location = new System.Drawing.Point(257, 402);
            btLogout.Name = "btLogout";
            btLogout.Size = new System.Drawing.Size(81, 31);
            btLogout.TabIndex = 13;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(44, 148);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(65, 19);
            label9.TabIndex = 7;
            label9.Text = "Address: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(44, 187);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 19);
            label8.TabIndex = 6;
            label8.Text = "Favourites: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(44, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 19);
            label7.TabIndex = 5;
            label7.Text = "Name: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(44, 114);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 19);
            label6.TabIndex = 4;
            label6.Text = "Email: ";
            // 
            // tbUserFavourites
            // 
            tbUserFavourites.Location = new System.Drawing.Point(165, 184);
            tbUserFavourites.Name = "tbUserFavourites";
            tbUserFavourites.ReadOnly = true;
            tbUserFavourites.Size = new System.Drawing.Size(74, 25);
            tbUserFavourites.TabIndex = 3;
            // 
            // tbUserAddress
            // 
            tbUserAddress.Location = new System.Drawing.Point(165, 145);
            tbUserAddress.Name = "tbUserAddress";
            tbUserAddress.ReadOnly = true;
            tbUserAddress.Size = new System.Drawing.Size(113, 25);
            tbUserAddress.TabIndex = 2;
            // 
            // tbUserEmail
            // 
            tbUserEmail.Location = new System.Drawing.Point(165, 111);
            tbUserEmail.Name = "tbUserEmail";
            tbUserEmail.ReadOnly = true;
            tbUserEmail.Size = new System.Drawing.Size(113, 25);
            tbUserEmail.TabIndex = 1;
            // 
            // tbUserName
            // 
            tbUserName.Location = new System.Drawing.Point(165, 75);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new System.Drawing.Size(113, 25);
            tbUserName.TabIndex = 0;
            // 
            // tbPgSongs
            // 
            tbPgSongs.Controls.Add(cbSongsPlaylist);
            tbPgSongs.Controls.Add(btSongsSetToPlaylist);
            tbPgSongs.Controls.Add(lblSongsDuration);
            tbPgSongs.Controls.Add(lblSongsArtist);
            tbPgSongs.Controls.Add(lblSongsTitle);
            tbPgSongs.Controls.Add(cbGenreFilter);
            tbPgSongs.Controls.Add(lblNumberOfSongs);
            tbPgSongs.Controls.Add(lbSongs);
            tbPgSongs.Controls.Add(cbPlaylistFilter);
            tbPgSongs.Location = new System.Drawing.Point(4, 24);
            tbPgSongs.Name = "tbPgSongs";
            tbPgSongs.Padding = new System.Windows.Forms.Padding(3);
            tbPgSongs.Size = new System.Drawing.Size(356, 456);
            tbPgSongs.TabIndex = 2;
            tbPgSongs.Text = "Songs";
            tbPgSongs.UseVisualStyleBackColor = true;
            // 
            // cbSongsPlaylist
            // 
            cbSongsPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cbSongsPlaylist.FormattingEnabled = true;
            cbSongsPlaylist.Location = new System.Drawing.Point(185, 391);
            cbSongsPlaylist.Name = "cbSongsPlaylist";
            cbSongsPlaylist.Size = new System.Drawing.Size(117, 23);
            cbSongsPlaylist.TabIndex = 8;
            // 
            // btSongsSetToPlaylist
            // 
            btSongsSetToPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btSongsSetToPlaylist.Location = new System.Drawing.Point(307, 390);
            btSongsSetToPlaylist.Name = "btSongsSetToPlaylist";
            btSongsSetToPlaylist.Size = new System.Drawing.Size(40, 23);
            btSongsSetToPlaylist.TabIndex = 7;
            btSongsSetToPlaylist.Text = "Set";
            btSongsSetToPlaylist.UseVisualStyleBackColor = true;
            btSongsSetToPlaylist.Click += btSongsAddToPlaylist_Click;
            // 
            // lblSongsDuration
            // 
            lblSongsDuration.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSongsDuration.AutoSize = true;
            lblSongsDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSongsDuration.Location = new System.Drawing.Point(6, 428);
            lblSongsDuration.Name = "lblSongsDuration";
            lblSongsDuration.Size = new System.Drawing.Size(71, 19);
            lblSongsDuration.TabIndex = 6;
            lblSongsDuration.Text = "(Duration)";
            lblSongsDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSongsArtist
            // 
            lblSongsArtist.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSongsArtist.AutoSize = true;
            lblSongsArtist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSongsArtist.Location = new System.Drawing.Point(6, 390);
            lblSongsArtist.Name = "lblSongsArtist";
            lblSongsArtist.Size = new System.Drawing.Size(50, 19);
            lblSongsArtist.TabIndex = 5;
            lblSongsArtist.Text = "(Artist)";
            // 
            // lblSongsTitle
            // 
            lblSongsTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSongsTitle.AutoSize = true;
            lblSongsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSongsTitle.Location = new System.Drawing.Point(6, 409);
            lblSongsTitle.Name = "lblSongsTitle";
            lblSongsTitle.Size = new System.Drawing.Size(42, 19);
            lblSongsTitle.TabIndex = 4;
            lblSongsTitle.Text = "(Title)";
            // 
            // cbGenreFilter
            // 
            cbGenreFilter.FormattingEnabled = true;
            cbGenreFilter.Location = new System.Drawing.Point(150, 12);
            cbGenreFilter.Name = "cbGenreFilter";
            cbGenreFilter.Size = new System.Drawing.Size(121, 23);
            cbGenreFilter.TabIndex = 3;
            cbGenreFilter.SelectedIndexChanged += cbGenreFilter_SelectedIndexChanged;
            // 
            // lblNumberOfSongs
            // 
            lblNumberOfSongs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblNumberOfSongs.AutoSize = true;
            lblNumberOfSongs.Location = new System.Drawing.Point(296, 15);
            lblNumberOfSongs.Name = "lblNumberOfSongs";
            lblNumberOfSongs.Size = new System.Drawing.Size(51, 15);
            lblNumberOfSongs.TabIndex = 2;
            lblNumberOfSongs.Text = "Songs: 0";
            // 
            // lbSongs
            // 
            lbSongs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbSongs.FormattingEnabled = true;
            lbSongs.ItemHeight = 15;
            lbSongs.Location = new System.Drawing.Point(3, 41);
            lbSongs.Name = "lbSongs";
            lbSongs.Size = new System.Drawing.Size(344, 334);
            lbSongs.TabIndex = 1;
            lbSongs.SelectedIndexChanged += lbSongs_SelectedIndexChanged;
            // 
            // cbPlaylistFilter
            // 
            cbPlaylistFilter.FormattingEnabled = true;
            cbPlaylistFilter.Location = new System.Drawing.Point(6, 12);
            cbPlaylistFilter.Name = "cbPlaylistFilter";
            cbPlaylistFilter.Size = new System.Drawing.Size(121, 23);
            cbPlaylistFilter.TabIndex = 0;
            cbPlaylistFilter.SelectedIndexChanged += cbPlaylistFilter_SelectedIndexChanged;
            // 
            // tbPgAddSong
            // 
            tbPgAddSong.Controls.Add(label10);
            tbPgAddSong.Controls.Add(btAddPlaylist);
            tbPgAddSong.Controls.Add(tbAddPlaylistName);
            tbPgAddSong.Controls.Add(cbAddSongGenre);
            tbPgAddSong.Controls.Add(btAddSong);
            tbPgAddSong.Controls.Add(label5);
            tbPgAddSong.Controls.Add(label4);
            tbPgAddSong.Controls.Add(label3);
            tbPgAddSong.Controls.Add(label2);
            tbPgAddSong.Controls.Add(label1);
            tbPgAddSong.Controls.Add(nupAddSongDuration);
            tbPgAddSong.Controls.Add(tbAddSongTitle);
            tbPgAddSong.Controls.Add(tbAddSongArtist);
            tbPgAddSong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbPgAddSong.Location = new System.Drawing.Point(4, 24);
            tbPgAddSong.Name = "tbPgAddSong";
            tbPgAddSong.Padding = new System.Windows.Forms.Padding(3);
            tbPgAddSong.Size = new System.Drawing.Size(356, 456);
            tbPgAddSong.TabIndex = 3;
            tbPgAddSong.Text = "Add Song";
            tbPgAddSong.UseVisualStyleBackColor = true;
            // 
            // cbAddSongGenre
            // 
            cbAddSongGenre.FormattingEnabled = true;
            cbAddSongGenre.Location = new System.Drawing.Point(118, 177);
            cbAddSongGenre.Name = "cbAddSongGenre";
            cbAddSongGenre.Size = new System.Drawing.Size(121, 25);
            cbAddSongGenre.TabIndex = 11;
            // 
            // btAddSong
            // 
            btAddSong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btAddSong.Location = new System.Drawing.Point(232, 228);
            btAddSong.Name = "btAddSong";
            btAddSong.Size = new System.Drawing.Size(85, 32);
            btAddSong.TabIndex = 10;
            btAddSong.Text = "Add";
            btAddSong.UseVisualStyleBackColor = true;
            btAddSong.Click += btAddSong_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(211, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(28, 19);
            label5.TabIndex = 8;
            label5.Text = "sec";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(36, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 19);
            label4.TabIndex = 7;
            label4.Text = "Duration: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(36, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 19);
            label3.TabIndex = 6;
            label3.Text = "Title: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(36, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 19);
            label2.TabIndex = 5;
            label2.Text = "Artist: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(36, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 19);
            label1.TabIndex = 4;
            label1.Text = "Genre: ";
            // 
            // nupAddSongDuration
            // 
            nupAddSongDuration.Location = new System.Drawing.Point(123, 126);
            nupAddSongDuration.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nupAddSongDuration.Name = "nupAddSongDuration";
            nupAddSongDuration.Size = new System.Drawing.Size(82, 25);
            nupAddSongDuration.TabIndex = 3;
            nupAddSongDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAddSongTitle
            // 
            tbAddSongTitle.Location = new System.Drawing.Point(123, 35);
            tbAddSongTitle.Name = "tbAddSongTitle";
            tbAddSongTitle.Size = new System.Drawing.Size(194, 25);
            tbAddSongTitle.TabIndex = 2;
            // 
            // tbAddSongArtist
            // 
            tbAddSongArtist.Location = new System.Drawing.Point(123, 78);
            tbAddSongArtist.Name = "tbAddSongArtist";
            tbAddSongArtist.Size = new System.Drawing.Size(194, 25);
            tbAddSongArtist.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAppName.Location = new System.Drawing.Point(12, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(100, 30);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SongWell";
            // 
            // btAddPlaylist
            // 
            btAddPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btAddPlaylist.Location = new System.Drawing.Point(232, 367);
            btAddPlaylist.Name = "btAddPlaylist";
            btAddPlaylist.Size = new System.Drawing.Size(85, 32);
            btAddPlaylist.TabIndex = 13;
            btAddPlaylist.Text = "Add";
            btAddPlaylist.UseVisualStyleBackColor = true;
            btAddPlaylist.Click += btAddPlaylist_Click;
            // 
            // tbAddPlaylistName
            // 
            tbAddPlaylistName.Location = new System.Drawing.Point(134, 308);
            tbAddPlaylistName.Name = "tbAddPlaylistName";
            tbAddPlaylistName.Size = new System.Drawing.Size(183, 25);
            tbAddPlaylistName.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(36, 311);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(92, 19);
            label10.TabIndex = 14;
            label10.Text = "Playlist name:";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(388, 538);
            Controls.Add(lblAppName);
            Controls.Add(tbControl);
            Name = "mainForm";
            Text = "SongWell";
            tbControl.ResumeLayout(false);
            tbPgLogin.ResumeLayout(false);
            tbPgLogin.PerformLayout();
            tbPgUserInfo.ResumeLayout(false);
            tbPgUserInfo.PerformLayout();
            tbPgSongs.ResumeLayout(false);
            tbPgSongs.PerformLayout();
            tbPgAddSong.ResumeLayout(false);
            tbPgAddSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAddSongDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbPgLogin;
        private System.Windows.Forms.TabPage tbPgUserInfo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.TabPage tbPgSongs;
        private System.Windows.Forms.Label lblNumberOfSongs;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.ComboBox cbPlaylistFilter;
        private System.Windows.Forms.TabPage tbPgAddSong;
        private System.Windows.Forms.TextBox tbAddSongTitle;
        private System.Windows.Forms.TextBox tbAddSongArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupAddSongDuration;
        private System.Windows.Forms.ComboBox cbGenreFilter;
        private System.Windows.Forms.Button btAddSong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUserFavourites;
        private System.Windows.Forms.TextBox tbUserAddress;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Button btShowAllUsers;
        private System.Windows.Forms.CheckBox ckbRegister;
        private System.Windows.Forms.Label lblLoginAddress;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.TextBox tbLoginAddress;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.MaskedTextBox tbLoginPassword;
        private System.Windows.Forms.Label lblSongsDuration;
        private System.Windows.Forms.Label lblSongsArtist;
        private System.Windows.Forms.Label lblSongsTitle;
        private System.Windows.Forms.Button btSongsRemoveFromPlaylist;
        private System.Windows.Forms.ComboBox cbSongsPlaylist;
        private System.Windows.Forms.Button btSongsSetToPlaylist;
        private System.Windows.Forms.ComboBox cbAddSongGenre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAddPlaylist;
        private System.Windows.Forms.TextBox tbAddPlaylistName;
    }
}

