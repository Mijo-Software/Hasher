using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace HashLister
{
	public partial class HashListerForm : Form
	{
		private string statusBarBackup = string.Empty;

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Constructor
		/// </summary>
		public HashListerForm() => InitializeComponent();

		private void HasListerForm_Load(object sender, EventArgs e)
		{
			toolStripStatusLabelInformation.Visible = false;
			toolStripProgressBar.Visible = false;
			toolStripStatusLabelCancel.Visible = false;
		}

		private string Statusbar
		{
			get
			{
				return toolStripStatusLabelInformation.Text;
			}
			set
			{
				statusBarBackup = toolStripStatusLabelInformation.Text;
				toolStripStatusLabelInformation.Text = value;
			}
		}

		private void AddFiles()
		{
		}

		private void AddFolder()
		{
			if (backgroundWorker.IsBusy)
			{
				backgroundWorker.CancelAsync();
			}
			else
			{
				backgroundWorker.RunWorkerAsync(toolStripProgressBar.Value);
			}
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				toolStripStatusLabelInformation.Visible = true;
				Statusbar = "Scanning...";
				toolStripProgressBar.Visible = true;
				toolStripProgressBar.Style = ProgressBarStyle.Marquee;
				string path = folderBrowserDialog.SelectedPath;
				List<string> files = new List<string>();
				getFilesRecursive(sDir: path);
				void getFilesRecursive(string sDir)
				{
					try
					{
						foreach (string d in Directory.GetDirectories(path: sDir))
						{
							getFilesRecursive(sDir: d);
						}
						foreach (string file in Directory.GetFiles(path: sDir))
						{
							//This is where you would manipulate each file found, e.g.:
							DoAction(filepath: file);
						}
					}
					catch (Exception e)
					{
						//MessageBox.Show(e.Message);
						Console.WriteLine(value: e.Message);
					}
				}

				void DoAction(string filepath)
				{
					files.Add(filepath);
					Statusbar = files.Capacity.ToString(provider: culture) + " files found.";
					//Application.DoEvents();
				}

				//string path = folderBrowserDialog.SelectedPath;
				//string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);

				toolStripProgressBar.Visible = false;
				Statusbar = files.Capacity.ToString(provider: culture) + " files found.";
			}
		}

		private void ClearList()
		{
		}

		private void DoRefresh()
		{
		}

		private void SaveItemAsText()
		{
		}

		private void SaveItemAsCsv()
		{
		}

		private void SaveItemAsHtml()
		{
		}

		private void ShowProperties()
		{
		}

		private void Exit() => Close();

		private void ShowAbout()
		{
			using (AboutBox aboutBox = new AboutBox())
			{
				aboutBox.ShowDialog();
			}
		}

		private void ToolStripButtonAddFiles_Click(object sender, EventArgs e) => AddFiles();

		private void ToolStripButtonAddFolder_Click(object sender, EventArgs e) => AddFolder();

		private void ToolStripButtonClearAll_Click(object sender, EventArgs e) => ClearList();

		private void ToolStripButtonRefresh_Click(object sender, EventArgs e) => DoRefresh();

		private void ToolStripButtonProperties_Click(object sender, EventArgs e) => ShowProperties();

		private void ToolStripButtonExit_Click(object sender, EventArgs e) => Exit();

		private void ToolStripStatusLabelCancel_Click(object sender, EventArgs e)
		{
		}

		private void ToolStripMenuItemAddFiles_Click(object sender, EventArgs e) => AddFiles();

		private void ToolStripMenuItemAddFolder_Click(object sender, EventArgs e) => AddFolder();

		private void ToolStripSplitButtonSaveItem_ButtonClick(object sender, EventArgs e) => SaveItemAsText();

		private void ToolStripMenuItemSaveItemAsText_Click(object sender, EventArgs e) => SaveItemAsText();

		private void ToolStripMenuItemSaveItemAsCsv_Click(object sender, EventArgs e) => SaveItemAsCsv();

		private void ToolStripMenuItemSaveItemAsHtml_Click(object sender, EventArgs e) => SaveItemAsHtml();

		private void ToolStripMenuItemSaveAsText_Click(object sender, EventArgs e) => SaveItemAsText();

		private void ToolStripMenuItemSaveAsCsv_Click(object sender, EventArgs e) => SaveItemAsCsv();

		private void ToolStripMenuItemSaveAsHtml_Click(object sender, EventArgs e) => SaveItemAsHtml();

		private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e) => ShowProperties();

		private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Exit();

		private void ToolStripMenuItemRefresh_Click(object sender, EventArgs e) => DoRefresh();

		private void ToolStripMenuItemClearList_Click(object sender, EventArgs e) => ClearList();

		private void ToolStripMenuItemAbout_Click(object sender, EventArgs e) => ShowAbout();

		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) => AddFolder();
	}
}
