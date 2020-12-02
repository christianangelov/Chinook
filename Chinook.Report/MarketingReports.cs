﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chinook.Report
{
	public class MarketingReports
	{
		public static IEnumerable<Contracts.Report.Marketing.IArtistStatistic> GetArtistStatistics()
		{
			var albums = Logic.Factory.GetAllAlbums();
			var artists = Logic.Factory.GetAllArtists();

			var result = default(IEnumerable<Contracts.Report.Marketing.IArtistStatistic>);

			return result;
		}

		public static Contracts.Report.Marketing.ITrackTimeStatistic GetTrackTimeStatistic()
        {
			var tracks = Logic.Factory.GetAllTrack();
			var result = new Marketing.Models.TrackTimeStatistic();

			result.maxName = tracks.Max().TrackName;
            result.maxNumber = tracks.Max().MilliSeconds.ToString();

			result.minName = tracks.Min().TrackName;
			result.minNumber = tracks.Min().MilliSeconds.ToString();

			result.avgNumber = tracks.Average(t => t.MilliSeconds).ToString();

			return result;
        }

		public static Contracts.Report.Marketing.ICostumerSaleStatistic GetCostumerSaleStatistic()
        {
			var invoices = Logic.Factory.GetAllInvoice();
			var costumers = Logic.Factory.GetAllCustomers();
			var result = new Marketing.Models.CostumerSaleStatistic();

			var item = (
				
				from i in invoices
				join c in costumers on i.Id equals c.Id
				group i by c.LastName)
				.Select(j => (j.Key, j.Sum(a => a.Total)))
				.OrderBy(a => a.Item2
						  );

			result.maxName = item.Last().Key;
			result.maxNumber = item.Last().Item2.ToString();

			result.minName = item.First().Key;
			result.minNumber = item.First().Item2.ToString();

			result.avgNumber = item.Average(k => k.Item2).ToString();

			return result;
        }
		public static Contracts.Report.Marketing.ITrackSaleStatistic GetTrackSaleStatistic()
        {
			var invoicesLines = Logic.Factory.GetAllInvoiceLine();
			var tracks = Logic.Factory.GetAllTrack();
			var result = new Marketing.Models.TrackSaleStatistic();

			var item = (
				from i in invoicesLines
				group i.Quantity by i.TrackId)
				.Select(i => (i.Key, i.Sum())
			);


			var max = tracks.Where(q => q.Id == item.Max().Key).SingleOrDefault();
			var min = tracks.Where(q => q.Id == item.Min().Key).SingleOrDefault();

			result.maxSaleName = max.TrackName;
			result.maxSaleNumber = item.Max().ToString();

			result.minSaleName = min.TrackName;
			result.minSaleNumber = item.Min().ToString();

			var query = (from i in invoicesLines
						 join t in tracks on i.TrackId equals t.Id
						 group i.Quantity by t.TrackName)
						.Select(j => (j.Key, j.Sum()))
						.OrderBy(a => a.Item2);

			result.minPaidSaleName = query.First().Key;
			result.minPaidSaleName = query.First().Item2.ToString();

			result.minPaidSaleName = query.Last().Key;
			result.minPaidSaleName = query.Last().Item2.ToString();


			return result;
        }

		public static Contracts.Report.Marketing.IAlbumTimeStatistic GetAlbumTimeStatistic()
        {
			var tracks = Logic.Factory.GetAllTrack();
			var albums = Logic.Factory.GetAllAlbums();
			var result = new Marketing.Models.AlbumTimeStatistic();

			var query = (
				from t in tracks
				join a in albums on t.AlbumId equals a.Id
				group t.MilliSeconds by a.Title)
				.Select(i => (i.Key, i.Sum())
				);

			result.maxName = query.OrderBy(a => a.Item2).Last().Key;
			result.maxNumber = query.OrderBy(a => a.Item2).Last().Item2.ToString();


			result.minName = query.OrderBy(a => a.Item2).First().Key;
			result.minNumber = query.OrderBy(a => a.Item2).First().Item2.ToString();

			result.avgNumber = Math.Round(query.Average(a => a.Item2) / 1000).ToString();

			return result;
		}
	}
}
