using System.Configuration;
using System.Formats.Tar;
using System.Media;

namespace testSite
{
	internal class testSiteSnapshot1
	{
		static readonly Random random = new Random();
		static private SortedDictionary<string, UnmanagedMemoryStream> soundCache = new SortedDictionary<string, UnmanagedMemoryStream>();
		static UnmanagedMemoryStream ums;
		static string whatType;
		static void Main(string[] args)
		{
			cacheSound();
			Console.WriteLine("Printing Dictionary");
			foreach(var ks in soundCache)
				{
					Console.WriteLine(ks.Key + ": " + ks.Value);
				}
			int a = 0;
			while (true)
			{
				trySound(a.ToString());
				if (a < 2) a++; 
			}
		}

		private static void cacheSound()
		{
			bool l = true;
			int typeCounter = 0, clipCounter = 1;
			while (l)
			{
				switch (typeCounter.ToString())
				{
					case "0":
						whatType = typeCounter.ToString();
						ums = Oper4sToolsAgain.Properties.Resources.greeting;
						break;
					case "1":
						whatType = typeCounter.ToString();
						ums = Oper4sToolsAgain.Properties.Resources.farewell;
						break;
					case "2":
						whatType = "clip" + clipCounter.ToString();
						ums = Oper4sToolsAgain.Properties.Resources.ResourceManager.GetStream(whatType);
						break;

				}

				if (!soundCache.TryGetValue(whatType, out _)) soundCache.Add(whatType, ums);
				if (typeCounter < 2) typeCounter++;
				else if (clipCounter < 5) clipCounter++;
				else l = false;


			}
		}

		static void trySound(string whatType)
		{

			int rng = random.Next(1, 6);
			switch (whatType)
			{
				case "0":
					ums = Oper4sToolsAgain.Properties.Resources.greeting;
					break;
				case "1":
					ums = Oper4sToolsAgain.Properties.Resources.farewell;
					break;
				case "2":
					whatType = "clip" + rng;
					ums = Oper4sToolsAgain.Properties.Resources.ResourceManager.GetStream(whatType);
					break;

			}
			using (MemoryStream ms = new MemoryStream())
			{
				ums.CopyTo(ms);
				ums?.Dispose();
				ms.Position = 0;
				new SoundPlayer(ms).PlaySync();
			}
		}
	}

}