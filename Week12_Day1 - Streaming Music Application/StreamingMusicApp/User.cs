using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public class User
    {
        private const int MAX_SONGS_PER_PLAYLIST = 50;
        private string _name;
        private string _password;
        private string _email;
        private string _address;
        private Playlist _Favourites;
        private Playlist _All;
        private List<Playlist> _Playlists;

        public User(string newName, string newPassword, string newEmail, string newAddress)
        {
            _name = newName;
            _password = newPassword;
            _email = newEmail;
            _address = newAddress;
            _Favourites = new Playlist("Favourites");
            _All = new Playlist("None");
            _Playlists = new List<Playlist>();
            _Playlists.Add(new Playlist("None"));
            _Playlists.Add(_Favourites);

        }

        public void AddSong(Song newSong)
        {
            _All.Add(newSong);
        }

        public void AddSong(Song newSong, string playlist)
        {
            Playlist playlist1 = GetPlaylist(playlist);
            if (playlist1.Count <= MAX_SONGS_PER_PLAYLIST)
            {
                playlist1.Add(newSong);
            }
        }

        public void AddSong(Song newSong, Playlist playlist)
        {
            if (playlist.Count <= MAX_SONGS_PER_PLAYLIST)
            {
                playlist.Add(newSong);
            }
        }

        public void RemoveSongFromPlaylists(Song song)
        {
            foreach (Playlist playlist in GetPlaylists())
            {
                playlist.Remove(song);
            }
        }

        /*public void RemoveSongFromPlaylists(Song song, string playlistName)
        {
            Playlist playlist = _Playlists.Find(playlist => playlist.Name == playlistName);
            playlist.Remove(song);
        }*/

        public Playlist GetPlaylist()
        {
            return _Favourites;
        }

        public Playlist GetPlaylist(string playlistName)
        {
            return _Playlists.Find(playlist => playlist.Name == playlistName);
        }

        public List<Playlist> GetPlaylists()
        {
            return _Playlists;
        }

        public void AddPlaylist(string name)
        {
            _Playlists.Add(new Playlist(name));
            return;
        }

        public bool CheckPassword(string password)
        {
            if (_password == password) return true;
            return false;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetEmail()
        {
            return _email;
        }
        public string GetAddress()
        {
            return _address;
        }
    }
}
