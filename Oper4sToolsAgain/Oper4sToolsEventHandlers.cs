using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oper4sToolsAgain
{
	internal class Oper4sToolsEventHandlers
	{

		public static void NotifyIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Oper4sTools.thisForm.Show();
				Oper4sTools.thisForm.WindowState = FormWindowState.Normal;
			}
			else if (e.Button == MouseButtons.Right) Oper4sTools.contextMenuStrip.Show(Cursor.Position);
			else if (e.Button == MouseButtons.Middle)
			{
				miscTools.closeProgram();
			}


		}
		public static void homeContextMenu(object sender, EventArgs e)
		{
			UserControlMethods.maskChange(new UserControl(), new UserControl());
			Oper4sTools.thisForm.Show();
			Oper4sTools.thisForm.WindowState = FormWindowState.Normal;
		}

		public static void postureCheckMenu(object sender, EventArgs e)
		{
			UserControlMethods.maskChange(new UserControl(), new UserControl());
			Oper4sTools.thisForm.Show();
			Oper4sTools.thisForm.WindowState = FormWindowState.Normal;
		}
		public static void tryPostureCheckMenu(object sender, EventArgs e)
		{
			Oper4sToolsFunctions.playReminder(null);
		}

		public static void openDebugConsole(object sender, EventArgs e)
		{
			//UserControlMethods.maskChange(new UserControl(), new UserControl());
			Program.appSettings.flipDebugMode();
			//miscTools.closeProgram();
		}
		public static void exitToolStripMenuItem(object sender, EventArgs e)
		{
			miscTools.closeProgram();
		}
	}
}
