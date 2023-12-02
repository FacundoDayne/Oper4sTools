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
	public partial class addNewGameForm : Form
	{
		public string name, filePath;
		bool nameFlag = false, filePathFlag = false;
		public addNewGameForm()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel; Close();
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (nameFlag && filePathFlag) { this.DialogResult |= DialogResult.OK; Close(); }
			else MessageBox.Show("Please fill out the required information", "Add New Game");
		}

		private void btnFilePath_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select a Game";
			openFileDialog.Filter = "All Files (*.*)|*.*";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				filePath = openFileDialog.FileName;
				filePathFlag = true;
				lblFilePath.Text = filePath;
			}
		}

		private void tbName_TextChanged(object sender, EventArgs e)
		{
			nameFlag = true;
			name = tbName.Text.ToString();
		}
	}
}
