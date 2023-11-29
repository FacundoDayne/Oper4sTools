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

namespace Oper4sToolsAgain.RandomGame.Custom
{
	public partial class gamePicture : PictureBox
	{
		Game game;
		
		public gamePicture(Game game)
		{
			this.game = game;
			InitializeComponent();
			this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.Image = RaymondSolution.getImage(game.filePath);
			this.Size = new Size(164, 144);
			this.SizeMode = PictureBoxSizeMode.Zoom;
			this.Name = game.name;
			this.Margin = new Padding(10);
			this.MouseEnter += GamePicture_MouseEnter;
			this.MouseLeave += GamePicture_MouseLeave;
			this.MouseDown += GamePicture_MouseDown;
		}

		public Game getGame() { return game; }

		private void GamePicture_MouseDown(object? sender, MouseEventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.MouseUp += GamePicture_MouseUp;
			this_PictureBox.MouseDown -= GamePicture_MouseDown;
			if (e.Button == MouseButtons.Left) this_PictureBox.BackColor = Color.FromArgb(34, 49, 63);
			RandomGameUserControl.selected = game;
			RandomGameUserControl.randomInstance.raiseGameSelected();
		}

		private void GamePicture_MouseUp(object? sender, MouseEventArgs e)
		{			
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.MouseUp -= GamePicture_MouseUp;
			this_PictureBox.MouseDown += GamePicture_MouseDown;
			this_PictureBox.BackColor = Color.FromArgb(0, 43, 54);
		}

		private void GamePicture_MouseLeave(object? sender, EventArgs e)
		{
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.BackColor = Color.Black;			
			this_PictureBox.MouseLeave -= GamePicture_MouseLeave;
			this_PictureBox.MouseEnter += GamePicture_MouseEnter;
		}

		private void GamePicture_MouseEnter(object? sender, EventArgs e)
		{			
			PictureBox this_PictureBox = sender as PictureBox;
			this_PictureBox.BackColor = Color.FromArgb(0, 43, 54);
			this_PictureBox.MouseEnter -= GamePicture_MouseEnter;
			this_PictureBox.MouseLeave += GamePicture_MouseLeave;
		}
	}
}
