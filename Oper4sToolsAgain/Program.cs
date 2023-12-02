using System.Runtime.InteropServices;


namespace Oper4sToolsAgain
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			appSettings = new AppSettings();
			if (appSettings.isDebugMode()) { AllocConsole(); MessageBox.Show("Warning, Closing the console will exit the program"); }
			ApplicationConfiguration.Initialize();
			Oper4sTools oper4STools = new Oper4sTools();
			Application.Run();
			FreeConsole();
		}
		public static AppSettings appSettings;

		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();

		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();
	}
}