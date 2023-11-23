using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper4sToolsAgain.PostureCheck
{
	internal class PostureCheckModel
	{
		public void setTimeInterval(int timeInterval) { Program.appSettings.setTimeInterval(timeInterval); }
	}
}
