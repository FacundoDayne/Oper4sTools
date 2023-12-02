using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oper4sToolsAgain.RandomGame.Custom
{
	public partial class addNewGame : PictureBox
	{
		public addNewGame()
		{
			InitializeComponent();
			this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.Image = Properties.Resources.plus;
			this.Size = new Size(164, 144);
			this.SizeMode = PictureBoxSizeMode.Zoom;
			this.Name = "addNewButton";
			this.Margin = new Padding(10);
			this.MouseEnter += AddNewGame_MouseEnter;
			this.MouseLeave += AddNewGame_MouseLeave;
			this.MouseDown += AddNewGame_MouseDown;
		}


		private void AddNewGame_MouseDown(object? sender, MouseEventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;			
			if (e.Button == MouseButtons.Left)
			{
				this_PictureBox.BackColor = Color.FromArgb(34, 49, 63);
				this_PictureBox.MouseUp += AddNewGame_MouseUp;
				this_PictureBox.MouseDown -= AddNewGame_MouseDown;
			}
		}

		private void AddNewGame_MouseUp(object? sender, MouseEventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.MouseUp -= AddNewGame_MouseUp;
			this_PictureBox.MouseDown += AddNewGame_MouseDown;
			this_PictureBox.BackColor = Color.FromArgb(0, 43, 54);
			using (addNewGameForm form = new addNewGameForm()) 
			{
				if(form.ShowDialog() == DialogResult.OK)
				{
					Game game = new Game()
					{
						gameID = RandomGameUserControl.randomInstance.Controls.Count.ToString(),
						gameName = form.name,
						gameFilePath = form.filePath
					};
					RandomGameUserControl.randomInstance.games.Add(game);
					RandomGameUserControl.randomInstance.prepareTable(true);
				}
			}
		}

		private void AddNewGame_MouseLeave(object? sender, EventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.BackColor = Color.Black;
			this_PictureBox.MouseLeave -= AddNewGame_MouseLeave;
			this_PictureBox.MouseEnter += AddNewGame_MouseEnter;
		}

		private void AddNewGame_MouseEnter(object? sender, EventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.BackColor = Color.FromArgb(0, 43, 54);
			this_PictureBox.MouseEnter -= AddNewGame_MouseEnter;
			this_PictureBox.MouseLeave += AddNewGame_MouseLeave;
		}
	}
}
