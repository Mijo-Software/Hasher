
namespace Hasher
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelFileName = new System.Windows.Forms.Label();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.labelMD5StringFromFile = new System.Windows.Forms.Label();
			this.textBoxMD5StringFromFile = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.textBoxRIPEMD160StringFromFile = new System.Windows.Forms.TextBox();
			this.labelRIPEMD160StringFromFile = new System.Windows.Forms.Label();
			this.textBoxSHA1StringFromFile = new System.Windows.Forms.TextBox();
			this.labelSHA1StringFromFile = new System.Windows.Forms.Label();
			this.textBoxSHA256StringFromFile = new System.Windows.Forms.TextBox();
			this.labelSHA256StringFromFile = new System.Windows.Forms.Label();
			this.textBoxSHA384StringFromFile = new System.Windows.Forms.TextBox();
			this.labelSHA384FromFile = new System.Windows.Forms.Label();
			this.textBoxSHA512StringFromFile = new System.Windows.Forms.TextBox();
			this.labelSHA512StringFromFile = new System.Windows.Forms.Label();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.buttonShowFileProperties = new System.Windows.Forms.Button();
			this.buttonSaveSHA512StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA384StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA256StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA1StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveRIPEMD160ToFile = new System.Windows.Forms.Button();
			this.buttonSaveMD5StringToFile = new System.Windows.Forms.Button();
			this.buttonCopySHA512StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA384StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA256StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA1StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonCopyRIPEMD160StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonCopyMD5StringFromFileToClipboard = new System.Windows.Forms.Button();
			this.buttonOpenAndCalculateHashFromFile = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageFile = new System.Windows.Forms.TabPage();
			this.tabPageText = new System.Windows.Forms.TabPage();
			this.labelText = new System.Windows.Forms.Label();
			this.textBoxText = new System.Windows.Forms.TextBox();
			this.buttonCalculateHashFromText = new System.Windows.Forms.Button();
			this.labelMD5StringFromText = new System.Windows.Forms.Label();
			this.textBoxMD5StringFromText = new System.Windows.Forms.TextBox();
			this.buttonCopyMD5StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.labelRIPEMD160StringFromText = new System.Windows.Forms.Label();
			this.textBoxRIPEMD160StringFromText = new System.Windows.Forms.TextBox();
			this.buttonCopySHA512StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.buttonCopyRIPEMD160StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.textBoxSHA512StringFromText = new System.Windows.Forms.TextBox();
			this.labelSHA1StringFromText = new System.Windows.Forms.Label();
			this.labelSHA512StringFromText = new System.Windows.Forms.Label();
			this.textBoxSHA1StringFromText = new System.Windows.Forms.TextBox();
			this.buttonCopySHA384StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA1StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.textBoxSHA384StringFromText = new System.Windows.Forms.TextBox();
			this.labelSHA256StringFromText = new System.Windows.Forms.Label();
			this.labelSHA384StringFromText = new System.Windows.Forms.Label();
			this.textBoxSHA256StringFromText = new System.Windows.Forms.TextBox();
			this.buttonCopySHA256StringFromTextToClipboard = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageFile.SuspendLayout();
			this.tabPageText.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelFileName
			// 
			this.labelFileName.AutoSize = true;
			this.labelFileName.Location = new System.Drawing.Point(7, 12);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(26, 13);
			this.labelFileName.TabIndex = 0;
			this.labelFileName.Text = "File:";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(39, 9);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.ReadOnly = true;
			this.textBoxFileName.Size = new System.Drawing.Size(311, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// labelMD5StringFromFile
			// 
			this.labelMD5StringFromFile.AutoSize = true;
			this.labelMD5StringFromFile.Location = new System.Drawing.Point(7, 42);
			this.labelMD5StringFromFile.Name = "labelMD5StringFromFile";
			this.labelMD5StringFromFile.Size = new System.Drawing.Size(33, 13);
			this.labelMD5StringFromFile.TabIndex = 4;
			this.labelMD5StringFromFile.Text = "MD5:";
			// 
			// textBoxMD5StringFromFile
			// 
			this.textBoxMD5StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMD5StringFromFile.Location = new System.Drawing.Point(83, 39);
			this.textBoxMD5StringFromFile.Name = "textBoxMD5StringFromFile";
			this.textBoxMD5StringFromFile.ReadOnly = true;
			this.textBoxMD5StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxMD5StringFromFile.TabIndex = 5;
			// 
			// openFileDialog
			// 
			this.openFileDialog.SupportMultiDottedExtensions = true;
			this.openFileDialog.Title = "Load file";
			// 
			// textBoxRIPEMD160StringFromFile
			// 
			this.textBoxRIPEMD160StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRIPEMD160StringFromFile.Location = new System.Drawing.Point(83, 65);
			this.textBoxRIPEMD160StringFromFile.Name = "textBoxRIPEMD160StringFromFile";
			this.textBoxRIPEMD160StringFromFile.ReadOnly = true;
			this.textBoxRIPEMD160StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxRIPEMD160StringFromFile.TabIndex = 9;
			// 
			// labelRIPEMD160StringFromFile
			// 
			this.labelRIPEMD160StringFromFile.AutoSize = true;
			this.labelRIPEMD160StringFromFile.Location = new System.Drawing.Point(7, 68);
			this.labelRIPEMD160StringFromFile.Name = "labelRIPEMD160StringFromFile";
			this.labelRIPEMD160StringFromFile.Size = new System.Drawing.Size(70, 13);
			this.labelRIPEMD160StringFromFile.TabIndex = 8;
			this.labelRIPEMD160StringFromFile.Text = "RIPEMD160:";
			// 
			// textBoxSHA1StringFromFile
			// 
			this.textBoxSHA1StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA1StringFromFile.Location = new System.Drawing.Point(83, 91);
			this.textBoxSHA1StringFromFile.Name = "textBoxSHA1StringFromFile";
			this.textBoxSHA1StringFromFile.ReadOnly = true;
			this.textBoxSHA1StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxSHA1StringFromFile.TabIndex = 13;
			// 
			// labelSHA1StringFromFile
			// 
			this.labelSHA1StringFromFile.AutoSize = true;
			this.labelSHA1StringFromFile.Location = new System.Drawing.Point(7, 94);
			this.labelSHA1StringFromFile.Name = "labelSHA1StringFromFile";
			this.labelSHA1StringFromFile.Size = new System.Drawing.Size(38, 13);
			this.labelSHA1StringFromFile.TabIndex = 12;
			this.labelSHA1StringFromFile.Text = "SHA1:";
			// 
			// textBoxSHA256StringFromFile
			// 
			this.textBoxSHA256StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA256StringFromFile.Location = new System.Drawing.Point(83, 117);
			this.textBoxSHA256StringFromFile.Name = "textBoxSHA256StringFromFile";
			this.textBoxSHA256StringFromFile.ReadOnly = true;
			this.textBoxSHA256StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxSHA256StringFromFile.TabIndex = 17;
			// 
			// labelSHA256StringFromFile
			// 
			this.labelSHA256StringFromFile.AutoSize = true;
			this.labelSHA256StringFromFile.Location = new System.Drawing.Point(7, 120);
			this.labelSHA256StringFromFile.Name = "labelSHA256StringFromFile";
			this.labelSHA256StringFromFile.Size = new System.Drawing.Size(50, 13);
			this.labelSHA256StringFromFile.TabIndex = 16;
			this.labelSHA256StringFromFile.Text = "SHA256:";
			// 
			// textBoxSHA384StringFromFile
			// 
			this.textBoxSHA384StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA384StringFromFile.Location = new System.Drawing.Point(83, 143);
			this.textBoxSHA384StringFromFile.Name = "textBoxSHA384StringFromFile";
			this.textBoxSHA384StringFromFile.ReadOnly = true;
			this.textBoxSHA384StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxSHA384StringFromFile.TabIndex = 21;
			// 
			// labelSHA384FromFile
			// 
			this.labelSHA384FromFile.AutoSize = true;
			this.labelSHA384FromFile.Location = new System.Drawing.Point(7, 146);
			this.labelSHA384FromFile.Name = "labelSHA384FromFile";
			this.labelSHA384FromFile.Size = new System.Drawing.Size(50, 13);
			this.labelSHA384FromFile.TabIndex = 20;
			this.labelSHA384FromFile.Text = "SHA384:";
			// 
			// textBoxSHA512StringFromFile
			// 
			this.textBoxSHA512StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA512StringFromFile.Location = new System.Drawing.Point(83, 169);
			this.textBoxSHA512StringFromFile.Name = "textBoxSHA512StringFromFile";
			this.textBoxSHA512StringFromFile.ReadOnly = true;
			this.textBoxSHA512StringFromFile.Size = new System.Drawing.Size(358, 20);
			this.textBoxSHA512StringFromFile.TabIndex = 25;
			// 
			// labelSHA512StringFromFile
			// 
			this.labelSHA512StringFromFile.AutoSize = true;
			this.labelSHA512StringFromFile.Location = new System.Drawing.Point(7, 172);
			this.labelSHA512StringFromFile.Name = "labelSHA512StringFromFile";
			this.labelSHA512StringFromFile.Size = new System.Drawing.Size(50, 13);
			this.labelSHA512StringFromFile.TabIndex = 24;
			this.labelSHA512StringFromFile.Text = "SHA512:";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.SupportMultiDottedExtensions = true;
			this.saveFileDialog.Title = "Save hash value to file";
			// 
			// buttonShowFileProperties
			// 
			this.buttonShowFileProperties.Image = global::Hasher.Properties.Resources.fatcow_document_info_16;
			this.buttonShowFileProperties.Location = new System.Drawing.Point(471, 6);
			this.buttonShowFileProperties.Name = "buttonShowFileProperties";
			this.buttonShowFileProperties.Size = new System.Drawing.Size(24, 24);
			this.buttonShowFileProperties.TabIndex = 3;
			this.buttonShowFileProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonShowFileProperties.UseVisualStyleBackColor = true;
			this.buttonShowFileProperties.Click += new System.EventHandler(this.ButtonShowFileProperties_Click);
			// 
			// buttonSaveSHA512StringToFile
			// 
			this.buttonSaveSHA512StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA512StringToFile.Image")));
			this.buttonSaveSHA512StringToFile.Location = new System.Drawing.Point(471, 166);
			this.buttonSaveSHA512StringToFile.Name = "buttonSaveSHA512StringToFile";
			this.buttonSaveSHA512StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveSHA512StringToFile.TabIndex = 27;
			this.buttonSaveSHA512StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveSHA512StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveSHA512StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA512StringToFile_Click);
			// 
			// buttonSaveSHA384StringToFile
			// 
			this.buttonSaveSHA384StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA384StringToFile.Image")));
			this.buttonSaveSHA384StringToFile.Location = new System.Drawing.Point(471, 140);
			this.buttonSaveSHA384StringToFile.Name = "buttonSaveSHA384StringToFile";
			this.buttonSaveSHA384StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveSHA384StringToFile.TabIndex = 23;
			this.buttonSaveSHA384StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveSHA384StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveSHA384StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA384StringToFile_Click);
			// 
			// buttonSaveSHA256StringToFile
			// 
			this.buttonSaveSHA256StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA256StringToFile.Image")));
			this.buttonSaveSHA256StringToFile.Location = new System.Drawing.Point(471, 114);
			this.buttonSaveSHA256StringToFile.Name = "buttonSaveSHA256StringToFile";
			this.buttonSaveSHA256StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveSHA256StringToFile.TabIndex = 19;
			this.buttonSaveSHA256StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveSHA256StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveSHA256StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA256StringToFile_Click);
			// 
			// buttonSaveSHA1StringToFile
			// 
			this.buttonSaveSHA1StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA1StringToFile.Image")));
			this.buttonSaveSHA1StringToFile.Location = new System.Drawing.Point(471, 88);
			this.buttonSaveSHA1StringToFile.Name = "buttonSaveSHA1StringToFile";
			this.buttonSaveSHA1StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveSHA1StringToFile.TabIndex = 15;
			this.buttonSaveSHA1StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveSHA1StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveSHA1StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA1StringToFile_Click);
			// 
			// buttonSaveRIPEMD160ToFile
			// 
			this.buttonSaveRIPEMD160ToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveRIPEMD160ToFile.Image")));
			this.buttonSaveRIPEMD160ToFile.Location = new System.Drawing.Point(471, 62);
			this.buttonSaveRIPEMD160ToFile.Name = "buttonSaveRIPEMD160ToFile";
			this.buttonSaveRIPEMD160ToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveRIPEMD160ToFile.TabIndex = 11;
			this.buttonSaveRIPEMD160ToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveRIPEMD160ToFile.UseVisualStyleBackColor = true;
			this.buttonSaveRIPEMD160ToFile.Click += new System.EventHandler(this.ButtonSaveRIPEMD160ToFile_Click);
			// 
			// buttonSaveMD5StringToFile
			// 
			this.buttonSaveMD5StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveMD5StringToFile.Image")));
			this.buttonSaveMD5StringToFile.Location = new System.Drawing.Point(471, 36);
			this.buttonSaveMD5StringToFile.Name = "buttonSaveMD5StringToFile";
			this.buttonSaveMD5StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveMD5StringToFile.TabIndex = 7;
			this.buttonSaveMD5StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveMD5StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveMD5StringToFile.Click += new System.EventHandler(this.ButtonSaveMD5StringToFile_Click);
			// 
			// buttonCopySHA512StringFromFileToClipboard
			// 
			this.buttonCopySHA512StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512StringFromFileToClipboard.Image")));
			this.buttonCopySHA512StringFromFileToClipboard.Location = new System.Drawing.Point(447, 166);
			this.buttonCopySHA512StringFromFileToClipboard.Name = "buttonCopySHA512StringFromFileToClipboard";
			this.buttonCopySHA512StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA512StringFromFileToClipboard.TabIndex = 26;
			this.buttonCopySHA512StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA512StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA512StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA512StringFromFileToClipboard_Click);
			// 
			// buttonCopySHA384StringFromFileToClipboard
			// 
			this.buttonCopySHA384StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384StringFromFileToClipboard.Image")));
			this.buttonCopySHA384StringFromFileToClipboard.Location = new System.Drawing.Point(447, 140);
			this.buttonCopySHA384StringFromFileToClipboard.Name = "buttonCopySHA384StringFromFileToClipboard";
			this.buttonCopySHA384StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA384StringFromFileToClipboard.TabIndex = 22;
			this.buttonCopySHA384StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA384StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA384StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA384StringFromFileToClipboard_Click);
			// 
			// buttonCopySHA256StringFromFileToClipboard
			// 
			this.buttonCopySHA256StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256StringFromFileToClipboard.Image")));
			this.buttonCopySHA256StringFromFileToClipboard.Location = new System.Drawing.Point(447, 114);
			this.buttonCopySHA256StringFromFileToClipboard.Name = "buttonCopySHA256StringFromFileToClipboard";
			this.buttonCopySHA256StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA256StringFromFileToClipboard.TabIndex = 18;
			this.buttonCopySHA256StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA256StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA256StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA256StringFromFileToClipboard_Click);
			// 
			// buttonCopySHA1StringFromFileToClipboard
			// 
			this.buttonCopySHA1StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1StringFromFileToClipboard.Image")));
			this.buttonCopySHA1StringFromFileToClipboard.Location = new System.Drawing.Point(447, 88);
			this.buttonCopySHA1StringFromFileToClipboard.Name = "buttonCopySHA1StringFromFileToClipboard";
			this.buttonCopySHA1StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA1StringFromFileToClipboard.TabIndex = 14;
			this.buttonCopySHA1StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA1StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA1StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1StringFromFileToClipboard_Click);
			// 
			// buttonCopyRIPEMD160StringFromFileToClipboard
			// 
			this.buttonCopyRIPEMD160StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyRIPEMD160StringFromFileToClipboard.Image")));
			this.buttonCopyRIPEMD160StringFromFileToClipboard.Location = new System.Drawing.Point(447, 62);
			this.buttonCopyRIPEMD160StringFromFileToClipboard.Name = "buttonCopyRIPEMD160StringFromFileToClipboard";
			this.buttonCopyRIPEMD160StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyRIPEMD160StringFromFileToClipboard.TabIndex = 10;
			this.buttonCopyRIPEMD160StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyRIPEMD160StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyRIPEMD160StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopyRIPEMD160StringFromFileToClipboard_Click);
			// 
			// buttonCopyMD5StringFromFileToClipboard
			// 
			this.buttonCopyMD5StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5StringFromFileToClipboard.Image")));
			this.buttonCopyMD5StringFromFileToClipboard.Location = new System.Drawing.Point(447, 36);
			this.buttonCopyMD5StringFromFileToClipboard.Name = "buttonCopyMD5StringFromFileToClipboard";
			this.buttonCopyMD5StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyMD5StringFromFileToClipboard.TabIndex = 6;
			this.buttonCopyMD5StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyMD5StringFromFileToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyMD5StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopyMD5StringFromFileToClipboard_Click);
			// 
			// buttonOpenAndCalculateHashFromFile
			// 
			this.buttonOpenAndCalculateHashFromFile.Image = global::Hasher.Properties.Resources.fatcow_document_hash_tag_16;
			this.buttonOpenAndCalculateHashFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonOpenAndCalculateHashFromFile.Location = new System.Drawing.Point(356, 6);
			this.buttonOpenAndCalculateHashFromFile.Name = "buttonOpenAndCalculateHashFromFile";
			this.buttonOpenAndCalculateHashFromFile.Size = new System.Drawing.Size(115, 24);
			this.buttonOpenAndCalculateHashFromFile.TabIndex = 2;
			this.buttonOpenAndCalculateHashFromFile.Text = "Open && Calculate";
			this.buttonOpenAndCalculateHashFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonOpenAndCalculateHashFromFile.UseVisualStyleBackColor = true;
			this.buttonOpenAndCalculateHashFromFile.Click += new System.EventHandler(this.OpenAndCalculateFile_Click);
			// 
			// tabControl
			// 
			this.tabControl.AllowDrop = true;
			this.tabControl.Controls.Add(this.tabPageFile);
			this.tabControl.Controls.Add(this.tabPageText);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.HotTrack = true;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.ShowToolTips = true;
			this.tabControl.Size = new System.Drawing.Size(511, 219);
			this.tabControl.TabIndex = 0;
			this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.tabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			// 
			// tabPageFile
			// 
			this.tabPageFile.Controls.Add(this.labelFileName);
			this.tabPageFile.Controls.Add(this.buttonShowFileProperties);
			this.tabPageFile.Controls.Add(this.textBoxFileName);
			this.tabPageFile.Controls.Add(this.buttonSaveSHA512StringToFile);
			this.tabPageFile.Controls.Add(this.buttonOpenAndCalculateHashFromFile);
			this.tabPageFile.Controls.Add(this.buttonSaveSHA384StringToFile);
			this.tabPageFile.Controls.Add(this.labelMD5StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonSaveSHA256StringToFile);
			this.tabPageFile.Controls.Add(this.textBoxMD5StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonSaveSHA1StringToFile);
			this.tabPageFile.Controls.Add(this.buttonCopyMD5StringFromFileToClipboard);
			this.tabPageFile.Controls.Add(this.buttonSaveRIPEMD160ToFile);
			this.tabPageFile.Controls.Add(this.labelRIPEMD160StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonSaveMD5StringToFile);
			this.tabPageFile.Controls.Add(this.textBoxRIPEMD160StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonCopySHA512StringFromFileToClipboard);
			this.tabPageFile.Controls.Add(this.buttonCopyRIPEMD160StringFromFileToClipboard);
			this.tabPageFile.Controls.Add(this.textBoxSHA512StringFromFile);
			this.tabPageFile.Controls.Add(this.labelSHA1StringFromFile);
			this.tabPageFile.Controls.Add(this.labelSHA512StringFromFile);
			this.tabPageFile.Controls.Add(this.textBoxSHA1StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonCopySHA384StringFromFileToClipboard);
			this.tabPageFile.Controls.Add(this.buttonCopySHA1StringFromFileToClipboard);
			this.tabPageFile.Controls.Add(this.textBoxSHA384StringFromFile);
			this.tabPageFile.Controls.Add(this.labelSHA256StringFromFile);
			this.tabPageFile.Controls.Add(this.labelSHA384FromFile);
			this.tabPageFile.Controls.Add(this.textBoxSHA256StringFromFile);
			this.tabPageFile.Controls.Add(this.buttonCopySHA256StringFromFileToClipboard);
			this.tabPageFile.Location = new System.Drawing.Point(4, 22);
			this.tabPageFile.Name = "tabPageFile";
			this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFile.Size = new System.Drawing.Size(503, 193);
			this.tabPageFile.TabIndex = 0;
			this.tabPageFile.Text = "File";
			this.tabPageFile.UseVisualStyleBackColor = true;
			// 
			// tabPageText
			// 
			this.tabPageText.Controls.Add(this.labelText);
			this.tabPageText.Controls.Add(this.textBoxText);
			this.tabPageText.Controls.Add(this.buttonCalculateHashFromText);
			this.tabPageText.Controls.Add(this.labelMD5StringFromText);
			this.tabPageText.Controls.Add(this.textBoxMD5StringFromText);
			this.tabPageText.Controls.Add(this.buttonCopyMD5StringFromTextToClipboard);
			this.tabPageText.Controls.Add(this.labelRIPEMD160StringFromText);
			this.tabPageText.Controls.Add(this.textBoxRIPEMD160StringFromText);
			this.tabPageText.Controls.Add(this.buttonCopySHA512StringFromTextToClipboard);
			this.tabPageText.Controls.Add(this.buttonCopyRIPEMD160StringFromTextToClipboard);
			this.tabPageText.Controls.Add(this.textBoxSHA512StringFromText);
			this.tabPageText.Controls.Add(this.labelSHA1StringFromText);
			this.tabPageText.Controls.Add(this.labelSHA512StringFromText);
			this.tabPageText.Controls.Add(this.textBoxSHA1StringFromText);
			this.tabPageText.Controls.Add(this.buttonCopySHA384StringFromTextToClipboard);
			this.tabPageText.Controls.Add(this.buttonCopySHA1StringFromTextToClipboard);
			this.tabPageText.Controls.Add(this.textBoxSHA384StringFromText);
			this.tabPageText.Controls.Add(this.labelSHA256StringFromText);
			this.tabPageText.Controls.Add(this.labelSHA384StringFromText);
			this.tabPageText.Controls.Add(this.textBoxSHA256StringFromText);
			this.tabPageText.Controls.Add(this.buttonCopySHA256StringFromTextToClipboard);
			this.tabPageText.Location = new System.Drawing.Point(4, 22);
			this.tabPageText.Name = "tabPageText";
			this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageText.Size = new System.Drawing.Size(503, 193);
			this.tabPageText.TabIndex = 1;
			this.tabPageText.Text = "Text";
			this.tabPageText.UseVisualStyleBackColor = true;
			// 
			// labelText
			// 
			this.labelText.AutoSize = true;
			this.labelText.Location = new System.Drawing.Point(7, 12);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(31, 13);
			this.labelText.TabIndex = 0;
			this.labelText.Text = "Text:";
			// 
			// textBoxText
			// 
			this.textBoxText.Location = new System.Drawing.Point(44, 9);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(365, 20);
			this.textBoxText.TabIndex = 1;
			// 
			// buttonCalculateHashFromText
			// 
			this.buttonCalculateHashFromText.Image = global::Hasher.Properties.Resources.fatcow_document_hash_tag_16;
			this.buttonCalculateHashFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCalculateHashFromText.Location = new System.Drawing.Point(415, 6);
			this.buttonCalculateHashFromText.Name = "buttonCalculateHashFromText";
			this.buttonCalculateHashFromText.Size = new System.Drawing.Size(80, 24);
			this.buttonCalculateHashFromText.TabIndex = 2;
			this.buttonCalculateHashFromText.Text = "Calculate";
			this.buttonCalculateHashFromText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCalculateHashFromText.UseVisualStyleBackColor = true;
			this.buttonCalculateHashFromText.Click += new System.EventHandler(this.ButtonCalculateHashFromText_Click);
			// 
			// labelMD5StringFromText
			// 
			this.labelMD5StringFromText.AutoSize = true;
			this.labelMD5StringFromText.Location = new System.Drawing.Point(7, 42);
			this.labelMD5StringFromText.Name = "labelMD5StringFromText";
			this.labelMD5StringFromText.Size = new System.Drawing.Size(33, 13);
			this.labelMD5StringFromText.TabIndex = 3;
			this.labelMD5StringFromText.Text = "MD5:";
			// 
			// textBoxMD5StringFromText
			// 
			this.textBoxMD5StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMD5StringFromText.Location = new System.Drawing.Point(83, 39);
			this.textBoxMD5StringFromText.Name = "textBoxMD5StringFromText";
			this.textBoxMD5StringFromText.ReadOnly = true;
			this.textBoxMD5StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxMD5StringFromText.TabIndex = 4;
			// 
			// buttonCopyMD5StringFromTextToClipboard
			// 
			this.buttonCopyMD5StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5StringFromTextToClipboard.Image")));
			this.buttonCopyMD5StringFromTextToClipboard.Location = new System.Drawing.Point(471, 36);
			this.buttonCopyMD5StringFromTextToClipboard.Name = "buttonCopyMD5StringFromTextToClipboard";
			this.buttonCopyMD5StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyMD5StringFromTextToClipboard.TabIndex = 5;
			this.buttonCopyMD5StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyMD5StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyMD5StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopyMD5StringFromTextToClipboard_Click);
			// 
			// labelRIPEMD160StringFromText
			// 
			this.labelRIPEMD160StringFromText.AutoSize = true;
			this.labelRIPEMD160StringFromText.Location = new System.Drawing.Point(7, 68);
			this.labelRIPEMD160StringFromText.Name = "labelRIPEMD160StringFromText";
			this.labelRIPEMD160StringFromText.Size = new System.Drawing.Size(70, 13);
			this.labelRIPEMD160StringFromText.TabIndex = 6;
			this.labelRIPEMD160StringFromText.Text = "RIPEMD160:";
			// 
			// textBoxRIPEMD160StringFromText
			// 
			this.textBoxRIPEMD160StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRIPEMD160StringFromText.Location = new System.Drawing.Point(83, 65);
			this.textBoxRIPEMD160StringFromText.Name = "textBoxRIPEMD160StringFromText";
			this.textBoxRIPEMD160StringFromText.ReadOnly = true;
			this.textBoxRIPEMD160StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxRIPEMD160StringFromText.TabIndex = 7;
			// 
			// buttonCopySHA512StringFromTextToClipboard
			// 
			this.buttonCopySHA512StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512StringFromTextToClipboard.Image")));
			this.buttonCopySHA512StringFromTextToClipboard.Location = new System.Drawing.Point(471, 166);
			this.buttonCopySHA512StringFromTextToClipboard.Name = "buttonCopySHA512StringFromTextToClipboard";
			this.buttonCopySHA512StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA512StringFromTextToClipboard.TabIndex = 20;
			this.buttonCopySHA512StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA512StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA512StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA512StringFromTextToClipboard_Click);
			// 
			// buttonCopyRIPEMD160StringFromTextToClipboard
			// 
			this.buttonCopyRIPEMD160StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyRIPEMD160StringFromTextToClipboard.Image")));
			this.buttonCopyRIPEMD160StringFromTextToClipboard.Location = new System.Drawing.Point(471, 62);
			this.buttonCopyRIPEMD160StringFromTextToClipboard.Name = "buttonCopyRIPEMD160StringFromTextToClipboard";
			this.buttonCopyRIPEMD160StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyRIPEMD160StringFromTextToClipboard.TabIndex = 8;
			this.buttonCopyRIPEMD160StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyRIPEMD160StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyRIPEMD160StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopyRIPEMD160StringFromTextToClipboard_Click);
			// 
			// textBoxSHA512StringFromText
			// 
			this.textBoxSHA512StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA512StringFromText.Location = new System.Drawing.Point(83, 169);
			this.textBoxSHA512StringFromText.Name = "textBoxSHA512StringFromText";
			this.textBoxSHA512StringFromText.ReadOnly = true;
			this.textBoxSHA512StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxSHA512StringFromText.TabIndex = 19;
			// 
			// labelSHA1StringFromText
			// 
			this.labelSHA1StringFromText.AutoSize = true;
			this.labelSHA1StringFromText.Location = new System.Drawing.Point(7, 94);
			this.labelSHA1StringFromText.Name = "labelSHA1StringFromText";
			this.labelSHA1StringFromText.Size = new System.Drawing.Size(38, 13);
			this.labelSHA1StringFromText.TabIndex = 9;
			this.labelSHA1StringFromText.Text = "SHA1:";
			// 
			// labelSHA512StringFromText
			// 
			this.labelSHA512StringFromText.AutoSize = true;
			this.labelSHA512StringFromText.Location = new System.Drawing.Point(7, 172);
			this.labelSHA512StringFromText.Name = "labelSHA512StringFromText";
			this.labelSHA512StringFromText.Size = new System.Drawing.Size(50, 13);
			this.labelSHA512StringFromText.TabIndex = 18;
			this.labelSHA512StringFromText.Text = "SHA512:";
			// 
			// textBoxSHA1StringFromText
			// 
			this.textBoxSHA1StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA1StringFromText.Location = new System.Drawing.Point(83, 91);
			this.textBoxSHA1StringFromText.Name = "textBoxSHA1StringFromText";
			this.textBoxSHA1StringFromText.ReadOnly = true;
			this.textBoxSHA1StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxSHA1StringFromText.TabIndex = 10;
			// 
			// buttonCopySHA384StringFromTextToClipboard
			// 
			this.buttonCopySHA384StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384StringFromTextToClipboard.Image")));
			this.buttonCopySHA384StringFromTextToClipboard.Location = new System.Drawing.Point(471, 140);
			this.buttonCopySHA384StringFromTextToClipboard.Name = "buttonCopySHA384StringFromTextToClipboard";
			this.buttonCopySHA384StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA384StringFromTextToClipboard.TabIndex = 17;
			this.buttonCopySHA384StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA384StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA384StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA384StringFromTextToClipboard_Click);
			// 
			// buttonCopySHA1StringFromTextToClipboard
			// 
			this.buttonCopySHA1StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1StringFromTextToClipboard.Image")));
			this.buttonCopySHA1StringFromTextToClipboard.Location = new System.Drawing.Point(471, 88);
			this.buttonCopySHA1StringFromTextToClipboard.Name = "buttonCopySHA1StringFromTextToClipboard";
			this.buttonCopySHA1StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA1StringFromTextToClipboard.TabIndex = 11;
			this.buttonCopySHA1StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA1StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA1StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1StringFromTextToClipboard_Click);
			// 
			// textBoxSHA384StringFromText
			// 
			this.textBoxSHA384StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA384StringFromText.Location = new System.Drawing.Point(83, 143);
			this.textBoxSHA384StringFromText.Name = "textBoxSHA384StringFromText";
			this.textBoxSHA384StringFromText.ReadOnly = true;
			this.textBoxSHA384StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxSHA384StringFromText.TabIndex = 16;
			// 
			// labelSHA256StringFromText
			// 
			this.labelSHA256StringFromText.AutoSize = true;
			this.labelSHA256StringFromText.Location = new System.Drawing.Point(7, 120);
			this.labelSHA256StringFromText.Name = "labelSHA256StringFromText";
			this.labelSHA256StringFromText.Size = new System.Drawing.Size(50, 13);
			this.labelSHA256StringFromText.TabIndex = 12;
			this.labelSHA256StringFromText.Text = "SHA256:";
			// 
			// labelSHA384StringFromText
			// 
			this.labelSHA384StringFromText.AutoSize = true;
			this.labelSHA384StringFromText.Location = new System.Drawing.Point(7, 146);
			this.labelSHA384StringFromText.Name = "labelSHA384StringFromText";
			this.labelSHA384StringFromText.Size = new System.Drawing.Size(50, 13);
			this.labelSHA384StringFromText.TabIndex = 15;
			this.labelSHA384StringFromText.Text = "SHA384:";
			// 
			// textBoxSHA256StringFromText
			// 
			this.textBoxSHA256StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA256StringFromText.Location = new System.Drawing.Point(83, 117);
			this.textBoxSHA256StringFromText.Name = "textBoxSHA256StringFromText";
			this.textBoxSHA256StringFromText.ReadOnly = true;
			this.textBoxSHA256StringFromText.Size = new System.Drawing.Size(382, 20);
			this.textBoxSHA256StringFromText.TabIndex = 13;
			// 
			// buttonCopySHA256StringFromTextToClipboard
			// 
			this.buttonCopySHA256StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256StringFromTextToClipboard.Image")));
			this.buttonCopySHA256StringFromTextToClipboard.Location = new System.Drawing.Point(471, 114);
			this.buttonCopySHA256StringFromTextToClipboard.Name = "buttonCopySHA256StringFromTextToClipboard";
			this.buttonCopySHA256StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA256StringFromTextToClipboard.TabIndex = 14;
			this.buttonCopySHA256StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA256StringFromTextToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA256StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA256StringFromTextToClipboard_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 219);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasher";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.tabControl.ResumeLayout(false);
			this.tabPageFile.ResumeLayout(false);
			this.tabPageFile.PerformLayout();
			this.tabPageText.ResumeLayout(false);
			this.tabPageText.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Button buttonOpenAndCalculateHashFromFile;
		private System.Windows.Forms.Label labelMD5StringFromFile;
		private System.Windows.Forms.TextBox textBoxMD5StringFromFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonCopyMD5StringFromFileToClipboard;
		private System.Windows.Forms.Button buttonCopyRIPEMD160StringFromFileToClipboard;
		private System.Windows.Forms.TextBox textBoxRIPEMD160StringFromFile;
		private System.Windows.Forms.Label labelRIPEMD160StringFromFile;
		private System.Windows.Forms.Button buttonCopySHA1StringFromFileToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA1StringFromFile;
		private System.Windows.Forms.Label labelSHA1StringFromFile;
		private System.Windows.Forms.Button buttonCopySHA256StringFromFileToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA256StringFromFile;
		private System.Windows.Forms.Label labelSHA256StringFromFile;
		private System.Windows.Forms.Button buttonCopySHA384StringFromFileToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA384StringFromFile;
		private System.Windows.Forms.Label labelSHA384FromFile;
		private System.Windows.Forms.Button buttonCopySHA512StringFromFileToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA512StringFromFile;
		private System.Windows.Forms.Label labelSHA512StringFromFile;
		private System.Windows.Forms.Button buttonSaveSHA512StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA384StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA256StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA1StringToFile;
		private System.Windows.Forms.Button buttonSaveRIPEMD160ToFile;
		private System.Windows.Forms.Button buttonSaveMD5StringToFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button buttonShowFileProperties;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageFile;
		private System.Windows.Forms.TabPage tabPageText;
		private System.Windows.Forms.Label labelText;
		private System.Windows.Forms.TextBox textBoxText;
		private System.Windows.Forms.Button buttonCalculateHashFromText;
		private System.Windows.Forms.Label labelMD5StringFromText;
		private System.Windows.Forms.TextBox textBoxMD5StringFromText;
		private System.Windows.Forms.Button buttonCopyMD5StringFromTextToClipboard;
		private System.Windows.Forms.Label labelRIPEMD160StringFromText;
		private System.Windows.Forms.TextBox textBoxRIPEMD160StringFromText;
		private System.Windows.Forms.Button buttonCopySHA512StringFromTextToClipboard;
		private System.Windows.Forms.Button buttonCopyRIPEMD160StringFromTextToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA512StringFromText;
		private System.Windows.Forms.Label labelSHA1StringFromText;
		private System.Windows.Forms.Label labelSHA512StringFromText;
		private System.Windows.Forms.TextBox textBoxSHA1StringFromText;
		private System.Windows.Forms.Button buttonCopySHA384StringFromTextToClipboard;
		private System.Windows.Forms.Button buttonCopySHA1StringFromTextToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA384StringFromText;
		private System.Windows.Forms.Label labelSHA256StringFromText;
		private System.Windows.Forms.Label labelSHA384StringFromText;
		private System.Windows.Forms.TextBox textBoxSHA256StringFromText;
		private System.Windows.Forms.Button buttonCopySHA256StringFromTextToClipboard;
	}
}

