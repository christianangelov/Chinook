using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IPlaylistTrack : IIdentifiable
    {
         int TrackId { get; set; }
    }
}
