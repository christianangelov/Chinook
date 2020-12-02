using Chinook.Logic;
using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Requests.GetAlbumStats();
			Requests.GetCustomerStats();
			Requests.GetGenreSellStats();
			Requests.GetQuantitiyStats();
			Requests.GetSellStats();
			var result = Requests.GetTrackDurationStats();

			// Ausgabe
			Console.WriteLine("-----------------------------------------------------------");
			Console.WriteLine("*           Chinook-Marketing                             *");
			Console.WriteLine("*           Angelov Christian                             *");
			Console.WriteLine("*----------------------------------------------------------");
			Console.WriteLine();
			


			Console.WriteLine("Track-Zeit Auswertung\n" +
				"Tack/Titel\n" +
				$"Track with hightest Duration: {result.track_with_highest_duration.TrackName}\t\t\t{result.track_with_highest_duration.MilliSeconds / 1000}\n" +
				$"Track with shortest Duration: {result.track_with_lowest_duration.TrackName}\t\t\t{result.track_with_lowest_duration.MilliSeconds / 1000}\n" +
				$"Approximately Duration: \t\t\t\t{result.approximately_track_duration_in_milliseconds / 1000}");
			Console.WriteLine();
			
		}
	}
}
