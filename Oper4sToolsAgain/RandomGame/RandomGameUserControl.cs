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
using static System.Windows.Forms.LinkLabel;

namespace Oper4sToolsAgain.RandomGame
{
	public partial class RandomGameUserControl : UserControl
	{
		public static Game selected;
		public event EventHandler gameSelected;
		public static RandomGameUserControl randomInstance;
		public RandomGameUserControl()
		{
			randomInstance = this;
			InitializeComponent();
			populateTable();
			gameSelected += RandomGameUserControl_gameSelected;
			button1.Click += getRandomGame;
		}

		private void getRandomGame(object? sender, EventArgs e)
		{
			Random random = new Random();
			List<Game> games = Program.appSettings.getGameList();
			int max = games.Count;
			int r = (int)random.NextInt64(1, max);
			MessageBox.Show("Max: " + max + "\nRandom: " + r);

			gamePicture pictureBox = (gamePicture)Controls.Find("Game" + r, true)[0];
			Game game = pictureBox.getGame();
			MessageBox.Show(game.name.ToString());
		}

		private void RandomGameUserControl_gameSelected(object? sender, EventArgs e)
		{
			gameNameLabel.Text = selected.name.ToString();
		}
		public void raiseGameSelected() { gameSelected(this, new EventArgs()); }
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
