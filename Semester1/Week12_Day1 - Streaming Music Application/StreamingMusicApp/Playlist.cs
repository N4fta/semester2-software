using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Playlist
    {
        private string _name;
        private List<Song> _songs;

        public Playlist(string newName)
        {
            _name = newName;
            _songs = new List<Song>();
        }

        public string Name { get => _name; }

        public List<Song> Songs { get => _songs; }

        public void Add(Song song) { _songs.Add(song); }

        public void Remove(Song song) { _songs.Remove(song); }

        public bool Contains(Song song)
        {
            return _songs.Contains(song);
        }

        public int Count { get => _songs.Count; }

        public override string ToString() { return _name; }
    }
}
