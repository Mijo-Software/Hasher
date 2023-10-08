using System;
using System.Windows.Forms;

namespace HashLister
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (HashListerForm hashListerForm = new HashListerForm())
			{
				Application.Run(hashListerForm);
			}
		}
	}
}
