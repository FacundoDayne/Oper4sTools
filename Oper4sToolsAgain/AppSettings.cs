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
		public string name { get; set; }
		public string filePath { get; set; }
	}

	internal class AppSettings
	{
		private string baseJson = File.ReadAllText("appsettings.json");
		private string defaultSettings = "[{ \"debugMode\": false, \"timeInterval\": 30, \"commandPromptGUIFilePath\": \"defaultFilePath\"}]";
		private dynamic settingsJson;
		private bool debugMode;
		private int timeInterval;
		private string commandPromptGUIFilePath;
		private static List<Game> gamesList;
		Game game1 = new Game();
		public AppSettings()
		{
			if(!File.Exists("appsettings.json")) firstRun();
			if (File.Exists("gamedir.json")) readGameJSON();
			else gamesList = new List<Game>();
			settingsJson = JsonConvert.DeserializeObject(baseJson);
			debugMode = settingsJson["Settings"][0]["debugMode"];
			timeInterval = settingsJson["Settings"][0]["timeInterval"];
			commandPromptGUIFilePath = settingsJson["Settings"][0]["commandPromptGUIFilePath"];
			if (debugMode) flipDebugMode();
			game1.name = "a";
		}
		public List<Game> getGameList() { return gamesList; }
		private void readGameJSON()
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
					name = settingsJson["Game" + i][0]["name"],
					filePath = settingsJson["Game" + i][0]["filePath"]
				});
			}
		}

		public void writeGameJSON()
		{
			JObject jsonObject = new JObject();
			int i = 1;
			foreach (Game game in gamesList)
			{
				jsonObject["Game" + i] = JObject.FromObject(game);
				i++;
			}
			string updatedJson = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
			File.WriteAllText("gamedir.json", updatedJson);
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
