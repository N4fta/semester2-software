using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int _songIdSeeder;
        private string _name;
        private List<Song> _songs;
        private List<User> _users;

        public StreamingMusicService(string name)
        {
            this._songIdSeeder = 1;
            this._name = name;
            this._songs = new List<Song>();
            this._users = new List<User>();
        }

        public void AddSong(string artist, string title, int durationInSeconds)
        {
            this._songs.Add(new Song(this._songIdSeeder, artist, title, durationInSeconds));
            this._songIdSeeder++;
        }

        public void AddSong(string artist, string title, int durationInSeconds, Genre genre)
        {
            this._songs.Add(new Song(this._songIdSeeder, artist, title, durationInSeconds, genre));
            this._songIdSeeder++;
        }

        public void RemoveSong(string title)
        {
            Song song = this._songs.Find(song => song.GetTitle() == title);
            this._songs.Remove(song);

            foreach (User user in _users)
            {
                foreach (Playlist playlist in user.GetPlaylists())
                {
                    playlist.Remove(song);
                }
            }
        }

        public Song GetSong(int id)
        {
            foreach (Song s in this._songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }

        public Song[] GetSongs()
        {
            return this._songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this._songs)
            {
                if (artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }

        public void AddUser(string newName, string newPassword, string newEmail, string newAddress)
        {
            _users.Add(new User(newName, newPassword, newEmail, newAddress));
        }

        public User? GetUser(string username)
        {
            return _users.Find(user => user.GetName() == username);
        }

        public List<User> GetUsers()
        { return _users; }

        public string GetInfo()
        {
            return $"Streaming Music service: {this._name} ({this._songs.Count} songs & {this._users.Count} user(s))";
        }

    }
}
