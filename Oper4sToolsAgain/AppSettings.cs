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
	internal class AppSettings
	{
		private string baseJson = File.ReadAllText("appsettings.json");
		private string defaultSettings = "[{ \"debugMode\": false, \"timeInterval\": 30, \"commandPromptGUIFilePath\": \"defaultFilePath\"}]";
		private dynamic editJson;
		private bool debugMode;
		private int timeInterval;
		private string commandPromptGUIFilePath;
		public AppSettings()
		{
			if(!File.Exists("appsettings.json")) firstRun();
			editJson = JsonConvert.DeserializeObject(baseJson);
			debugMode = editJson["Settings"][0]["debugMode"];
			timeInterval = editJson["Settings"][0]["timeInterval"];
			commandPromptGUIFilePath = editJson["Settings"][0]["commandPromptGUIFilePath"];
			if (debugMode) flipDebugMode();
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
			editJson["Settings"][0]["commandPromptGUIFilePath"] = commandPromptGUIFilePath;
			writeToJson(); 
		}
		public bool isDebugMode() {  return debugMode; }
		public int getTimeInterval() {  return timeInterval; }
		public void setTimeInterval(int timeInterval)
		{
			this.timeInterval = timeInterval;
			editJson["Settings"][0]["timeInterval"] = timeInterval;
			writeToJson();
		}
		public void flipDebugMode()
		{
			bool current = editJson["Settings"][0]["debugMode"];
			editJson["Settings"][0]["debugMode"] = !current;
			writeToJson();
		}
		private void writeToJson()
		{
			string newJson = JsonConvert.SerializeObject(editJson, Formatting.Indented);
			File.WriteAllText("appsettings.json", newJson);
		}
	}
}
