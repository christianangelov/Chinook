using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Persistence
{
    public interface IRoomData : IIdentifiable
    {
         int DislozierungId { get; set; }
         string Kurzbezeichnung { get; set; }
         string Bezeichungung { get; set; }
         string Code { get; set; }
         string UPISBez { get; set; }
    }
}
