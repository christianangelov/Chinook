using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Track.csv")]

    internal class Track : IdentityObject, Contracts.Persistence.ITrack
    {
        [DataPropertyInfo(OrderPosition = 1)]

        public string TrackName { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]

        public int AlbumId { get; set; }
        [DataPropertyInfo(OrderPosition = 3)]

        public int MediaTypeId { get; set; }
        [DataPropertyInfo(OrderPosition = 4)]


        public int GenreId { get; set; }
        [DataPropertyInfo(OrderPosition = 5)]

        public string Composer { get; set; }
        [DataPropertyInfo(OrderPosition = 6)]

        public long MilliSeconds { get; set; }
        [DataPropertyInfo(OrderPosition = 7)]

        public int Bytes { get; set; }
        [DataPropertyInfo(OrderPosition = 8)]

        public double UnitPrice { get; set; }

        public int CompareTo(object obj)
        {
            return MilliSeconds.CompareTo(((Track)obj).MilliSeconds);
        }
    }
}

