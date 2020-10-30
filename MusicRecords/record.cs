using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords
{
    public class record
    {
        public record()
        {
            
        }

        public record(int id, string title, string artist, int duration, string yearOfPublication)
        {
             Id= id;
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfPublication = yearOfPublication;
        }

        public string Title { get; set; }

        public string Artist { get; set; }

        public int Duration { get; set; }

        public string YearOfPublication { get; set; }

        public int Id { get; set; }
    }
}
