using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oper4sToolsAgain;
using System.Drawing.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace testSite
{

	internal class testSiteSnapshot2
	{
		static List<Game> gamesList;
		static void Main(String[] args)
		{

			MessageBox.Show("1\n2\n3");

		}

		static List<Game> read()
		{
			string baseJson = File.ReadAllText("gamedir.json");
			dynamic settingsJson = JsonConvert.DeserializeObject(baseJson);
			gamesList = new List<Game>();
			JObject jsonObject = JObject.Parse(File.ReadAllText("gamedir.json"));
			int gameCount = jsonObject.Count;
			for (int i = 1; i <= gameCount; i++)
			{
				gamesList.Add(new Game()
				{
					//name = settingsJson["Game" + i][0]["name"],
					//filePath = settingsJson["Game" + i][0]["filePath"]
				});
			}
			return gamesList;

		}
		void write()
		{
			JObject jsonObject = JObject.Parse(File.ReadAllText("gamedir.json"));

			int gameCount = jsonObject.Count + 1;
			Game newGame = new Game()
			{
				//name = "name" + (gameCount),
				//filePath = "?"
			};
			string keyString = "Game" + (gameCount);
			jsonObject[keyString] = JObject.FromObject(newGame);
			string updatedJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
			File.WriteAllText("gamedir.json", updatedJson);
		}

		static void writeAll()
		{
			JObject jsonObject = new JObject();
			int i = 1;
			foreach(Game game in gamesList)
			{
				jsonObject["GameV" + i] = JObject.FromObject(game);
				i++;
			}
			string updatedJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
			File.WriteAllText("gamedir.json", updatedJson);
		}
		void plac()
		{
			/*
			for (int i = 1; i <= gameCount; i++)
			{
				String key = "Game" + i;
				JArray gameData = (JArray)dynaObject[key];
				gameArray.Add(new Game()
				{
					name = gameData[0]["name"].ToString(),
					filePath = gameData[0]["filePath"].ToString()
				});
			}
			Console.ReadLine();
			*/
		}
	}
}