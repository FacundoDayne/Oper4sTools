using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace testSite
{
	internal class testSite
	{
		static void Main(String[] args)
		{

			while (true)
			{
				write();
				Console.ReadKey();
			}
			
		}

		static void write()
		{
			string baseJson = File.ReadAllText("appsettings.json");
			dynamic editJson = Newtonsoft.Json.JsonConvert.DeserializeObject(baseJson);
			string newJson = Newtonsoft.Json.JsonConvert.SerializeObject(editJson);
			Console.Write(newJson);
			File.WriteAllText("appsettings.json", newJson);
		}
	}
}