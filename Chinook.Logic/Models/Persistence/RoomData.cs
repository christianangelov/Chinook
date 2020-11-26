using CsvMapper.Logic.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/RoomData.csv")]

    internal class RoomData : IdentityObject, Contracts.Persistence.IRoomData
    {
        [DataPropertyInfo(OrderPosition = 1)]

        public int DislozierungId { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]

        public string Kurzbezeichnung { get; set; }
        [DataPropertyInfo(OrderPosition = 3)]

        public string Bezeichungung { get; set; }
        [DataPropertyInfo(OrderPosition = 4)]

        public string Code { get; set; }
        [DataPropertyInfo(OrderPosition = 5)]

        public string UPISBez { get; set; }
    }
}
