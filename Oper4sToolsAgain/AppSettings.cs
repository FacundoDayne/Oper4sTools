using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Oper4sToolsAgain
{

	public class Game()
	{
		public string gameID {  get; set; }
		public string gameName { get; set; }
		public string gameFilePath { get; set; }
	}

	internal class AppSettings
	{
		private string baseJson;
		private string defaultSettings = "[{ \"debugMode\": false, \"timeInterval\": 30, \"commandPromptGUIFilePath\": \"defaultFilePath\"}]";
		private dynamic settingsJson;
		private bool debugMode;
		private int timeInterval;
		private string commandPromptGUIFilePath;
		private static List<Game> gamesList;
		public AppSettings()
		{
			if(!File.Exists("appsettings.json")) firstRun();
			baseJson = File.ReadAllText("appsettings.json");
			if (File.Exists("gamedirectory.json")) readGameJSON();
			else gamesList = new List<Game>();
			settingsJson = JsonConvert.DeserializeObject(baseJson);
			debugMode = settingsJson["Settings"][0]["debugMode"];
			timeInterval = settingsJson["Settings"][0]["timeInterval"];
			commandPromptGUIFilePath = settingsJson["Settings"][0]["commandPromptGUIFilePath"];
			if (debugMode) flipDebugMode();
		}
		public List<Game> getGameList() { return gamesList; }
		private void readGameJSON()
		{
			string baseJson = File.ReadAllText("gamedirectory.json");
			dynamic settingsJson = JsonConvert.DeserializeObject(baseJson);
			gamesList = new List<Game>();
			JObject jsonObject = JObject.Parse(File.ReadAllText("gamedirectory.json"));
			int gameCount = jsonObject.Count;
			for (int i = 1; i <= gameCount; i++)
			{
				gamesList.Add(new Game()
				{
					gameID = settingsJson["Game" + i][0]["gameID"],
					gameName = settingsJson["Game" + i][0]["gameName"],
					gameFilePath = settingsJson["Game" + i][0]["gameFilePath"]
				});
			}
		}
		public void writeGameJSON(List<Game> games)
		{

			Dictionary<string, List<Game>> gamesDictionary = new Dictionary<string, List<Game>>();
			int i = 1;
			foreach (Game game in games)
			{
				List<Game> gameList = new List<Game>
				{
					new Game
					{
					gameID = "Game" + i,
					gameName = game.gameName,
					gameFilePath = game.gameFilePath
					} 
				};
				gamesDictionary.Add("Game" + i, gameList);
				i++;
			}
			gamesList = games;
			string gameJson = JsonConvert.SerializeObject(gamesDictionary, Formatting.Indented);
			File.WriteAllText("gamedirectory.json", gameJson);
		}

		private void firstRun()
		{
			JObject jsonObject = new JObject();
			jsonObject["Settings"] = JArray.Parse(defaultSettings);
			string makeNew = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
			File.WriteAllText("appsettings.json", makeNew);
		}
		public string getCommandPromptGUIFilePath() { return commandPromptGUIFilePath; }
		public void setCommandPromptGUIFilePath(string commandPromptGUIFilePath) 
		{ 
			this.commandPromptGUIFilePath = commandPromptGUIFilePath;
			settingsJson["Settings"][0]["commandPromptGUIFilePath"] = commandPromptGUIFilePath;
			writeToJson(); 
		}
		public bool isDebugMode() {  return debugMode; }
		public int getTimeInterval() {  return timeInterval; }
		public void setTimeInterval(int timeInterval)
		{
			this.timeInterval = timeInterval;
			settingsJson["Settings"][0]["timeInterval"] = timeInterval;
			writeToJson();
		}
		public void flipDebugMode()
		{
			bool current = settingsJson["Settings"][0]["debugMode"];
			settingsJson["Settings"][0]["debugMode"] = !current;
			writeToJson();
		}
		private void writeToJson()
		{
			string newJson = JsonConvert.SerializeObject(settingsJson, Formatting.Indented);
			File.WriteAllText("appsettings.json", newJson);
		}
	}
}
