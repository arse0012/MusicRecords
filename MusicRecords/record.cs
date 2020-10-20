using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords
{
    public class record
    {
        private int _id = 0;
        private string _title;
        private string _artist;
        private int _duration;
        private string _yearOfPublication;

        public record()
        {
            
        }

        public record(string title, string artist, int duration, string yearOfPublication)
        {
             _id = 0;
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
        }

        public string Title
        {
            get { return _title;}
            set { _title = value; }
        }
        public string Artist
        {
            get { return _artist;}
            set { _artist = value; }

        }

        public int Duration
        {
            get { return _duration;}
            set { _duration = value; }
        }

        public string YearOfPublication
        {
            get { return _yearOfPublication;}
            set { _yearOfPublication = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
