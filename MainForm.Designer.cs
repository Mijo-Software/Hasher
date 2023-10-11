
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
            this.components = new System.ComponentModel.Container();
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.checkBoxAutoUpdateText = new System.Windows.Forms.CheckBox();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AccessibleDescription = "file";
            this.labelFileName.AccessibleName = "file";
            this.labelFileName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(7, 12);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(26, 13);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "File:";
            this.toolTip.SetToolTip(this.labelFileName, "file");
            this.labelFileName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelFileName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelFileName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelFileName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.AccessibleDescription = "Show the path of the file";
            this.textBoxFileName.AccessibleName = "Path of the file";
            this.textBoxFileName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxFileName.Location = new System.Drawing.Point(39, 9);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(335, 20);
            this.textBoxFileName.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxFileName, "Path of the file");
            this.textBoxFileName.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxFileName.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxFileName.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxFileName.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelMD5StringFromFile
            // 
            this.labelMD5StringFromFile.AccessibleDescription = "MD5";
            this.labelMD5StringFromFile.AccessibleName = "MD5";
            this.labelMD5StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelMD5StringFromFile.AutoSize = true;
            this.labelMD5StringFromFile.Location = new System.Drawing.Point(7, 42);
            this.labelMD5StringFromFile.Name = "labelMD5StringFromFile";
            this.labelMD5StringFromFile.Size = new System.Drawing.Size(33, 13);
            this.labelMD5StringFromFile.TabIndex = 4;
            this.labelMD5StringFromFile.Text = "MD5:";
            this.toolTip.SetToolTip(this.labelMD5StringFromFile, "MD5 hash");
            this.labelMD5StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelMD5StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelMD5StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelMD5StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxMD5StringFromFile
            // 
            this.textBoxMD5StringFromFile.AccessibleDescription = "Show the MD5 hash value";
            this.textBoxMD5StringFromFile.AccessibleName = "MD5 hash value";
            this.textBoxMD5StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxMD5StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMD5StringFromFile.Location = new System.Drawing.Point(83, 39);
            this.textBoxMD5StringFromFile.Name = "textBoxMD5StringFromFile";
            this.textBoxMD5StringFromFile.ReadOnly = true;
            this.textBoxMD5StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxMD5StringFromFile.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxMD5StringFromFile, "MD5 hash value");
            this.textBoxMD5StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxMD5StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxMD5StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxMD5StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // openFileDialog
            // 
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Load file";
            // 
            // textBoxRIPEMD160StringFromFile
            // 
            this.textBoxRIPEMD160StringFromFile.AccessibleDescription = "Show the RIPEMD160 hash value";
            this.textBoxRIPEMD160StringFromFile.AccessibleName = "RIPEMD160 hash value";
            this.textBoxRIPEMD160StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxRIPEMD160StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRIPEMD160StringFromFile.Location = new System.Drawing.Point(83, 65);
            this.textBoxRIPEMD160StringFromFile.Name = "textBoxRIPEMD160StringFromFile";
            this.textBoxRIPEMD160StringFromFile.ReadOnly = true;
            this.textBoxRIPEMD160StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxRIPEMD160StringFromFile.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxRIPEMD160StringFromFile, "RIPEMD160 hash value");
            this.textBoxRIPEMD160StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxRIPEMD160StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxRIPEMD160StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxRIPEMD160StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelRIPEMD160StringFromFile
            // 
            this.labelRIPEMD160StringFromFile.AccessibleDescription = "RIPEMD160";
            this.labelRIPEMD160StringFromFile.AccessibleName = "RIPEMD160";
            this.labelRIPEMD160StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelRIPEMD160StringFromFile.AutoSize = true;
            this.labelRIPEMD160StringFromFile.Location = new System.Drawing.Point(7, 68);
            this.labelRIPEMD160StringFromFile.Name = "labelRIPEMD160StringFromFile";
            this.labelRIPEMD160StringFromFile.Size = new System.Drawing.Size(70, 13);
            this.labelRIPEMD160StringFromFile.TabIndex = 8;
            this.labelRIPEMD160StringFromFile.Text = "RIPEMD160:";
            this.toolTip.SetToolTip(this.labelRIPEMD160StringFromFile, "RIPEMD160 hash");
            this.labelRIPEMD160StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelRIPEMD160StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelRIPEMD160StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelRIPEMD160StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA1StringFromFile
            // 
            this.textBoxSHA1StringFromFile.AccessibleDescription = "Show the SHA1 hash value";
            this.textBoxSHA1StringFromFile.AccessibleName = "SHA1 hash value";
            this.textBoxSHA1StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA1StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA1StringFromFile.Location = new System.Drawing.Point(83, 91);
            this.textBoxSHA1StringFromFile.Name = "textBoxSHA1StringFromFile";
            this.textBoxSHA1StringFromFile.ReadOnly = true;
            this.textBoxSHA1StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxSHA1StringFromFile.TabIndex = 13;
            this.toolTip.SetToolTip(this.textBoxSHA1StringFromFile, "SHA1 hash value");
            this.textBoxSHA1StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA1StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA1StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA1StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA1StringFromFile
            // 
            this.labelSHA1StringFromFile.AccessibleDescription = "SHA1";
            this.labelSHA1StringFromFile.AccessibleName = "SHA1";
            this.labelSHA1StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA1StringFromFile.AutoSize = true;
            this.labelSHA1StringFromFile.Location = new System.Drawing.Point(7, 94);
            this.labelSHA1StringFromFile.Name = "labelSHA1StringFromFile";
            this.labelSHA1StringFromFile.Size = new System.Drawing.Size(38, 13);
            this.labelSHA1StringFromFile.TabIndex = 12;
            this.labelSHA1StringFromFile.Text = "SHA1:";
            this.toolTip.SetToolTip(this.labelSHA1StringFromFile, "SHA1 hash");
            this.labelSHA1StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA1StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA1StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA1StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA256StringFromFile
            // 
            this.textBoxSHA256StringFromFile.AccessibleDescription = "Show the SHA256 hash value";
            this.textBoxSHA256StringFromFile.AccessibleName = "SHA256 hash value";
            this.textBoxSHA256StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA256StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA256StringFromFile.Location = new System.Drawing.Point(83, 117);
            this.textBoxSHA256StringFromFile.Name = "textBoxSHA256StringFromFile";
            this.textBoxSHA256StringFromFile.ReadOnly = true;
            this.textBoxSHA256StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxSHA256StringFromFile.TabIndex = 17;
            this.toolTip.SetToolTip(this.textBoxSHA256StringFromFile, "SHA256 hash value");
            this.textBoxSHA256StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA256StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA256StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA256StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA256StringFromFile
            // 
            this.labelSHA256StringFromFile.AccessibleDescription = "SHA256";
            this.labelSHA256StringFromFile.AccessibleName = "SHA256";
            this.labelSHA256StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA256StringFromFile.AutoSize = true;
            this.labelSHA256StringFromFile.Location = new System.Drawing.Point(7, 120);
            this.labelSHA256StringFromFile.Name = "labelSHA256StringFromFile";
            this.labelSHA256StringFromFile.Size = new System.Drawing.Size(50, 13);
            this.labelSHA256StringFromFile.TabIndex = 16;
            this.labelSHA256StringFromFile.Text = "SHA256:";
            this.toolTip.SetToolTip(this.labelSHA256StringFromFile, "SHA256 hash");
            this.labelSHA256StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA256StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA256StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA256StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA384StringFromFile
            // 
            this.textBoxSHA384StringFromFile.AccessibleDescription = "Show the SHA384 hash value";
            this.textBoxSHA384StringFromFile.AccessibleName = "SHA384 hash value";
            this.textBoxSHA384StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA384StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA384StringFromFile.Location = new System.Drawing.Point(83, 143);
            this.textBoxSHA384StringFromFile.Name = "textBoxSHA384StringFromFile";
            this.textBoxSHA384StringFromFile.ReadOnly = true;
            this.textBoxSHA384StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxSHA384StringFromFile.TabIndex = 21;
            this.toolTip.SetToolTip(this.textBoxSHA384StringFromFile, "SHA384 hash value");
            this.textBoxSHA384StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA384StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA384StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA384StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA384FromFile
            // 
            this.labelSHA384FromFile.AccessibleDescription = "SHA384";
            this.labelSHA384FromFile.AccessibleName = "SHA384";
            this.labelSHA384FromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA384FromFile.AutoSize = true;
            this.labelSHA384FromFile.Location = new System.Drawing.Point(7, 146);
            this.labelSHA384FromFile.Name = "labelSHA384FromFile";
            this.labelSHA384FromFile.Size = new System.Drawing.Size(50, 13);
            this.labelSHA384FromFile.TabIndex = 20;
            this.labelSHA384FromFile.Text = "SHA384:";
            this.toolTip.SetToolTip(this.labelSHA384FromFile, "SHA384 hash");
            this.labelSHA384FromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA384FromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA384FromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA384FromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA512StringFromFile
            // 
            this.textBoxSHA512StringFromFile.AccessibleDescription = "Show the SHA512 hash value";
            this.textBoxSHA512StringFromFile.AccessibleName = "SHA512 hash value";
            this.textBoxSHA512StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA512StringFromFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA512StringFromFile.Location = new System.Drawing.Point(83, 169);
            this.textBoxSHA512StringFromFile.Name = "textBoxSHA512StringFromFile";
            this.textBoxSHA512StringFromFile.ReadOnly = true;
            this.textBoxSHA512StringFromFile.Size = new System.Drawing.Size(358, 20);
            this.textBoxSHA512StringFromFile.TabIndex = 25;
            this.toolTip.SetToolTip(this.textBoxSHA512StringFromFile, "SHA512 hash value");
            this.textBoxSHA512StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA512StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA512StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA512StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA512StringFromFile
            // 
            this.labelSHA512StringFromFile.AccessibleDescription = "SHA512";
            this.labelSHA512StringFromFile.AccessibleName = "SHA512";
            this.labelSHA512StringFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA512StringFromFile.AutoSize = true;
            this.labelSHA512StringFromFile.Location = new System.Drawing.Point(7, 172);
            this.labelSHA512StringFromFile.Name = "labelSHA512StringFromFile";
            this.labelSHA512StringFromFile.Size = new System.Drawing.Size(50, 13);
            this.labelSHA512StringFromFile.TabIndex = 24;
            this.labelSHA512StringFromFile.Text = "SHA512:";
            this.toolTip.SetToolTip(this.labelSHA512StringFromFile, "SHA512 hash");
            this.labelSHA512StringFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA512StringFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA512StringFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA512StringFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            this.saveFileDialog.Title = "Save hash value to file";
            // 
            // buttonSaveSHA512StringToFile
            // 
            this.buttonSaveSHA512StringToFile.AccessibleDescription = "Save the SHA512 hash value in a file";
            this.buttonSaveSHA512StringToFile.AccessibleName = "Save SHA512 hash to file";
            this.buttonSaveSHA512StringToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveSHA512StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA512StringToFile.Image")));
            this.buttonSaveSHA512StringToFile.Location = new System.Drawing.Point(471, 166);
            this.buttonSaveSHA512StringToFile.Name = "buttonSaveSHA512StringToFile";
            this.buttonSaveSHA512StringToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveSHA512StringToFile.TabIndex = 27;
            this.buttonSaveSHA512StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveSHA512StringToFile, "Save the SHA512 hash value in a file");
            this.buttonSaveSHA512StringToFile.UseVisualStyleBackColor = true;
            this.buttonSaveSHA512StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA512StringToFile_Click);
            this.buttonSaveSHA512StringToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA512StringToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveSHA512StringToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA512StringToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonSaveSHA384StringToFile
            // 
            this.buttonSaveSHA384StringToFile.AccessibleDescription = "Save the SHA384 hash value in a file";
            this.buttonSaveSHA384StringToFile.AccessibleName = "Save SHA384 hash to file";
            this.buttonSaveSHA384StringToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveSHA384StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA384StringToFile.Image")));
            this.buttonSaveSHA384StringToFile.Location = new System.Drawing.Point(471, 140);
            this.buttonSaveSHA384StringToFile.Name = "buttonSaveSHA384StringToFile";
            this.buttonSaveSHA384StringToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveSHA384StringToFile.TabIndex = 23;
            this.buttonSaveSHA384StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveSHA384StringToFile, "Save the SHA384 hash value in a file");
            this.buttonSaveSHA384StringToFile.UseVisualStyleBackColor = true;
            this.buttonSaveSHA384StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA384StringToFile_Click);
            this.buttonSaveSHA384StringToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA384StringToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveSHA384StringToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA384StringToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonSaveSHA256StringToFile
            // 
            this.buttonSaveSHA256StringToFile.AccessibleDescription = "Save the SHA1 hash value in a file";
            this.buttonSaveSHA256StringToFile.AccessibleName = "Save SHA1 hash to file";
            this.buttonSaveSHA256StringToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveSHA256StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA256StringToFile.Image")));
            this.buttonSaveSHA256StringToFile.Location = new System.Drawing.Point(471, 114);
            this.buttonSaveSHA256StringToFile.Name = "buttonSaveSHA256StringToFile";
            this.buttonSaveSHA256StringToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveSHA256StringToFile.TabIndex = 19;
            this.buttonSaveSHA256StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveSHA256StringToFile, "Save the SHA256 hash value in a file");
            this.buttonSaveSHA256StringToFile.UseVisualStyleBackColor = true;
            this.buttonSaveSHA256StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA256StringToFile_Click);
            this.buttonSaveSHA256StringToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA256StringToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveSHA256StringToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA256StringToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonSaveSHA1StringToFile
            // 
            this.buttonSaveSHA1StringToFile.AccessibleDescription = "Save the SHA1 hash value in a file";
            this.buttonSaveSHA1StringToFile.AccessibleName = "Save SHA1 hash to file";
            this.buttonSaveSHA1StringToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveSHA1StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveSHA1StringToFile.Image")));
            this.buttonSaveSHA1StringToFile.Location = new System.Drawing.Point(471, 88);
            this.buttonSaveSHA1StringToFile.Name = "buttonSaveSHA1StringToFile";
            this.buttonSaveSHA1StringToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveSHA1StringToFile.TabIndex = 15;
            this.buttonSaveSHA1StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveSHA1StringToFile, "Save the SHA1 hash value in a file");
            this.buttonSaveSHA1StringToFile.UseVisualStyleBackColor = true;
            this.buttonSaveSHA1StringToFile.Click += new System.EventHandler(this.ButtonSaveSHA1StringToFile_Click);
            this.buttonSaveSHA1StringToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA1StringToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveSHA1StringToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveSHA1StringToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonSaveRIPEMD160ToFile
            // 
            this.buttonSaveRIPEMD160ToFile.AccessibleDescription = "Save the RIPEMD160 hash value in a file";
            this.buttonSaveRIPEMD160ToFile.AccessibleName = "Save RIPEMD160 hash to file";
            this.buttonSaveRIPEMD160ToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveRIPEMD160ToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveRIPEMD160ToFile.Image")));
            this.buttonSaveRIPEMD160ToFile.Location = new System.Drawing.Point(471, 62);
            this.buttonSaveRIPEMD160ToFile.Name = "buttonSaveRIPEMD160ToFile";
            this.buttonSaveRIPEMD160ToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveRIPEMD160ToFile.TabIndex = 11;
            this.buttonSaveRIPEMD160ToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveRIPEMD160ToFile, "Save the RIPEMD160 hash value in a file");
            this.buttonSaveRIPEMD160ToFile.UseVisualStyleBackColor = true;
            this.buttonSaveRIPEMD160ToFile.Click += new System.EventHandler(this.ButtonSaveRIPEMD160ToFile_Click);
            this.buttonSaveRIPEMD160ToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveRIPEMD160ToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveRIPEMD160ToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveRIPEMD160ToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonSaveMD5StringToFile
            // 
            this.buttonSaveMD5StringToFile.AccessibleDescription = "Save the MD5 hash value in a file";
            this.buttonSaveMD5StringToFile.AccessibleName = "Save MD5 hash to file";
            this.buttonSaveMD5StringToFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonSaveMD5StringToFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveMD5StringToFile.Image")));
            this.buttonSaveMD5StringToFile.Location = new System.Drawing.Point(471, 36);
            this.buttonSaveMD5StringToFile.Name = "buttonSaveMD5StringToFile";
            this.buttonSaveMD5StringToFile.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveMD5StringToFile.TabIndex = 7;
            this.buttonSaveMD5StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonSaveMD5StringToFile, "Save the MD5 hash value in a file");
            this.buttonSaveMD5StringToFile.UseVisualStyleBackColor = true;
            this.buttonSaveMD5StringToFile.Click += new System.EventHandler(this.ButtonSaveMD5StringToFile_Click);
            this.buttonSaveMD5StringToFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveMD5StringToFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonSaveMD5StringToFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonSaveMD5StringToFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA512StringFromFileToClipboard
            // 
            this.buttonCopySHA512StringFromFileToClipboard.AccessibleDescription = "Copy the SHA512 hash value to the clipboard";
            this.buttonCopySHA512StringFromFileToClipboard.AccessibleName = "Copy SHA512 hash value to clipboard";
            this.buttonCopySHA512StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA512StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512StringFromFileToClipboard.Image")));
            this.buttonCopySHA512StringFromFileToClipboard.Location = new System.Drawing.Point(447, 166);
            this.buttonCopySHA512StringFromFileToClipboard.Name = "buttonCopySHA512StringFromFileToClipboard";
            this.buttonCopySHA512StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA512StringFromFileToClipboard.TabIndex = 26;
            this.buttonCopySHA512StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA512StringFromFileToClipboard, "Copy the SHA512 hash value to the clipboard");
            this.buttonCopySHA512StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA512StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA512StringFromFileToClipboard_Click);
            this.buttonCopySHA512StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA512StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA512StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA512StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA384StringFromFileToClipboard
            // 
            this.buttonCopySHA384StringFromFileToClipboard.AccessibleDescription = "Copy the SHA384 hash value to the clipboard";
            this.buttonCopySHA384StringFromFileToClipboard.AccessibleName = "Copy SHA384 hash value to clipboard";
            this.buttonCopySHA384StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA384StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384StringFromFileToClipboard.Image")));
            this.buttonCopySHA384StringFromFileToClipboard.Location = new System.Drawing.Point(447, 140);
            this.buttonCopySHA384StringFromFileToClipboard.Name = "buttonCopySHA384StringFromFileToClipboard";
            this.buttonCopySHA384StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA384StringFromFileToClipboard.TabIndex = 22;
            this.buttonCopySHA384StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA384StringFromFileToClipboard, "Copy the SHA384 hash value to the clipboard");
            this.buttonCopySHA384StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA384StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA384StringFromFileToClipboard_Click);
            this.buttonCopySHA384StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA384StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA384StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA384StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA256StringFromFileToClipboard
            // 
            this.buttonCopySHA256StringFromFileToClipboard.AccessibleDescription = "Copy the SHA256 hash value to the clipboard";
            this.buttonCopySHA256StringFromFileToClipboard.AccessibleName = "Copy SHA256 hash value to clipboard";
            this.buttonCopySHA256StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA256StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256StringFromFileToClipboard.Image")));
            this.buttonCopySHA256StringFromFileToClipboard.Location = new System.Drawing.Point(447, 114);
            this.buttonCopySHA256StringFromFileToClipboard.Name = "buttonCopySHA256StringFromFileToClipboard";
            this.buttonCopySHA256StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA256StringFromFileToClipboard.TabIndex = 18;
            this.buttonCopySHA256StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA256StringFromFileToClipboard, "Copy the SHA256 hash value to the clipboard");
            this.buttonCopySHA256StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA256StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA256StringFromFileToClipboard_Click);
            this.buttonCopySHA256StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA256StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA256StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA256StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA1StringFromFileToClipboard
            // 
            this.buttonCopySHA1StringFromFileToClipboard.AccessibleDescription = "Copy the SHA1 hash value to the clipboard";
            this.buttonCopySHA1StringFromFileToClipboard.AccessibleName = "Copy SHA1 hash value to clipboard";
            this.buttonCopySHA1StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA1StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1StringFromFileToClipboard.Image")));
            this.buttonCopySHA1StringFromFileToClipboard.Location = new System.Drawing.Point(447, 88);
            this.buttonCopySHA1StringFromFileToClipboard.Name = "buttonCopySHA1StringFromFileToClipboard";
            this.buttonCopySHA1StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA1StringFromFileToClipboard.TabIndex = 14;
            this.buttonCopySHA1StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA1StringFromFileToClipboard, "Copy the SHA1 hash value to the clipboard");
            this.buttonCopySHA1StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA1StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1StringFromFileToClipboard_Click);
            this.buttonCopySHA1StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA1StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA1StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA1StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopyRIPEMD160StringFromFileToClipboard
            // 
            this.buttonCopyRIPEMD160StringFromFileToClipboard.AccessibleDescription = "Copy the RIPEMD160 hash value to the clipboard";
            this.buttonCopyRIPEMD160StringFromFileToClipboard.AccessibleName = "Copy RIPEMD160 hash value to clipboard";
            this.buttonCopyRIPEMD160StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyRIPEMD160StringFromFileToClipboard.Image")));
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Location = new System.Drawing.Point(447, 62);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Name = "buttonCopyRIPEMD160StringFromFileToClipboard";
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.TabIndex = 10;
            this.buttonCopyRIPEMD160StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopyRIPEMD160StringFromFileToClipboard, "Copy the RIPEMD160 hash value to the clipboard");
            this.buttonCopyRIPEMD160StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopyRIPEMD160StringFromFileToClipboard_Click);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyRIPEMD160StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopyMD5StringFromFileToClipboard
            // 
            this.buttonCopyMD5StringFromFileToClipboard.AccessibleDescription = "Copy the MD5 hash value to the clipboard";
            this.buttonCopyMD5StringFromFileToClipboard.AccessibleName = "Copy MD5 hash value to clipboard";
            this.buttonCopyMD5StringFromFileToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopyMD5StringFromFileToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5StringFromFileToClipboard.Image")));
            this.buttonCopyMD5StringFromFileToClipboard.Location = new System.Drawing.Point(447, 36);
            this.buttonCopyMD5StringFromFileToClipboard.Name = "buttonCopyMD5StringFromFileToClipboard";
            this.buttonCopyMD5StringFromFileToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopyMD5StringFromFileToClipboard.TabIndex = 6;
            this.buttonCopyMD5StringFromFileToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopyMD5StringFromFileToClipboard, "Copy the MD5 hash value to the clipboard");
            this.buttonCopyMD5StringFromFileToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyMD5StringFromFileToClipboard.Click += new System.EventHandler(this.ButtonCopyMD5StringFromFileToClipboard_Click);
            this.buttonCopyMD5StringFromFileToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyMD5StringFromFileToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopyMD5StringFromFileToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyMD5StringFromFileToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonOpenAndCalculateHashFromFile
            // 
            this.buttonOpenAndCalculateHashFromFile.AccessibleDescription = "Open a file and calculate the hash values";
            this.buttonOpenAndCalculateHashFromFile.AccessibleName = "Open and calculate hash values from file";
            this.buttonOpenAndCalculateHashFromFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonOpenAndCalculateHashFromFile.Image = global::Hasher.Properties.Resources.fatcow_document_hash_tag_16;
            this.buttonOpenAndCalculateHashFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenAndCalculateHashFromFile.Location = new System.Drawing.Point(380, 6);
            this.buttonOpenAndCalculateHashFromFile.Name = "buttonOpenAndCalculateHashFromFile";
            this.buttonOpenAndCalculateHashFromFile.Size = new System.Drawing.Size(115, 24);
            this.buttonOpenAndCalculateHashFromFile.TabIndex = 2;
            this.buttonOpenAndCalculateHashFromFile.Text = "Open && Calculate";
            this.buttonOpenAndCalculateHashFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonOpenAndCalculateHashFromFile, "Open a file and calculate the hash value");
            this.buttonOpenAndCalculateHashFromFile.UseVisualStyleBackColor = true;
            this.buttonOpenAndCalculateHashFromFile.Click += new System.EventHandler(this.OpenAndCalculateFile_Click);
            this.buttonOpenAndCalculateHashFromFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonOpenAndCalculateHashFromFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonOpenAndCalculateHashFromFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonOpenAndCalculateHashFromFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleDescription = "Just a tab control";
            this.tabControl.AccessibleName = "tab control";
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tabPageFile);
            this.tabControl.Controls.Add(this.tabPageText);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.ImageList = this.imageListTab;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(511, 221);
            this.tabControl.TabIndex = 0;
            this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.tabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // tabPageFile
            // 
            this.tabPageFile.AccessibleDescription = "Show the file tab page";
            this.tabPageFile.AccessibleName = "file tab page";
            this.tabPageFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.tabPageFile.Controls.Add(this.labelFileName);
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
            this.tabPageFile.ImageKey = "fatcow_page_16.png";
            this.tabPageFile.Location = new System.Drawing.Point(4, 23);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(503, 194);
            this.tabPageFile.TabIndex = 0;
            this.tabPageFile.Text = "File";
            this.toolTip.SetToolTip(this.tabPageFile, "Hash a file");
            this.tabPageFile.ToolTipText = "Hash a file";
            this.tabPageFile.UseVisualStyleBackColor = true;
            this.tabPageFile.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.tabPageFile.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.tabPageFile.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.tabPageFile.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // statusStrip
            // 
            this.statusStrip.AccessibleDescription = "Just a status bar";
            this.statusStrip.AccessibleName = "status bar";
            this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInformation});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(511, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 28;
            this.statusStrip.TabStop = true;
            this.statusStrip.Text = "status bar";
            this.toolTip.SetToolTip(this.statusStrip, "Just a status bar");
            this.statusStrip.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.statusStrip.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.statusStrip.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.statusStrip.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripStatusLabelInformation
            // 
            this.toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
            this.toolStripStatusLabelInformation.AccessibleName = "information";
            this.toolStripStatusLabelInformation.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.toolStripStatusLabelInformation.AutoToolTip = true;
            this.toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
            this.toolStripStatusLabelInformation.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabelInformation.Text = "information";
            this.toolStripStatusLabelInformation.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.toolStripStatusLabelInformation.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // tabPageText
            // 
            this.tabPageText.AccessibleDescription = "Show the text tab page";
            this.tabPageText.AccessibleName = "text tab page";
            this.tabPageText.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.tabPageText.Controls.Add(this.checkBoxAutoUpdateText);
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
            this.tabPageText.ImageKey = "fatcow_text_effects_16.png";
            this.tabPageText.Location = new System.Drawing.Point(4, 23);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(503, 194);
            this.tabPageText.TabIndex = 1;
            this.tabPageText.Text = "Text";
            this.toolTip.SetToolTip(this.tabPageText, "Hash a text");
            this.tabPageText.ToolTipText = "Hash a text";
            this.tabPageText.UseVisualStyleBackColor = true;
            this.tabPageText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.tabPageText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.tabPageText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.tabPageText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // checkBoxAutoUpdateText
            // 
            this.checkBoxAutoUpdateText.AccessibleDescription = "Enable/disable the permanent calculation";
            this.checkBoxAutoUpdateText.AccessibleName = "Permanent calculation";
            this.checkBoxAutoUpdateText.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.checkBoxAutoUpdateText.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAutoUpdateText.AutoSize = true;
            this.checkBoxAutoUpdateText.Image = global::Hasher.Properties.Resources.fatcow_arrow_refresh_small_16;
            this.checkBoxAutoUpdateText.Location = new System.Drawing.Point(471, 7);
            this.checkBoxAutoUpdateText.Name = "checkBoxAutoUpdateText";
            this.checkBoxAutoUpdateText.Size = new System.Drawing.Size(22, 22);
            this.checkBoxAutoUpdateText.TabIndex = 3;
            this.checkBoxAutoUpdateText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.checkBoxAutoUpdateText, "Enable/disable the permanent calculation");
            this.checkBoxAutoUpdateText.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdateText.CheckedChanged += new System.EventHandler(this.CheckBoxAutoUpdateText_CheckedChanged);
            this.checkBoxAutoUpdateText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.checkBoxAutoUpdateText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.checkBoxAutoUpdateText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.checkBoxAutoUpdateText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelText
            // 
            this.labelText.AccessibleDescription = "text";
            this.labelText.AccessibleName = "text";
            this.labelText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(7, 12);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 13);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Text:";
            this.toolTip.SetToolTip(this.labelText, "text");
            this.labelText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxText
            // 
            this.textBoxText.AccessibleDescription = "Show the text";
            this.textBoxText.AccessibleName = "text";
            this.textBoxText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxText.Location = new System.Drawing.Point(44, 9);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(335, 20);
            this.textBoxText.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBoxText, "text to hash");
            this.textBoxText.TextChanged += new System.EventHandler(this.TextBoxText_KeyPress);
            this.textBoxText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCalculateHashFromText
            // 
            this.buttonCalculateHashFromText.AccessibleDescription = "Calculate the hash values from a text";
            this.buttonCalculateHashFromText.AccessibleName = "Calculate hash values from text";
            this.buttonCalculateHashFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCalculateHashFromText.Image = global::Hasher.Properties.Resources.fatcow_document_hash_tag_16;
            this.buttonCalculateHashFromText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCalculateHashFromText.Location = new System.Drawing.Point(385, 6);
            this.buttonCalculateHashFromText.Name = "buttonCalculateHashFromText";
            this.buttonCalculateHashFromText.Size = new System.Drawing.Size(80, 24);
            this.buttonCalculateHashFromText.TabIndex = 2;
            this.buttonCalculateHashFromText.Text = "Calculate";
            this.buttonCalculateHashFromText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCalculateHashFromText, "Calculate the hash values from a text");
            this.buttonCalculateHashFromText.UseVisualStyleBackColor = true;
            this.buttonCalculateHashFromText.Click += new System.EventHandler(this.ButtonCalculateHashFromText_Click);
            this.buttonCalculateHashFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCalculateHashFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCalculateHashFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCalculateHashFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelMD5StringFromText
            // 
            this.labelMD5StringFromText.AccessibleDescription = "MD5";
            this.labelMD5StringFromText.AccessibleName = "MD5";
            this.labelMD5StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelMD5StringFromText.AutoSize = true;
            this.labelMD5StringFromText.Location = new System.Drawing.Point(7, 42);
            this.labelMD5StringFromText.Name = "labelMD5StringFromText";
            this.labelMD5StringFromText.Size = new System.Drawing.Size(33, 13);
            this.labelMD5StringFromText.TabIndex = 4;
            this.labelMD5StringFromText.Text = "MD5:";
            this.toolTip.SetToolTip(this.labelMD5StringFromText, "MD5 hash");
            this.labelMD5StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelMD5StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelMD5StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelMD5StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxMD5StringFromText
            // 
            this.textBoxMD5StringFromText.AccessibleDescription = "Show the MD5 hash value";
            this.textBoxMD5StringFromText.AccessibleName = "MD5 hash value";
            this.textBoxMD5StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxMD5StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMD5StringFromText.Location = new System.Drawing.Point(83, 39);
            this.textBoxMD5StringFromText.Name = "textBoxMD5StringFromText";
            this.textBoxMD5StringFromText.ReadOnly = true;
            this.textBoxMD5StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxMD5StringFromText.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxMD5StringFromText, "MD5 hash value");
            this.textBoxMD5StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxMD5StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxMD5StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxMD5StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopyMD5StringFromTextToClipboard
            // 
            this.buttonCopyMD5StringFromTextToClipboard.AccessibleDescription = "Copy the MD5hash value to the clipboard";
            this.buttonCopyMD5StringFromTextToClipboard.AccessibleName = "Copy MD5 hash value to clipboard";
            this.buttonCopyMD5StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopyMD5StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5StringFromTextToClipboard.Image")));
            this.buttonCopyMD5StringFromTextToClipboard.Location = new System.Drawing.Point(471, 36);
            this.buttonCopyMD5StringFromTextToClipboard.Name = "buttonCopyMD5StringFromTextToClipboard";
            this.buttonCopyMD5StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopyMD5StringFromTextToClipboard.TabIndex = 6;
            this.buttonCopyMD5StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopyMD5StringFromTextToClipboard, "Copy the MD5 hash value to the clipboard");
            this.buttonCopyMD5StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyMD5StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopyMD5StringFromTextToClipboard_Click);
            this.buttonCopyMD5StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyMD5StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopyMD5StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyMD5StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelRIPEMD160StringFromText
            // 
            this.labelRIPEMD160StringFromText.AccessibleDescription = "RIPEMD160";
            this.labelRIPEMD160StringFromText.AccessibleName = "RIPEMD160";
            this.labelRIPEMD160StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelRIPEMD160StringFromText.AutoSize = true;
            this.labelRIPEMD160StringFromText.Location = new System.Drawing.Point(7, 68);
            this.labelRIPEMD160StringFromText.Name = "labelRIPEMD160StringFromText";
            this.labelRIPEMD160StringFromText.Size = new System.Drawing.Size(70, 13);
            this.labelRIPEMD160StringFromText.TabIndex = 7;
            this.labelRIPEMD160StringFromText.Text = "RIPEMD160:";
            this.toolTip.SetToolTip(this.labelRIPEMD160StringFromText, "RIPEMD160 hash");
            this.labelRIPEMD160StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelRIPEMD160StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelRIPEMD160StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelRIPEMD160StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxRIPEMD160StringFromText
            // 
            this.textBoxRIPEMD160StringFromText.AccessibleDescription = "Show the RIPEMD160 hash value";
            this.textBoxRIPEMD160StringFromText.AccessibleName = "RIPEMD160 hash value";
            this.textBoxRIPEMD160StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxRIPEMD160StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRIPEMD160StringFromText.Location = new System.Drawing.Point(83, 65);
            this.textBoxRIPEMD160StringFromText.Name = "textBoxRIPEMD160StringFromText";
            this.textBoxRIPEMD160StringFromText.ReadOnly = true;
            this.textBoxRIPEMD160StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxRIPEMD160StringFromText.TabIndex = 8;
            this.toolTip.SetToolTip(this.textBoxRIPEMD160StringFromText, "RIPEMD160 hash value");
            this.textBoxRIPEMD160StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxRIPEMD160StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxRIPEMD160StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxRIPEMD160StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA512StringFromTextToClipboard
            // 
            this.buttonCopySHA512StringFromTextToClipboard.AccessibleDescription = "Copy the SHA512 hash value to the clipboard";
            this.buttonCopySHA512StringFromTextToClipboard.AccessibleName = "Copy SHA512 hash value to clipboard";
            this.buttonCopySHA512StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA512StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512StringFromTextToClipboard.Image")));
            this.buttonCopySHA512StringFromTextToClipboard.Location = new System.Drawing.Point(471, 166);
            this.buttonCopySHA512StringFromTextToClipboard.Name = "buttonCopySHA512StringFromTextToClipboard";
            this.buttonCopySHA512StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA512StringFromTextToClipboard.TabIndex = 21;
            this.buttonCopySHA512StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA512StringFromTextToClipboard, "Copy the SHA512 hash value to the clipboard");
            this.buttonCopySHA512StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA512StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA512StringFromTextToClipboard_Click);
            this.buttonCopySHA512StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA512StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA512StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA512StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopyRIPEMD160StringFromTextToClipboard
            // 
            this.buttonCopyRIPEMD160StringFromTextToClipboard.AccessibleDescription = "Copy the RIPEMD160 hash value to the clipboard";
            this.buttonCopyRIPEMD160StringFromTextToClipboard.AccessibleName = "Copy RIPEMD160 hash value to clipboard";
            this.buttonCopyRIPEMD160StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyRIPEMD160StringFromTextToClipboard.Image")));
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Location = new System.Drawing.Point(471, 62);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Name = "buttonCopyRIPEMD160StringFromTextToClipboard";
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.TabIndex = 9;
            this.buttonCopyRIPEMD160StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopyRIPEMD160StringFromTextToClipboard, "Copy the RIPEMD160 hash value to the clipboard");
            this.buttonCopyRIPEMD160StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopyRIPEMD160StringFromTextToClipboard_Click);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopyRIPEMD160StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA512StringFromText
            // 
            this.textBoxSHA512StringFromText.AccessibleDescription = "Show the SHA512 hash value";
            this.textBoxSHA512StringFromText.AccessibleName = "SHA512 hash value";
            this.textBoxSHA512StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA512StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA512StringFromText.Location = new System.Drawing.Point(83, 169);
            this.textBoxSHA512StringFromText.Name = "textBoxSHA512StringFromText";
            this.textBoxSHA512StringFromText.ReadOnly = true;
            this.textBoxSHA512StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxSHA512StringFromText.TabIndex = 20;
            this.toolTip.SetToolTip(this.textBoxSHA512StringFromText, "SHA512 hash value");
            this.textBoxSHA512StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA512StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA512StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA512StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA1StringFromText
            // 
            this.labelSHA1StringFromText.AccessibleDescription = "SHA1";
            this.labelSHA1StringFromText.AccessibleName = "SHA1";
            this.labelSHA1StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA1StringFromText.AutoSize = true;
            this.labelSHA1StringFromText.Location = new System.Drawing.Point(7, 94);
            this.labelSHA1StringFromText.Name = "labelSHA1StringFromText";
            this.labelSHA1StringFromText.Size = new System.Drawing.Size(38, 13);
            this.labelSHA1StringFromText.TabIndex = 10;
            this.labelSHA1StringFromText.Text = "SHA1:";
            this.toolTip.SetToolTip(this.labelSHA1StringFromText, "SHA1 hash");
            this.labelSHA1StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA1StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA1StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA1StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA512StringFromText
            // 
            this.labelSHA512StringFromText.AccessibleDescription = "SHA512";
            this.labelSHA512StringFromText.AccessibleName = "SHA512";
            this.labelSHA512StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA512StringFromText.AutoSize = true;
            this.labelSHA512StringFromText.Location = new System.Drawing.Point(7, 172);
            this.labelSHA512StringFromText.Name = "labelSHA512StringFromText";
            this.labelSHA512StringFromText.Size = new System.Drawing.Size(50, 13);
            this.labelSHA512StringFromText.TabIndex = 19;
            this.labelSHA512StringFromText.Text = "SHA512:";
            this.toolTip.SetToolTip(this.labelSHA512StringFromText, "SHA512 hash");
            this.labelSHA512StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA512StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA512StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA512StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA1StringFromText
            // 
            this.textBoxSHA1StringFromText.AccessibleDescription = "Show the SHA1 hash value";
            this.textBoxSHA1StringFromText.AccessibleName = "SHA1 hash value";
            this.textBoxSHA1StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA1StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA1StringFromText.Location = new System.Drawing.Point(83, 91);
            this.textBoxSHA1StringFromText.Name = "textBoxSHA1StringFromText";
            this.textBoxSHA1StringFromText.ReadOnly = true;
            this.textBoxSHA1StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxSHA1StringFromText.TabIndex = 11;
            this.toolTip.SetToolTip(this.textBoxSHA1StringFromText, "SHA1 hash value");
            this.textBoxSHA1StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA1StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA1StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA1StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA384StringFromTextToClipboard
            // 
            this.buttonCopySHA384StringFromTextToClipboard.AccessibleDescription = "Copy the SHA384 hash value to the clipboard";
            this.buttonCopySHA384StringFromTextToClipboard.AccessibleName = "Copy SHA384 hash value to clipboard";
            this.buttonCopySHA384StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA384StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384StringFromTextToClipboard.Image")));
            this.buttonCopySHA384StringFromTextToClipboard.Location = new System.Drawing.Point(471, 140);
            this.buttonCopySHA384StringFromTextToClipboard.Name = "buttonCopySHA384StringFromTextToClipboard";
            this.buttonCopySHA384StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA384StringFromTextToClipboard.TabIndex = 18;
            this.buttonCopySHA384StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA384StringFromTextToClipboard, "Copy the SHA384 hash value to the clipboard");
            this.buttonCopySHA384StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA384StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA384StringFromTextToClipboard_Click);
            this.buttonCopySHA384StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA384StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA384StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA384StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA1StringFromTextToClipboard
            // 
            this.buttonCopySHA1StringFromTextToClipboard.AccessibleDescription = "Copy the SHA1 hash value to the clipboard";
            this.buttonCopySHA1StringFromTextToClipboard.AccessibleName = "Copy SHA1 hash value to clipboard";
            this.buttonCopySHA1StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA1StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1StringFromTextToClipboard.Image")));
            this.buttonCopySHA1StringFromTextToClipboard.Location = new System.Drawing.Point(471, 88);
            this.buttonCopySHA1StringFromTextToClipboard.Name = "buttonCopySHA1StringFromTextToClipboard";
            this.buttonCopySHA1StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA1StringFromTextToClipboard.TabIndex = 12;
            this.buttonCopySHA1StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA1StringFromTextToClipboard, "Copy the SHA1 hash value to the clipboard");
            this.buttonCopySHA1StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA1StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1StringFromTextToClipboard_Click);
            this.buttonCopySHA1StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA1StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA1StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA1StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA384StringFromText
            // 
            this.textBoxSHA384StringFromText.AccessibleDescription = "Show the SHA384 hash value";
            this.textBoxSHA384StringFromText.AccessibleName = "SHA384 hash value";
            this.textBoxSHA384StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA384StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA384StringFromText.Location = new System.Drawing.Point(83, 143);
            this.textBoxSHA384StringFromText.Name = "textBoxSHA384StringFromText";
            this.textBoxSHA384StringFromText.ReadOnly = true;
            this.textBoxSHA384StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxSHA384StringFromText.TabIndex = 17;
            this.toolTip.SetToolTip(this.textBoxSHA384StringFromText, "SHA384 hash value");
            this.textBoxSHA384StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA384StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA384StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA384StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA256StringFromText
            // 
            this.labelSHA256StringFromText.AccessibleDescription = "SHA256";
            this.labelSHA256StringFromText.AccessibleName = "SHA256";
            this.labelSHA256StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA256StringFromText.AutoSize = true;
            this.labelSHA256StringFromText.Location = new System.Drawing.Point(7, 120);
            this.labelSHA256StringFromText.Name = "labelSHA256StringFromText";
            this.labelSHA256StringFromText.Size = new System.Drawing.Size(50, 13);
            this.labelSHA256StringFromText.TabIndex = 13;
            this.labelSHA256StringFromText.Text = "SHA256:";
            this.toolTip.SetToolTip(this.labelSHA256StringFromText, "SHA256 hash");
            this.labelSHA256StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA256StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA256StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA256StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // labelSHA384StringFromText
            // 
            this.labelSHA384StringFromText.AccessibleDescription = "SHA384";
            this.labelSHA384StringFromText.AccessibleName = "SHA384";
            this.labelSHA384StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.labelSHA384StringFromText.AutoSize = true;
            this.labelSHA384StringFromText.Location = new System.Drawing.Point(7, 146);
            this.labelSHA384StringFromText.Name = "labelSHA384StringFromText";
            this.labelSHA384StringFromText.Size = new System.Drawing.Size(50, 13);
            this.labelSHA384StringFromText.TabIndex = 16;
            this.labelSHA384StringFromText.Text = "SHA384:";
            this.toolTip.SetToolTip(this.labelSHA384StringFromText, "SHA384 hash");
            this.labelSHA384StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA384StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.labelSHA384StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.labelSHA384StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // textBoxSHA256StringFromText
            // 
            this.textBoxSHA256StringFromText.AccessibleDescription = "Show the SHA256 hash value";
            this.textBoxSHA256StringFromText.AccessibleName = "SHA256 hash value";
            this.textBoxSHA256StringFromText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxSHA256StringFromText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSHA256StringFromText.Location = new System.Drawing.Point(83, 117);
            this.textBoxSHA256StringFromText.Name = "textBoxSHA256StringFromText";
            this.textBoxSHA256StringFromText.ReadOnly = true;
            this.textBoxSHA256StringFromText.Size = new System.Drawing.Size(382, 20);
            this.textBoxSHA256StringFromText.TabIndex = 14;
            this.toolTip.SetToolTip(this.textBoxSHA256StringFromText, "SHA256 hash value");
            this.textBoxSHA256StringFromText.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA256StringFromText.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.textBoxSHA256StringFromText.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.textBoxSHA256StringFromText.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // buttonCopySHA256StringFromTextToClipboard
            // 
            this.buttonCopySHA256StringFromTextToClipboard.AccessibleDescription = "Copy the SHA256 hash value to the clipboard";
            this.buttonCopySHA256StringFromTextToClipboard.AccessibleName = "Copy SHA256 hash value to clipboard";
            this.buttonCopySHA256StringFromTextToClipboard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCopySHA256StringFromTextToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256StringFromTextToClipboard.Image")));
            this.buttonCopySHA256StringFromTextToClipboard.Location = new System.Drawing.Point(471, 114);
            this.buttonCopySHA256StringFromTextToClipboard.Name = "buttonCopySHA256StringFromTextToClipboard";
            this.buttonCopySHA256StringFromTextToClipboard.Size = new System.Drawing.Size(24, 24);
            this.buttonCopySHA256StringFromTextToClipboard.TabIndex = 15;
            this.buttonCopySHA256StringFromTextToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCopySHA256StringFromTextToClipboard, "Copy the SHA256 hash value to the clipboard");
            this.buttonCopySHA256StringFromTextToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopySHA256StringFromTextToClipboard.Click += new System.EventHandler(this.ButtonCopySHA256StringFromTextToClipboard_Click);
            this.buttonCopySHA256StringFromTextToClipboard.Enter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA256StringFromTextToClipboard.Leave += new System.EventHandler(this.ClearStatusbar_Leave);
            this.buttonCopySHA256StringFromTextToClipboard.MouseEnter += new System.EventHandler(this.SetStatusbar_Enter);
            this.buttonCopySHA256StringFromTextToClipboard.MouseLeave += new System.EventHandler(this.ClearStatusbar_Leave);
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.AccessibleDescription = "Just an container";
            this.toolStripContainer.AccessibleName = "Container";
            this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(511, 221);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(511, 243);
            this.toolStripContainer.TabIndex = 29;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "fatcow_page_16.png");
            this.imageListTab.Images.SetKeyName(1, "fatcow_text_effects_16.png");
            // 
            // MainForm
            // 
            this.AccessibleDescription = "This is the window of the application";
            this.AccessibleName = "Window of the application";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 243);
            this.Controls.Add(this.toolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.tabControl.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
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
		private System.Windows.Forms.CheckBox checkBoxAutoUpdateText;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInformation;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ImageList imageListTab;
    }
}

