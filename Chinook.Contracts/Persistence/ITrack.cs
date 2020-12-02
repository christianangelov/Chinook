using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface ITrack : IIdentifiable
    {
         string TrackName { get; set; }
         int AlbumId { get; set; }
         int MediaTypeId { get; set; }
         int GenreId { get; set; }
         string Composer { get; set; }
         long MilliSeconds { get; set; }
         int Bytes { get; set; }
         string UnitPrice { get; set; }
    }
}

