using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StreamingMusicApp
{
    public partial class mainForm : Form
    {
        StreamingMusicService streamingMusicService;
        User activeUser;
        int savedPlaylistComboBoxIndex = 0;

        public mainForm()
        {
            InitializeComponent();
            const string APPNAME = "SongWell";
            this.Name = APPNAME;
            lblAppName.Text = APPNAME;
            streamingMusicService = new StreamingMusicService(APPNAME);

            tbControl.TabPages.Remove(tbPgUserInfo);
            tbControl.TabPages.Remove(tbPgSongs);
            tbControl.TabPages.Remove(tbPgAddSong);
            cbAddSongGenre.DataSource = Enum.GetNames(typeof(Genre));


            /* Hardcoded (for testing) */
            streamingMusicService.AddUser("Test", "1234", "test@test.com", "123 test Avenue, test, test");
            Genre temp = new Genre();
            streamingMusicService.AddSong("qwerty", "ABBA", 180, temp);
            streamingMusicService.AddSong("sadf", "ggg", 120, temp + 2);
            streamingMusicService.AddSong("light", "Asap", 0, temp + 3);

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            User user = streamingMusicService.GetUser(tbLoginUsername.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid Username");
                return;
            }

            if (user.CheckPassword(tbLoginPassword.Text))
            {
                tbControl.TabPages.Remove(tbPgLogin);
                LoginWith(user);
                tbControl.TabPages.Insert(0, tbPgUserInfo);
                tbControl.TabPages.Insert(1, tbPgSongs);
                tbControl.TabPages.Insert(2, tbPgAddSong);
                return;
            }
            MessageBox.Show("Wrong Password");


        }
        private void LoginWith(User user)
        {
            activeUser = user;
            //For testing
            user.AddSong(streamingMusicService.GetSong(1), "Favourites");

            // UserInfo tab
            tbPgUserInfo.Text = user.GetName();
            tbUserName.Text = user.GetName();
            tbUserEmail.Text = user.GetEmail();
            tbUserAddress.Text = user.GetAddress();
            tbUserFavourites.Text = user.GetPlaylist().Songs.Count.ToString();

            // Songs tab
            cbPlaylistFilter.DataSource = user.GetPlaylists();
            cbSongsPlaylist.DataSource = user.GetPlaylists().ToArray(); // So that combo boxes are not synced
            lblNumberOfSongs.Text = "Songs: " + user.GetPlaylist("Favourites").Songs.Count.ToString();
            cbGenreFilter.DataSource = Enum.GetNames(typeof(Genre));
        }

        private void btLogout_Click(object sender, EventArgs e)
        {

            tbControl.TabPages.Remove(tbPgAddSong);
            tbControl.TabPages.Remove(tbPgSongs);
            tbControl.TabPages.Remove(tbPgUserInfo);
            tbControl.TabPages.Insert(0, tbPgLogin);

        }

        private void ckbRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRegister.Checked)
            {
                lblLoginAddress.Visible = true;
                lblLoginEmail.Visible = true;
                tbLoginAddress.Visible = true;
                tbLoginEmail.Visible = true;
                btRegister.Visible = true;
            }
            else
            {
                lblLoginAddress.Visible = false;
                lblLoginEmail.Visible = false;
                tbLoginAddress.Clear();
                tbLoginEmail.Clear();
                tbLoginAddress.Visible = false;
                tbLoginEmail.Visible = false;
                btRegister.Visible = false;
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLoginUsername.Text) || string.IsNullOrWhiteSpace(tbLoginAddress.Text) || string.IsNullOrWhiteSpace(tbLoginEmail.Text) || string.IsNullOrWhiteSpace(tbLoginPassword.Text))
            {
                MessageBox.Show("Invalid Inputs");
                return;
            }
            if (streamingMusicService.GetUsers().Find(user => user.GetName() == tbLoginUsername.Text) != null)
            {
                MessageBox.Show("Username already in use");
                return;
            }
            if (tbLoginPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be bigger than 6 characters");
                return;
            }

            streamingMusicService.AddUser(tbLoginUsername.Text, tbLoginPassword.Text, tbLoginEmail.Text, tbLoginAddress.Text);
            ckbRegister.Checked = false;
        }

        private void btShowAllUsers_Click(object sender, EventArgs e)
        {
            List<User> allUsers = streamingMusicService.GetUsers();
            if (allUsers == null) { MessageBox.Show("No Users"); }
            else
            {
                string message = streamingMusicService.GetInfo() + ":\n";
                foreach (User user in allUsers)
                {
                    message += $" - {user.GetName()}\n";
                }
                MessageBox.Show(message);
            }
        }

        private void cbPlaylistFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                if (cbPlaylistFilter.SelectedIndex != 0) { savedPlaylistComboBoxIndex = cbPlaylistFilter.SelectedIndex; }
                if (activeUser.GetPlaylists().Count != cbPlaylistFilter.Items.Count)
                {
                    cbPlaylistFilter.DataSource = activeUser.GetPlaylists().ToArray();
                }
                cbPlaylistFilter.SelectedIndex = savedPlaylistComboBoxIndex;
                savedPlaylistComboBoxIndex = 0;
                RefreshListBox();
            }
        }

        private void cbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            if (activeUser != null) // If a user is logged in update these too
            {
                tbUserFavourites.Text = activeUser.GetPlaylist().Songs.Count.ToString();
                cbSongsPlaylist.DataSource = activeUser.GetPlaylists().ToArray();
            }
            if (cbPlaylistFilter.SelectedItem == null || cbPlaylistFilter.Text == "None")
            {
                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(streamingMusicService.GetSongs());
            }
            else
            {
                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(((Playlist)cbPlaylistFilter.SelectedItem).Songs.ToArray());
            }
            if (cbGenreFilter.SelectedItem != null && cbGenreFilter.Text != "ALL")
            {
                // Make a list of ListBox items, process it and then repopulate ListBox
                int numberOfSongs = lbSongs.Items.Count;
                string[] listSongsToBeProcessed = new string[numberOfSongs];
                for (int i = 0; i < numberOfSongs; i++)
                {
                    listSongsToBeProcessed[i] = lbSongs.Items[i].ToString();
                }
                Enum.TryParse(cbGenreFilter.Text, out Genre genre); // Turn the Genre string into an Enum
                for (int i = 0; i < numberOfSongs; i++)
                {
                    Song song = streamingMusicService.GetSongs().ToList().Find(song => song.ToString() == listSongsToBeProcessed[i]); // Find the song object
                    MessageBox.Show($"Combo Box: {genre} - Song: {song.GetGenre()}");
                    if (song.GetGenre().ToString() != cbGenreFilter.SelectedItem.ToString())
                    {
                        listSongsToBeProcessed[i] = null;
                    }
                }
                listSongsToBeProcessed = listSongsToBeProcessed.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(listSongsToBeProcessed);
            }
            lblNumberOfSongs.Text = "Songs: " + lbSongs.Items.Count.ToString();
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSongs.SelectedItem != null)
            {
                Song song = streamingMusicService.GetSongs().ToList().Find(song => song.ToString() == lbSongs.SelectedItem.ToString()); // Find the song object
                lblSongsTitle.Text = song.GetTitle();
                lblSongsArtist.Text = song.GetArtist();
                lblSongsDuration.Text = song.GetDuration();
            }
            else
            {
                lblSongsTitle.Text = "";
                lblSongsArtist.Text = "";
                lblSongsDuration.Text = "";
            }
        }

        private void btSongsAddToPlaylist_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedItem == null)
            {
                return;
            }
            Song song = streamingMusicService.GetSongs().ToList().Find(song => song.ToString() == lbSongs.SelectedItem.ToString());
            activeUser.RemoveSongFromPlaylists(song);
            if (cbSongsPlaylist.Text == null || cbSongsPlaylist.Text == "None")
            {
                RefreshListBox();
                return;
            }
            activeUser.AddSong(song, (Playlist)cbSongsPlaylist.SelectedItem);
            RefreshListBox();
        }

        private void btAddSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddSongTitle.Text)) { MessageBox.Show("Invalid name"); return; }
            string[] titles = streamingMusicService.GetSongs().Select(song => song.GetTitle()).ToArray();
            if (titles.Contains(tbAddSongTitle.Text))
            {
                MessageBox.Show("Song already exists");
                return;
            }
            if (cbGenreFilter.SelectedItem == null || cbAddSongGenre.Text == "ALL")
            {
                streamingMusicService.AddSong(tbAddSongTitle.Text, tbAddSongArtist.Text, Convert.ToInt32(nupAddSongDuration.Value));
            }
            else
            {
                Enum.TryParse(cbAddSongGenre.Text, out Genre genre);
                streamingMusicService.AddSong(tbAddSongTitle.Text, tbAddSongArtist.Text, Convert.ToInt32(nupAddSongDuration.Value), genre);
            }
            /*string message = "";
            foreach (string m in streamingMusicService.GetSongs().Select(song => song.GetInfo()))
            {
                message += m + "\n";
            }
            MessageBox.Show(message);*/

            tbAddSongArtist.Clear();
            tbAddSongTitle.Clear();
            nupAddSongDuration.Value = 0;
            cbAddSongGenre.SelectedIndex = 0;

            RefreshListBox();
        }

        private void btAddPlaylist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAddPlaylistName.Text))
            {
                activeUser.AddPlaylist(tbAddPlaylistName.Text);
            }
        }
    }
}
