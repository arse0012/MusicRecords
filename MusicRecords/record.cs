using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords
{
    public class record
    {
        private string _title;
        private string _artist;
        private int _duration;
        private string _yearOfPublication;

        public record()
        {
            
        }

        public record(string title, string artist, int duration, string yearOfPublication)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public string YearOfPublication { get; set; }
    }
}
