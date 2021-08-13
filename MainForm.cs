using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
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
			textBoxMD5StringFromFile.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
			textBoxRIPEMD160StringFromFile.Text = GetRIPEMD160HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA1StringFromFile.Text = GetSHA1HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA256StringFromFile.Text = GetSHA256HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA384StringFromFile.Text = GetSHA384HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA512StringFromFile.Text = GetSHA512HashFromFile(fileName: textBoxFileName.Text);
		}

		private void CalculateHashesFromText()
		{
			textBoxMD5StringFromText.Text = GetMD5HashFromText(input: textBoxText.Text);
			textBoxRIPEMD160StringFromText.Text = GetRIPEMD160HashFromText(input: textBoxText.Text);
			textBoxSHA1StringFromText.Text = GetSHA1HashFromText(input: textBoxText.Text);
			textBoxSHA256StringFromText.Text = GetSHA256HashFromText(input: textBoxText.Text);
			textBoxSHA384StringFromText.Text = GetSHA384HashFromText(input: textBoxText.Text);
			textBoxSHA512StringFromText.Text = GetSHA512HashFromText(input: textBoxText.Text);
		}

		private void OpenAndCalculateFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxFileName.Text = openFileDialog.FileName;
				CalculateHashesFromFile();
			}
		}

		private void ButtonCalculateHashFromText_Click(object sender, EventArgs e)
		{
			CalculateHashesFromText();
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

		private static string GetMD5HashFromText(string input)
		{
			byte[] hashBytes = MD5.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private static string GetRIPEMD160HashFromText(string input)
		{
			byte[] hashBytes = RIPEMD160.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private static string GetSHA1HashFromText(string input)
		{
			byte[] hashBytes = SHA1.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private static string GetSHA256HashFromText(string input)
		{
			byte[] hashBytes = SHA256.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private static string GetSHA384HashFromText(string input)
		{
			byte[] hashBytes = SHA384.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private static string GetSHA512HashFromText(string input)
		{
			byte[] hashBytes = SHA512.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < hashBytes.Length; i++)
			{
				stringBuilder.Append(value: hashBytes[i].ToString(format: "X2"));
			}
			return stringBuilder.ToString();
		}

		private void ButtonCopyMD5StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxMD5StringFromFile.Text);
		}

		private void ButtonCopyRIPEMD160StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxRIPEMD160StringFromFile.Text);
		}

		private void ButtonCopySHA1StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA1StringFromFile.Text);
		}

		private void ButtonCopySHA256StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA256StringFromFile.Text);
		}

		private void ButtonCopySHA384StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA384StringFromFile.Text);
		}

		private void ButtonCopySHA512StringFromFileToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA512StringFromFile.Text);
		}
		private void ButtonCopyMD5StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxMD5StringFromText.Text);
		}

		private void ButtonCopyRIPEMD160StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxRIPEMD160StringFromText.Text);
		}

		private void ButtonCopySHA1StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA1StringFromText.Text);
		}

		private void ButtonCopySHA256StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA256StringFromText.Text);
		}

		private void ButtonCopySHA384StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA384StringFromText.Text);
		}

		private void ButtonCopySHA512StringFromTextToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA512StringFromText.Text);
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
			SaveHashValueToFile(hashFileExtension: Properties.Resources.md5FileExt, hashValue: textBoxMD5StringFromFile.Text);
		}

		private void ButtonSaveRIPEMD160ToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.ripemd160FileExt, hashValue: textBoxRIPEMD160StringFromFile.Text);
		}

		private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha1FileExt, hashValue: textBoxSHA1StringFromFile.Text);
		}

		private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha256FileExt, hashValue: textBoxSHA256StringFromFile.Text);
		}

		private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha384FileExt, hashValue: textBoxSHA384StringFromFile.Text);
		}

		private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e)
		{
			SaveHashValueToFile(hashFileExtension: Properties.Resources.sha512FileExt, hashValue: textBoxSHA512StringFromFile.Text);
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				tabControl.SelectedTab = tabPageFile;
				string[] files = e.Data.GetData(format: DataFormats.FileDrop) as string[];
				if (files.Length > 1)
				{
					MessageBox.Show(text: Properties.Resources.onlyFirstFileIsAccepted, caption: Properties.Resources.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
				}
				textBoxFileName.Text = files[0];
				CalculateHashesFromFile();
			}
			else if (e.Data.GetDataPresent(format: DataFormats.Text) || e.Data.GetDataPresent(format: DataFormats.UnicodeText))
			{
				tabControl.SelectedTab = tabPageText;
				if (e.Data.GetDataPresent(format: DataFormats.Text))
				{
					textBoxText.Text = e.Data.GetData(format: DataFormats.Text) as string;
				}
				else if (e.Data.GetDataPresent(format: DataFormats.UnicodeText))
				{
					textBoxText.Text = e.Data.GetData(format: DataFormats.UnicodeText) as string;
				}
				CalculateHashesFromText();
			}
			else
			{
				MessageBox.Show(text: Properties.Resources.onlyFileOrTextAreAccepted, caption: Properties.Resources.warning, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop) || e.Data.GetDataPresent(format: DataFormats.Text) || e.Data.GetDataPresent(format: DataFormats.UnicodeText))
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

		private void CheckBoxAutoUpdateText_CheckedChanged(object sender, EventArgs e)
		{
			buttonCalculateHashFromText.Enabled = !buttonCalculateHashFromText.Enabled;
		}

		private void TextBoxText_KeyPress(object sender, EventArgs e)
		{
			if (checkBoxAutoUpdateText.Checked)
			{
				CalculateHashesFromText();
			}
		}
	}
}