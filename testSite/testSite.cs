using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSite
{
	public class Game
	{
		public string GameID { get; set; }
		public string GameName { get; set; }
		public string GameFilePath { get; set; }
	}
	public class testSite
	{
		static void Main()
		{
			// Create a dictionary to store games with gameID as the key
			Dictionary<string, Game> gamesDictionary = new Dictionary<string, Game>();

			// Create a list of games for Game1
			Game gameList1 = new Game()
			{
				GameID = "Game1",
				GameName = "Timed2Shutdown",
				GameFilePath = "B:\\Records\\Programming\\C#\\Console-Commands-GUI\\Timed2Shutdown\\bin\\Debug\\Timed2Shutdown.exe"
			};
			//JArray.Parse(gameList1);
			// Add the list of games to the dictionary with the key "Game1"
			gamesDictionary.Add("Game1", gameList1);

			// Convert the dictionary to JSON
			string json = JsonConvert.SerializeObject(gamesDictionary, Formatting.Indented);

			Console.WriteLine(json);
		}
	}
}
