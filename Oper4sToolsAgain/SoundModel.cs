using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper4sToolsAgain
{
	internal class SoundModel
	{
		private MemoryStream wavFile;
		private UnmanagedMemoryStream ums;
		private string whatType;
		private Random random = new Random();
		private SortedDictionary<string, UnmanagedMemoryStream> soundCache = new SortedDictionary<string, UnmanagedMemoryStream>();

//greeting
//farewell
//clip
		private void loadSound()
		{
			try
			{
				int rng = random.Next(1, 6);
				switch (whatType)
				{
					case "0":
						ums = Properties.Resources.greeting;
						break;
					case "1":
						ums = Properties.Resources.farewell;
						break;
					case "2":
						whatType = "clip" + rng;
						ums = Properties.Resources.ResourceManager.GetStream(whatType);
						break;
				}
				wavFile = new MemoryStream();
				ums.CopyTo(wavFile);
			}
			catch (Exception ex) { Console.WriteLine("Problem found in SoundModel {0}", ex.Message); }
			finally { ums?.Dispose(); }
		}
		private void cacheSound()
		{
			bool l = true;
			int typeCounter = 0, clipCounter = 1;
			while(l)
			{
				switch (typeCounter.ToString())
				{
					case "0":
						whatType = typeCounter.ToString();
						ums = Properties.Resources.greeting;
						break;
					case "1":
						whatType = typeCounter.ToString();
						ums = Properties.Resources.farewell;
						break;
					case "2":
						whatType = "clip" + clipCounter.ToString();
						ums = Properties.Resources.ResourceManager.GetStream(whatType);
						break;
				}

				if (!soundCache.TryGetValue(whatType, out _)) soundCache.Add(whatType, ums);
				if (typeCounter < 2) typeCounter++;
				else if (clipCounter < 5) clipCounter++;
				else l = false;
			}
			Console.WriteLine("Printing Dictionary\n----------------------------------");
			foreach (var ks in soundCache)
			{
				Console.WriteLine(ks.Key + ": " + ks.Value);
			}
			Console.WriteLine("----------------------------------");
		}
		public SoundModel() { cacheSound(); }
		public void setType(string whatType) { this.whatType = whatType; }
		public MemoryStream getSound()
		{
			loadSound();
			wavFile.Position = 0;
			return wavFile;
		}

	}
}
