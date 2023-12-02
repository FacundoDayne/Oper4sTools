using Oper4sToolsAgain.RandomGame.Custom;
using System.ComponentModel;

namespace Oper4sToolsAgain.RandomGame
{
	public partial class RandomGameUserControl : UserControl
	{
		public static gamePicture selected;
		private event EventHandler gameSelected;
		public static RandomGameUserControl randomInstance;
		public List<Game> games;
		public List<PictureBox> tableControls;
		private System.Timers.Timer gameTime;
		private int gameTimed = 0;
		public RandomGameUserControl()
		{
			randomInstance = this;
			InitializeComponent();
			games = Program.appSettings.getGameList();
			tableControls = new List<PictureBox>();
			prepareTable(false);
			gameSelected += RandomGameUserControl_gameSelected;
			btnRandom.Click += getRandomGame;
		}

		private void getRandomGame(object? sender, EventArgs e)
		{
			Random random = new Random();
			List<Game> games = Program.appSettings.getGameList();
			gamePicture pictureBox = (gamePicture)Controls.Find("Game" + (int)random.NextInt64(1, games.Count + 1), true)[0];
			playGame(pictureBox);
		}

		private void GameTime_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
		{
			gameTimed++;
		}

		private void Gaming_Done(object? sender, EventArgs e)
		{
			gameTime.Stop();
			TimeSpan timeElapsed = TimeSpan.FromSeconds(gameTimed);
			string formattedTime;
			try
			{
				if (timeElapsed.TotalHours >= 1) formattedTime = timeElapsed.ToString(@"hh\:mm\:ss" + " hours");
				else if (timeElapsed.TotalMinutes >= 1) formattedTime = timeElapsed.ToString(@"m\:ss" + " minutes");
				else formattedTime = timeElapsed.ToString(@"ss") + " seconds";

				MessageBox.Show("You have been playing for: " + formattedTime, "Random Game by Oper4's Tools");
			}
			catch (Exception s) { MessageBox.Show(s.Message + "\n" + gameTimed.ToString()); }
		
			
		}

		private void RandomGameUserControl_gameSelected(object? sender, EventArgs e)
		{
			gameNameLabel.Text = selected.getGame().gameName;
		}
		public void raiseGameSelected() { gameSelected(this, new EventArgs()); }

		public void prepareTable(bool updateGames)
		{
			tableControls.Clear();
			int i = 1;
			foreach (Game game in games)
			{
				game.gameID = "Game" + i;
				i++;
				tableControls.Add(new gamePicture(game));
			}
			tableControls.Add(new addNewGame());
			if (updateGames) Program.appSettings.writeGameJSON(games);
			populateTable();
		}

		private void populateTable()
		{
			foreach (Control control in gameLayoutPanel.Controls)
			{
				Console.WriteLine(control.Name.ToString() + " will be removed");
				gameLayoutPanel.Controls.Remove(control);
				control.Dispose();
				gameLayoutPanel.Controls.Clear();
				gameLayoutPanel.ResumeLayout();
			}

			foreach (PictureBox pictureBox in tableControls)
			{
				Console.WriteLine(pictureBox.Name.ToString() + " will be added");
				gameLayoutPanel.Controls.Add(pictureBox);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			try
			{
				games.Remove(selected.getGame());
				selected = null;
				gameNameLabel.Text = "";
				prepareTable(true);
			}
			catch (NullReferenceException nre) { Console.WriteLine("No game was selected"); }
		}

		private void playSelected(object sender, EventArgs e)
		{
			try
			{
				gamePicture pictureBox = selected;
				playGame(pictureBox);
			}
			catch (NullReferenceException nre) { Console.WriteLine("No game was selected"); }
		}

		private void playGame(gamePicture pictureBox)
		{
			System.Diagnostics.Process gaming = new System.Diagnostics.Process();
			gaming.StartInfo.FileName = pictureBox.getGame().gameFilePath;
			gaming.EnableRaisingEvents = true;
			gaming.Exited += Gaming_Done;
			try
			{
				MessageBox.Show(pictureBox.getGame().gameName.ToString() + " will now Play", "Random Game by	Oper4's Tools");
				gaming.Start();
			}
			catch (Win32Exception win)
			{
				MessageBox.Show("We couldn't run the game, probably because of elevation issues. Either run the game yourself or reopen this application in Administrator mode.\n\nYou got your game though, so have fun!", "Random Game by Oper4's Tools");
			}

			gameTime = new System.Timers.Timer();
			gameTime.Interval = 1000;
			gameTime.Elapsed += GameTime_Elapsed;
			gameTime.Start();
		}
	}
}
