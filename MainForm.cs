using Hasher.Properties;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Hasher
{
    /// <summary>
    /// Main Form
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class MainForm : Form
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm() => InitializeComponent();

        #endregion

        #region Local methods

        /// <summary>
        /// Get Debugger Display
        /// </summary>
        /// <returns></returns>
        private string GetDebuggerDisplay() => ToString();

        /// <summary>
        /// Calculate hash values from a file
        /// </summary>
        private void CalculateHashesFromFile()
        {
            textBoxMD5StringFromFile.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
            textBoxRIPEMD160StringFromFile.Text = GetRIPEMD160HashFromFile(fileName: textBoxFileName.Text);
            textBoxSHA1StringFromFile.Text = GetSHA1HashFromFile(fileName: textBoxFileName.Text);
            textBoxSHA256StringFromFile.Text = GetSHA256HashFromFile(fileName: textBoxFileName.Text);
            textBoxSHA384StringFromFile.Text = GetSHA384HashFromFile(fileName: textBoxFileName.Text);
            textBoxSHA512StringFromFile.Text = GetSHA512HashFromFile(fileName: textBoxFileName.Text);
        }

        /// <summary>
        /// Calculate hash values from a text/string
        /// </summary>
        private void CalculateHashesFromText()
        {
            textBoxMD5StringFromText.Text = GetMD5HashFromText(input: textBoxText.Text);
            textBoxRIPEMD160StringFromText.Text = GetRIPEMD160HashFromText(input: textBoxText.Text);
            textBoxSHA1StringFromText.Text = GetSHA1HashFromText(input: textBoxText.Text);
            textBoxSHA256StringFromText.Text = GetSHA256HashFromText(input: textBoxText.Text);
            textBoxSHA384StringFromText.Text = GetSHA384HashFromText(input: textBoxText.Text);
            textBoxSHA512StringFromText.Text = GetSHA512HashFromText(input: textBoxText.Text);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetMD5HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: MD5.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetMD5HashFromText(string input)
        {
            byte[] hashBytes = MD5.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return new StringBuilder().ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetRIPEMD160HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: RIPEMD160.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetRIPEMD160HashFromText(string input)
        {
            byte[] hashBytes = RIPEMD160.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                //stringBuilder.AppendFormat(provider: CultureInfo.InvariantCulture, format: "{0}", arg0: v);
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetSHA1HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: SHA1.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetSHA1HashFromText(string input)
        {
            byte[] hashBytes = SHA1.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetSHA256HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: SHA256.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetSHA256HashFromText(string input)
        {
            byte[] hashBytes = SHA256.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetSHA384HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: SHA384.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetSHA384HashFromText(string input)
        {
            byte[] hashBytes = SHA384.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string GetSHA512HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: SHA512.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetSHA512HashFromText(string input)
        {
            byte[] hashBytes = SHA512.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte v in hashBytes)
            {
                stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hashFileExtension"></param>
        /// <param name="hashValue"></param>
        private void SaveHashValueToFile(string hashFileExtension, string hashValue)
        {
            saveFileDialog.FileName = $"{textBoxFileName.Text}{hashFileExtension}";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(
                    path: saveFileDialog.FileName,
                    mode: FileMode.Create,
                    access: FileAccess.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter(stream: fileStream))
                    {
                        streamWriter.Write(value: hashValue);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
            }
        }

        #endregion

        #region Click event handlers

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAndCalculateFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog.FileName;
                CalculateHashesFromFile();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculateHashFromText_Click(object sender, EventArgs e) => CalculateHashesFromText();

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopyMD5StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxMD5StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopyMD5StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxMD5StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopyRIPEMD160StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxRIPEMD160StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopyRIPEMD160StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxRIPEMD160StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA1StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA1StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA1StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA1StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA256StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA256StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA256StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA256StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA384StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA384StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA384StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA384StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA512StringFromFileToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA512StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCopySHA512StringFromTextToClipboard_Click(object sender, EventArgs e) => Clipboard.SetText(
            text: textBoxSHA512StringFromText.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveMD5StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.md5FileExt,
            hashValue: textBoxMD5StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveRIPEMD160ToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.ripemd160FileExt,
            hashValue: textBoxRIPEMD160StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha1FileExt,
            hashValue: textBoxSHA1StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha256FileExt,
            hashValue: textBoxSHA256StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha384FileExt,
            hashValue: textBoxSHA384StringFromFile.Text);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha512FileExt,
            hashValue: textBoxSHA512StringFromFile.Text);

        #endregion

        #region CheckedChange event handlers

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxAutoUpdateText_CheckedChanged(object sender, EventArgs e) => buttonCalculateHashFromText.Enabled =
            !buttonCalculateHashFromText.Enabled;

        #endregion

        #region DragDrop event handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
            {
                tabControl.SelectedTab = tabPageFile;
                string[] files = e.Data.GetData(format: DataFormats.FileDrop) as string[];
                if (files.Length > 1)
                {
                    MessageBox.Show(
                        text: Resources.onlyFirstFileIsAccepted,
                        caption: Resources.warning,
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                }
                textBoxFileName.Text = files[0];
                CalculateHashesFromFile();
            }
            else if (e.Data.GetDataPresent(format: DataFormats.Text) ||
              e.Data.GetDataPresent(format: DataFormats.UnicodeText))
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
                MessageBox.Show(
                    text: Resources.onlyFileOrTextAreAccepted,
                    caption: Resources.warning,
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(format: DataFormats.FileDrop) ||
                e.Data.GetDataPresent(format: DataFormats.Text) ||
                e.Data.GetDataPresent(format: DataFormats.UnicodeText))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        #endregion

        #region KeyPress event handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxText_KeyPress(object sender, EventArgs e)
        {
            if (checkBoxAutoUpdateText.Checked)
            {
                CalculateHashesFromText();
            }
        }

        #endregion

    }
}