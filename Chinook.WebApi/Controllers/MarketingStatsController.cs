using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Chinook.Logic;

namespace Chinook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingStatsController : ControllerBase
    {
        [HttpGet("/api/[controller]/test")]
        public string test()
        {
            return "test";
        }

        [HttpGet("/api/[controller]/AlbumTimeStatistic")]
        public Contracts.Report.Marketing.IAlbumTimeStatistic AlbumTime()
        {
            return Report.MarketingReports.GetAlbumTimeStatistic();
        }

        [HttpGet("/api/[controller]/CostumerSaleStatistic")]
        public Contracts.Report.Marketing.ICostumerSaleStatistic CostumerSale()
        {
            return Report.MarketingReports.GetCostumerSaleStatistic();
        }

        [HttpGet("/api/[controller]/TrackSaleStatistic")]
        public Contracts.Report.Marketing.ITrackSaleStatistic TrackSale()
        {
            return Report.MarketingReports.GetTrackSaleStatistic();
        }

        [HttpGet("/api/[controller]/TrackTimeStatistic")]
        public Contracts.Report.Marketing.ITrackTimeStatistic TrackTime()
        {
            return Report.MarketingReports.GetTrackTimeStatistic();
        }
    }
}
