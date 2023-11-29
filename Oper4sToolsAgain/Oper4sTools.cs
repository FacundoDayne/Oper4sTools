using System.Resources;

namespace Oper4sToolsAgain
{
	public partial class Oper4sTools : Form
	{
		public static Oper4sTools thisForm;
		public static NotifyIcon notifyIcon;
		public static ContextMenuStrip contextMenuStrip;
		public static CommandPromptGUI.CommandPromptGUIController commandPromptGUIController = new CommandPromptGUI.CommandPromptGUIController();
		public UserControl _current;
		public static System.Threading.Timer timer;
		public double timeInterval = Program.appSettings.getTimeInterval(); //in minutes
		public Oper4sTools()
		{			
			InitializeComponent(); 
			thisForm = this;
			TrayIcon.startTrayIcon();
			Oper4sToolsFunctions.setTimer();
			Oper4sToolsFunctions.playGreeting();
			prep_current();
			
		}

		public void maskChange(UserControl uc)
		{
			Controls.Remove(_current);
			_current = uc;
			Controls.Add(_current);
			_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			_current.Location = new System.Drawing.Point(0, 0);
			_current.Name = "_current";
			_current.Size = new System.Drawing.Size(800, 450);
			_current.TabIndex = 0;
		}

		private void prep_current()
		{
			_current = new CustomUserControls.baseUserControl();
			Controls.Add(_current);
			_current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			_current.Location = new System.Drawing.Point(0, 0);
			_current.Name = "_current";
			_current.Size = new System.Drawing.Size(800, 450);
			_current.TabIndex = 0;
		}
		

	}
}
