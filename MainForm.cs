using Hasher.Properties;
using MijoSoftware.AssemblyInformation;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
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
        /// <returns>Return the debugger display</returns>
        private string GetDebuggerDisplay() => ToString();

        /// <summary>
        /// Open a url
        /// </summary>
        /// <param name="url">web page</param>
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(fileName: url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.Windows))
                {
                    url = url.Replace(oldValue: "&", newValue: "^&");
                    Process.Start(startInfo: new ProcessStartInfo(fileName: url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.Linux))
                {
                    Process.Start(fileName: "xdg-open", arguments: url);
                }
                else if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.OSX))
                {
                    Process.Start(fileName: "open", arguments: url);
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Set a specific text to the status bar
        /// </summary>
        /// <param name="text">text with some information</param>
        private void SetStatusbarText(string text)
        {
            toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
            toolStripStatusLabelInformation.Text = text;
        }

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
        /// Calculate the MD5 hash value from a file
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <returns>MD5 hash value</returns>
        private static string GetMD5HashFromFile(string fileName)
        {
            using (FileStream fileStream = File.OpenRead(path: fileName))
            {
                return BitConverter.ToString(value: MD5.Create().ComputeHash(inputStream: fileStream))
                    .Replace(oldValue: Resources.dash, newValue: string.Empty);
            }
        }

        /// <summary>
        /// Calculate the MD5 hash value from a text
        /// </summary>
        /// <param name="input">text</param>
        /// <returns>MD5 hash value</returns>
        private static string GetMD5HashFromText(string input)
        {
            byte[] hashBytes = MD5.Create().ComputeHash(buffer: Encoding.ASCII.GetBytes(s: input));
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

        #region Load event handlers

        /// <summary>
        /// Load the form
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatusbarText(text: string.Empty);
            labelProductName.Text = AssemblyInfo.AssemblyProduct;
            labelVersion.Text = AssemblyInfo.AssemblyVersion;
            labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
            labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
            textBoxDescription.Text = AssemblyInfo.AssemblyDescription;

            buttonCopyMD5StringFromTextToClipboard.Enabled = false;
        }

        #endregion

        #region Enter event handlers

        /// <summary>
        /// Detect the accessibility description to set as information text in the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameter <paramref name="e"/> is not needed, but must be indicated.</remarks>
        private void SetStatusbar_Enter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox textBox:
                    SetStatusbarText(text: textBox.AccessibleDescription);
                    break;
                case Button button:
                    SetStatusbarText(text: button.AccessibleDescription);
                    break;
                case RadioButton radioButton:
                    SetStatusbarText(text: radioButton.AccessibleDescription);
                    break;
                case CheckBox checkBox:
                    SetStatusbarText(text: checkBox.AccessibleDescription);
                    break;
                case DateTimePicker dateTimePicker:
                    SetStatusbarText(text: dateTimePicker.AccessibleDescription);
                    break;
                case Label label:
                    SetStatusbarText(text: label.AccessibleDescription);
                    break;
                case PictureBox pictureBox:
                    SetStatusbarText(text: pictureBox.AccessibleDescription);
                    break;
                case CheckedListBox checkedListBox:
                    SetStatusbarText(text: checkedListBox.AccessibleDescription);
                    break;
                case ComboBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case DataGridView view:
                    SetStatusbarText(text: view.AccessibleDescription);
                    break;
                case GroupBox group:
                    SetStatusbarText(text: group.AccessibleDescription);
                    break;
                case ListBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case ListView view:
                    SetStatusbarText(text: view.AccessibleDescription);
                    break;
                case MaskedTextBox box:
                    SetStatusbarText(text: box.AccessibleDescription);
                    break;
                case NumericUpDown numericUpDown:
                    SetStatusbarText(text: numericUpDown.AccessibleDescription);
                    break;
                case MonthCalendar monthCalendar:
                    SetStatusbarText(text: monthCalendar.AccessibleDescription);
                    break;
                case PropertyGrid propertyGrid:
                    SetStatusbarText(text: propertyGrid.AccessibleDescription);
                    break;
                case RichTextBox richTextBox:
                    SetStatusbarText(text: richTextBox.AccessibleDescription);
                    break;
                case ScrollBar scrollBar:
                    SetStatusbarText(text: scrollBar.AccessibleDescription);
                    break;
                case TrackBar trackBar:
                    SetStatusbarText(text: trackBar.AccessibleDescription);
                    break;
                case WebBrowser webBrowser:
                    SetStatusbarText(text: webBrowser.AccessibleDescription);
                    break;
                case DomainUpDown domainUpDown:
                    SetStatusbarText(text: domainUpDown.AccessibleDescription);
                    break;
                case ToolStripButton toolStripButton:
                    SetStatusbarText(text: toolStripButton.AccessibleDescription);
                    break;
                case ToolStripMenuItem toolStripMenuItem:
                    SetStatusbarText(text: toolStripMenuItem.AccessibleDescription);
                    break;
                case ToolStripLabel toolStripLabel:
                    SetStatusbarText(text: toolStripLabel.AccessibleDescription);
                    break;
                case ToolStripComboBox toolStripComboBox:
                    SetStatusbarText(text: toolStripComboBox.AccessibleDescription);
                    break;
                case ToolStripDropDown toolStripDropDown:
                    SetStatusbarText(text: toolStripDropDown.AccessibleDescription);
                    break;
                case ToolStripDropDownButton toolStripDropDownButton:
                    SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription);
                    break;
                case ToolStripDropDownItem toolStripDropDownItem:
                    SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription);
                    break;
                case ToolStripProgressBar progressBar:
                    SetStatusbarText(text: progressBar.AccessibleDescription);
                    break;
                case ToolStripSeparator toolStripSeparator:
                    SetStatusbarText(text: toolStripSeparator.AccessibleDescription);
                    break;
                case ToolStripTextBox toolStripTextBox:
                    SetStatusbarText(text: toolStripTextBox.AccessibleDescription);
                    break;
            }
        }

        #endregion

        #region Leave event handlers

        /// <summary>
        /// Clear the information text of the status bar
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

        #endregion

        #region Click event handlers

        /// <summary>
        /// Open a url with the default web browser
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void LinkLabelUrl_Click(object sender, EventArgs e) => OpenUrl(url: linkLabelUrl.Text);

        /// <summary>
        /// Open a file and calculate all hash values
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonOpenAndCalculateFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog.FileName;
                CalculateHashesFromFile();
            }
        }

        /// <summary>
        /// Calculate the hash values from a string
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCalculateHashFromText_Click(object sender, EventArgs e) => CalculateHashesFromText();

        /// <summary>
        /// Copy the MD5 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopyMD5StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxMD5StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxMD5StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the MD5 hash value from a text to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopyMD5StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxMD5StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxMD5StringFromText.Text);
            }
        }

        /// <summary>
        /// Copy the RIPEMD160 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopyRIPEMD160StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxRIPEMD160StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxRIPEMD160StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the RIPEMD160 hash value from a text to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopyRIPEMD160StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxRIPEMD160StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxRIPEMD160StringFromText.Text);
            }
        }

        /// <summary>
        /// Copy the SHA1 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA1StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA1StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxSHA1StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the SHA1 hash value from a text to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA1StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA1StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxSHA1StringFromText.Text);
            }
        }

        /// <summary>
        /// Copy the SHA512 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA256StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA256StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxSHA256StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the SHA hash value from a text to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA256StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA256StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxSHA256StringFromText.Text);
            }
        }

        /// <summary>
        /// Copy the SHA384 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA384StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA384StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxSHA384StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the SHA384 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA384StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA384StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxSHA384StringFromText.Text);
            }
        }

        /// <summary>
        /// Copy the SHA512 hash value from a file to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA512StringFromFileToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA512StringFromFile.Text))
            {
                Clipboard.SetText(text: textBoxSHA512StringFromFile.Text);
            }
        }

        /// <summary>
        /// Copy the SHA512 hash value from a text to the clipboard
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonCopySHA512StringFromTextToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxSHA512StringFromText.Text))
            {
                Clipboard.SetText(text: textBoxSHA512StringFromText.Text);
            }
        }

        /// <summary>
        /// Save the MD5 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveMD5StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.md5FileExt,
            hashValue: textBoxMD5StringFromFile.Text);

        /// <summary>
        /// Save the RIPEMD160 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveRIPEMD160ToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.ripemd160FileExt,
            hashValue: textBoxRIPEMD160StringFromFile.Text);

        /// <summary>
        /// Save the SHA1 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha1FileExt,
            hashValue: textBoxSHA1StringFromFile.Text);

        /// <summary>
        /// Save the SHA256 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha256FileExt,
            hashValue: textBoxSHA256StringFromFile.Text);

        /// <summary>
        /// Save the SHA384 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha384FileExt,
            hashValue: textBoxSHA384StringFromFile.Text);

        /// <summary>
        /// Save the SHA512 hash value to a file
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
            hashFileExtension: Resources.sha512FileExt,
            hashValue: textBoxSHA512StringFromFile.Text);

        #endregion

        #region CheckedChange event handlers

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void CheckBoxAutoUpdateText_CheckedChanged(object sender, EventArgs e) => buttonCalculateHashFromText.Enabled =
            !buttonCalculateHashFromText.Enabled;

        #endregion

        #region DragDrop event handlers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
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
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
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
        /// <param name="sender">object sender</param>
        /// <param name="e">event arguments</param>
        /// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
        private void TextBoxText_KeyPress(object sender, EventArgs e)
        {
            if (checkBoxAutoUpdateText.Checked)
            {
                CalculateHashesFromText();
            }
        }

        #endregion

        private void TextBoxMD5StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxRIPEMD160StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA1StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA256StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA384StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA512StringFromFile_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxMD5StringFromText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(value: textBoxMD5StringFromText.Text))
            {
                buttonCopyMD5StringFromTextToClipboard.Enabled = true;
            }
            else
            {
                buttonCopyMD5StringFromTextToClipboard.Enabled = false;
            }

        }

        private void TextBoxRIPEMD160StringFromText_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA1StringFromText_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA256StringFromText_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA384StringFromText_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSHA512StringFromText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}