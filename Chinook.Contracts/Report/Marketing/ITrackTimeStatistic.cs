﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackTimeStatistic
    {
        string maxName { get; }
        string maxNumber { get; }
        string minName { get; }
        string minNumber { get; }
        string avgNumber { get; }
    }
}
