using System.Resources;

namespace Oper4sToolsAgain
{
	public partial class Oper4sTools : Form
	{
		public static Form thisForm;
		public static NotifyIcon notifyIcon;
		public static ContextMenuStrip contextMenuStrip;
		private UserControl _current;
		public static System.Threading.Timer timer;
		public double timeInterval = Program.appSettings.getTimeInterval(); //in minutes
		public Oper4sTools()
		{			
			InitializeComponent(); thisForm = this;
			TrayIcon.startTrayIcon();
			Oper4sToolsFunctions.setTimer();
			Oper4sToolsFunctions.playGreeting();
		}

		

	}
}
