using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private int _id;
        private string _artist;
        private Genre _genre;
        private string _title;        
        private int _durationInSeconds;

        public Song(int id, string artist, string title, int durationInSeconds)
        {
            this._id = id;
            this._artist = artist;
            this._title = title;
            this._durationInSeconds = durationInSeconds;
        }

        public Song(int id, string artist, string title, int durationInSeconds, Genre genre)
        {
            this._id = id;
            this._artist = artist;
            this._title = title;
            this._durationInSeconds = durationInSeconds;
            this._genre = genre;
        }

        public int GetId() {  return this._id; }

        public string GetTitle() { return this._title; }

        public string GetArtist() {  return this._artist; }

        public Genre GetGenre() {  return this._genre; }

        public string GetDuration() { return $"{ this._durationInSeconds / 60}:{ this._durationInSeconds % 60}"; }

        public int GetDurationInSeconds() { return _durationInSeconds; }

        public string GetInfo()
        {
            return $"ID {this._id:00}: {this._artist} - {this._title} - {this._genre} - ({this._durationInSeconds / 60}:{this._durationInSeconds % 60})";
        }

        public override string ToString()
        {
            return $"ID {this._id:00}: {this._artist} - {this._title} - {this._genre} - ({this._durationInSeconds / 60}:{this._durationInSeconds % 60})";
        }
    }
}
