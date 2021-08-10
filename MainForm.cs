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

		private static string GetSHA1HashFromFile(string fileName)
		{
			using (SHA1 sha1 = SHA1.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: sha1.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private static string GetSHA256HashFromFile(string fileName)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: sha256.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private static string GetSHA384HashFromFile(string fileName)
		{
			using (SHA384 sha384 = SHA384.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: sha384.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private static string GetSHA512HashFromFile(string fileName)
		{
			using (SHA512 sha512 = SHA512.Create())
			{
				using (FileStream fileStream = File.OpenRead(path: fileName))
				{
					using (FileStream stream = fileStream)
					{
						return BitConverter.ToString(value: sha512.ComputeHash(inputStream: stream)).Replace(oldValue: "-", newValue: string.Empty);
					}
				}
			}
		}

		private void ButtonCalculateFile_Click(object sender, EventArgs e)
		{
			textBoxMD5String.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
			textBoxRIPEMD160String.Text = GetRIPEMD160HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA1String.Text = GetSHA1HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA256String.Text = GetSHA256HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA384String.Text = GetSHA384HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA512String.Text = GetSHA512HashFromFile(fileName: textBoxFileName.Text);
		}

		private void ButtonCopyMD5String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxMD5String.Text);
		}

		private void ButtonCopyRIPEMD160String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxRIPEMD160String.Text);
		}

		private void ButtonCopySHA1String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA1String.Text);
		}

		private void ButtonCopySHA256String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA256String.Text);
		}

		private void ButtonCopySHA384String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA384String.Text);
		}

		private void ButtonbuttonCopySHA512String_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(text: textBoxSHA512String.Text);
		}
	}
}