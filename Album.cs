using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11_MoreList_Enum
{
    public class Album
    {
        // Enumerator
        public enum GENRE { COUNTRY, HIPHOP, ROCK, BLUES }

        public enum MEASUREMENTS {  LB, OZ, CUP, EACH }
        // Fields
        string _artist;
        string _name;
        GENRE _genre;
        List<Song> _songs = new List<Song>();

        // Constructor
        public Album(string artist, string name, GENRE genre)
        {
            _artist = artist;
            _name = name;
            _genre = genre;
        }

        // Properties
        public string Artist { get => _artist; set => _artist = value; }
        public string Name { get => _name; set => _name = value; }
        public List<Song> Songs { get => _songs;  }
        public GENRE Genre { get => _genre; set => _genre = value; }

        // Method
        public void AddSong(Song song)
        {
            _songs.Add(song);
        } // AddSong()

        // New Topic - Remove Song
        public void RemoveSong(Song song)
        {
            _songs.Remove(song);
        }




    } // class

} // namespace
