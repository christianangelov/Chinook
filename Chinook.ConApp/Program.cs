using System;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chinook-Marketing!");

			var genres = Logic.Factory.GetAllGenres();
			var artists = Logic.Factory.GetAllArtists();
			var albums = Logic.Factory.GetAllAlbums();
			var customers = Logic.Factory.GetAllCustomers();
			var employees = Logic.Factory.GetAllEmployee();
			//var invoices = Logic.Factory.GetAllInvoice();
			//var invoiceLines = Logic.Factory.GetAllInvoice(); 
			var mediaTypes = Logic.Factory.GetAllMediaType();
			var playlists = Logic.Factory.GetAllPlaylist();
			//var playlistTracks = Logic.Factory.GetAllPlaylistTrack();
			//var RoomDatas = Logic.Factory.GetAllRoomData(); 
			//var tracks = Logic.Factory.GetAllTrack(); 


			var artistStatistics = Report.MarketingReports.GetArtistStatistics();
            Console.WriteLine(artistStatistics);
		
		}
	}
}
