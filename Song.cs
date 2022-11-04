using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11_MoreList_Enum
{
    public class Song
    {
        string _title;
        int _duration;

        public Song(string title, int duration)
        {
            _title = title;
            _duration = duration;
        }

        public string Title { get => _title; set => _title = value; }
        public int Duration { get => _duration; set => _duration = value; }


    } // class

} // namespace
