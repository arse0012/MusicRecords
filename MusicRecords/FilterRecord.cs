using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords
{
    public class FilterRecord
    {
        public FilterRecord(int longDuration, int shortDuration)
        {
            LongDuration = longDuration;
            ShortDuration = shortDuration;
        }
        public FilterRecord()
        {
            
        }
        public int LongDuration { get; set; }

        public int ShortDuration { get; set; }

        public override string ToString()
        {
            return $"{nameof(LongDuration)}: {LongDuration}, {nameof(ShortDuration)}: {ShortDuration}";
        }
    }
}
