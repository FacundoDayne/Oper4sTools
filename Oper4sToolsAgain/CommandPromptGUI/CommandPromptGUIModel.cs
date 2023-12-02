using System;
using System.Diagnostics;

namespace Oper4sToolsAgain.CommandPromptGUI
{
	public class CommandPromptGUIModel
	{
		string link = Program.appSettings.getCommandPromptGUIFilePath();

		Process process;
		Process[] isRunning;
		public void startCommandPromptGUIMode()
		{
			Console.Write(link);
			if (link == "defaultFilePath")
			{
				setCommandPromptGUIFilePath();
			}
			string processname = Path.GetFileNameWithoutExtension(link);
			isRunning = Process.GetProcessesByName(processname);
			if (isRunning.Length <= 0)
			{
				process = new Process();
				process.StartInfo.FileName = link;
				process.EnableRaisingEvents = true;
				process.Exited += Process_Exited;
				process.Start();
			}
			else MessageBox.Show("Command Prompt already running", "Oper4sTools");
		}
		private void setCommandPromptGUIFilePath()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select a File";
			openFileDialog.Filter = "All Files (*.*)|*.*";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				link = openFileDialog.FileName;
				Program.appSettings.setCommandPromptGUIFilePath(link);
			}
		}
		private void Process_Exited(object sender, EventArgs e)
		{
			foreach (Process isProsessed in isRunning)
			{
				isProsessed.Kill(); isProsessed.Dispose();
			}
			Process exitedProcess = (Process)sender;
			exitedProcess.Exited -= Process_Exited;
			exitedProcess.Dispose();
		}
	}
}
