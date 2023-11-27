using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper4sToolsAgain.CommandPromptGUI
{
	public class CommandPromptGUIController
	{
		private CommandPromptGUIModel model = new CommandPromptGUIModel();
		public void openCommandPromptGUIModel()
		{
			model.startCommandPromptGUIMode();
		}
	}
}
