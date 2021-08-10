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

		private void OpenFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxFileName.Text = openFileDialog.FileName;
			}
		}

		private static string GetMD5HashFromFile(string fileName)
		{
			using (MD5 md5 = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: md5.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private static string GetRIPEMD160HashFromFile(string fileName)
		{
			using (RIPEMD160 ripemd160 = RIPEMD160.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: ripemd160.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private void ButtonCalculateFile_Click(object sender, EventArgs e)
		{
			textBoxMD5String.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
			textBoxRIPEMD160String.Text = GetRIPEMD160HashFromFile(fileName: textBoxFileName.Text);
		}

		private void ButtonCopyMD5String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxMD5String.Text);
		}

		private void ButtonCopyRIPEMD160String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxRIPEMD160String.Text);
		}
	}
}