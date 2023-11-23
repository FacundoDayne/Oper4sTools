using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper4sToolsAgain
{
	internal class SoundController
	{
		static SoundModel soundModel = new SoundModel();
		public static MemoryStream getSound(string whatType)
		{
			soundModel.setType(whatType);
			return soundModel.getSound();
		}

	}
}
