using Oper4sToolsAgain.RandomGame.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oper4sToolsAgain.RandomGame
{
	public partial class RandomGameUserControl : UserControl
	{
		public RandomGameUserControl()
		{
			InitializeComponent();
		}

		void populateTable()
		{
			List<Game> games = Program.appSettings.getGameList();
			foreach(Game game in games)
			{
				gameLayoutPanel.Controls.Add(new gamePicture(game));
			}
		}

	}
}
