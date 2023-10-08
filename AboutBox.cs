using System.Reflection;
using System.Windows.Forms;
using MijoSoftware.AssemblyInformation;

namespace HashLister
{
	/// <summary>
	/// AboutBox
	/// </summary>
	internal partial class AboutBox : Form
	{
		public AboutBox() => InitializeComponent();

		private void AboutBox_Load(object sender, System.EventArgs e)
		{
			Text = $"Info über {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}
	}
}
