using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Hasher
{
	public partial class MainForm : Form
	{
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
				return BitConverter.ToString(value: MD5.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
			}
		}

		private static string GetRIPEMD160HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: RIPEMD160.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
			}
		}

		private static string GetSHA1HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA1.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
			}
		}

		private static string GetSHA256HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA256.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
			}
		}

		private static string GetSHA384HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA384.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
			}
		}

		private static string GetSHA512HashFromFile(string fileName)
		{
			using (FileStream fileStream = File.OpenRead(path: fileName))
			{
				return BitConverter.ToString(value: SHA512.Create().ComputeHash(inputStream: fileStream)).Replace(oldValue: "-", newValue: string.Empty);
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

		private void ButtonSaveMD5StringToFile_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveRIPEMD160ToFile_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e)
		{
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
				if (files.Length > 1)
				{
					MessageBox.Show(text: "Only the first file of multiple files is accepted.", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
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
	}
}