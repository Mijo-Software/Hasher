using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Hasher
{
	public partial class MainForm : Form
	{
		[StructLayout(LayoutKind.Sequential)]
		private struct SHELLEXECUTEINFO
		{
			public int cbSize;
			public uint fMask;
			public IntPtr hwnd;
			public string lpVerb;
			public string lpFile;
			public string lpParameters;
			public string lpDirectory;
			public int nShow;
			public int hInstApp;
			public int lpIDList;
			public string lpClass;
			public int hkeyClass;
			public uint dwHotKey;
			public int hIcon;
			public int hProcess;
		}

		private const int SW_SHOW = 5;
		private const uint SEE_MASK_INVOKEIDLIST = 12;

		[DllImport("shell32.dll")]
		private static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

		private static void ShowProperties(string path)
		{
			FileInfo fi = new FileInfo(fileName: path);
			SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
			info.cbSize = Marshal.SizeOf(structure: info);
			info.lpVerb = "properties";
			info.lpFile = fi.Name;
			info.lpDirectory = fi.DirectoryName;
			info.nShow = SW_SHOW;
			info.fMask = SEE_MASK_INVOKEIDLIST;
			ShellExecuteEx(lpExecInfo: ref info);
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void CalculateHashesFromFile()
		{
			textBoxMD5String.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
			textBoxRIPEMD160String.Text = GetRIPEMD160HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA1String.Text = GetSHA1HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA256String.Text = GetSHA256HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA384String.Text = GetSHA384HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA512String.Text = GetSHA512HashFromFile(fileName: textBoxFileName.Text);
		}

		private void OpenAndCalculateFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxFileName.Text = openFileDialog.FileName;
				CalculateHashesFromFile();
			}
		}

		private static string GetMD5HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: MD5.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private static string GetRIPEMD160HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: RIPEMD160.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private static string GetSHA1HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA1.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private static string GetSHA256HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA256.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private static string GetSHA384HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA384.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private static string GetSHA512HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA512.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: Properties.Resources.dash, newValue: string.Empty);
			}
		}

		private void ButtonCopyMD5StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxMD5String.Text);
		}

		private void ButtonCopyRIPEMD160StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxRIPEMD160String.Text);
		}

		private void ButtonCopySHA1StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA1String.Text);
		}

		private void ButtonCopySHA256StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA256String.Text);
		}

		private void ButtonCopySHA384StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA384String.Text);
		}

		private void ButtonCopySHA512StringToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA512String.Text);
		}

		private void SaveHashValueToFile(string hashFileExtension, string hashValue)
		{
			saveFileDialog.FileName = $"{textBoxFileName.Text}{hashFileExtension}";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fileStream = new FileStream(path: saveFileDialog.FileName, mode: FileMode.Create, access: FileAccess.Write))
				{
					StreamWriter streamWriter = new StreamWriter(stream: fileStream);
					streamWriter.Write(value: hashValue);
					streamWriter.Flush();
					streamWriter.Close();
				}
			}
		}

		private void ButtonSaveMD5StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.md5FileExt, hashValue: textBoxMD5String.Text);
		}

		private void ButtonSaveRIPEMD160ToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.ripemd160FileExt, hashValue: textBoxRIPEMD160String.Text);
		}

		private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha1FileExt, hashValue: textBoxSHA1String.Text);
		}

		private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha256FileExt, hashValue: textBoxSHA256String.Text);
		}

		private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha384FileExt, hashValue: textBoxSHA384String.Text);
		}

		private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha512FileExt, hashValue: textBoxSHA512String.Text);
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				string[] files = e.Data.GetData(format: DataFormats.FileDrop) as string[];
				if (files.Length > 1)
				{
					MessageBox.Show(text: Properties.Resources.onlyFirstFileIsAccepted, caption: Properties.Resources.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
				}
				textBoxFileName.Text = files[0];
				CalculateHashesFromFile();
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void ButtonShowFileProperties_Click(object sender, EventArgs e)
		{
			if (File.Exists(path: textBoxFileName.Text))
			{
				ShowProperties(path: textBoxFileName.Text);
			}
			else
			{
				MessageBox.Show(text: Properties.Resources.fileDoesNotExist, caption: Properties.Resources.error, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}
	}
}