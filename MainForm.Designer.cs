
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
			this.labelMD5String = new System.Windows.Forms.Label();
			this.textBoxMD5String = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.textBoxRIPEMD160String = new System.Windows.Forms.TextBox();
			this.labelRIPEMD160String = new System.Windows.Forms.Label();
			this.textBoxSHA1String = new System.Windows.Forms.TextBox();
			this.labelSHA1String = new System.Windows.Forms.Label();
			this.textBoxSHA256String = new System.Windows.Forms.TextBox();
			this.labelSHA256String = new System.Windows.Forms.Label();
			this.textBoxSHA384String = new System.Windows.Forms.TextBox();
			this.labelSHA384 = new System.Windows.Forms.Label();
			this.textBoxSHA512String = new System.Windows.Forms.TextBox();
			this.labelSHA512String = new System.Windows.Forms.Label();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.buttonShowFileProperties = new System.Windows.Forms.Button();
			this.buttonSaveSHA512StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA384StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA256StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveSHA1StringToFile = new System.Windows.Forms.Button();
			this.buttonSaveRIPEMD160ToFile = new System.Windows.Forms.Button();
			this.buttonSaveMD5StringToFile = new System.Windows.Forms.Button();
			this.buttonCopySHA512StringToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA384StringToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA256StringToClipboard = new System.Windows.Forms.Button();
			this.buttonCopySHA1StringToClipboard = new System.Windows.Forms.Button();
			this.buttonCopyRIPEMD160StringToClipboard = new System.Windows.Forms.Button();
			this.buttonCopyMD5StringToClipboard = new System.Windows.Forms.Button();
			this.buttonOpenAndCalculateFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelFileName
			// 
			this.labelFileName.AutoSize = true;
			this.labelFileName.Location = new System.Drawing.Point(12, 9);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(26, 13);
			this.labelFileName.TabIndex = 0;
			this.labelFileName.Text = "File:";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(53, 6);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.ReadOnly = true;
			this.textBoxFileName.Size = new System.Drawing.Size(299, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// labelMD5String
			// 
			this.labelMD5String.AutoSize = true;
			this.labelMD5String.Location = new System.Drawing.Point(12, 39);
			this.labelMD5String.Name = "labelMD5String";
			this.labelMD5String.Size = new System.Drawing.Size(33, 13);
			this.labelMD5String.TabIndex = 4;
			this.labelMD5String.Text = "MD5:";
			// 
			// textBoxMD5String
			// 
			this.textBoxMD5String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMD5String.Location = new System.Drawing.Point(88, 36);
			this.textBoxMD5String.Name = "textBoxMD5String";
			this.textBoxMD5String.ReadOnly = true;
			this.textBoxMD5String.Size = new System.Drawing.Size(355, 20);
			this.textBoxMD5String.TabIndex = 5;
			// 
			// openFileDialog
			// 
			this.openFileDialog.SupportMultiDottedExtensions = true;
			this.openFileDialog.Title = "Load file";
			// 
			// textBoxRIPEMD160String
			// 
			this.textBoxRIPEMD160String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRIPEMD160String.Location = new System.Drawing.Point(88, 62);
			this.textBoxRIPEMD160String.Name = "textBoxRIPEMD160String";
			this.textBoxRIPEMD160String.ReadOnly = true;
			this.textBoxRIPEMD160String.Size = new System.Drawing.Size(355, 20);
			this.textBoxRIPEMD160String.TabIndex = 9;
			// 
			// labelRIPEMD160String
			// 
			this.labelRIPEMD160String.AutoSize = true;
			this.labelRIPEMD160String.Location = new System.Drawing.Point(12, 65);
			this.labelRIPEMD160String.Name = "labelRIPEMD160String";
			this.labelRIPEMD160String.Size = new System.Drawing.Size(70, 13);
			this.labelRIPEMD160String.TabIndex = 8;
			this.labelRIPEMD160String.Text = "RIPEMD160:";
			// 
			// textBoxSHA1String
			// 
			this.textBoxSHA1String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA1String.Location = new System.Drawing.Point(88, 88);
			this.textBoxSHA1String.Name = "textBoxSHA1String";
			this.textBoxSHA1String.ReadOnly = true;
			this.textBoxSHA1String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA1String.TabIndex = 13;
			// 
			// labelSHA1String
			// 
			this.labelSHA1String.AutoSize = true;
			this.labelSHA1String.Location = new System.Drawing.Point(12, 91);
			this.labelSHA1String.Name = "labelSHA1String";
			this.labelSHA1String.Size = new System.Drawing.Size(38, 13);
			this.labelSHA1String.TabIndex = 12;
			this.labelSHA1String.Text = "SHA1:";
			// 
			// textBoxSHA256String
			// 
			this.textBoxSHA256String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA256String.Location = new System.Drawing.Point(88, 114);
			this.textBoxSHA256String.Name = "textBoxSHA256String";
			this.textBoxSHA256String.ReadOnly = true;
			this.textBoxSHA256String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA256String.TabIndex = 17;
			// 
			// labelSHA256String
			// 
			this.labelSHA256String.AutoSize = true;
			this.labelSHA256String.Location = new System.Drawing.Point(12, 117);
			this.labelSHA256String.Name = "labelSHA256String";
			this.labelSHA256String.Size = new System.Drawing.Size(50, 13);
			this.labelSHA256String.TabIndex = 16;
			this.labelSHA256String.Text = "SHA256:";
			// 
			// textBoxSHA384String
			// 
			this.textBoxSHA384String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA384String.Location = new System.Drawing.Point(88, 140);
			this.textBoxSHA384String.Name = "textBoxSHA384String";
			this.textBoxSHA384String.ReadOnly = true;
			this.textBoxSHA384String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA384String.TabIndex = 21;
			// 
			// labelSHA384
			// 
			this.labelSHA384.AutoSize = true;
			this.labelSHA384.Location = new System.Drawing.Point(12, 143);
			this.labelSHA384.Name = "labelSHA384";
			this.labelSHA384.Size = new System.Drawing.Size(50, 13);
			this.labelSHA384.TabIndex = 20;
			this.labelSHA384.Text = "SHA384:";
			// 
			// textBoxSHA512String
			// 
			this.textBoxSHA512String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA512String.Location = new System.Drawing.Point(88, 166);
			this.textBoxSHA512String.Name = "textBoxSHA512String";
			this.textBoxSHA512String.ReadOnly = true;
			this.textBoxSHA512String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA512String.TabIndex = 25;
			// 
			// labelSHA512String
			// 
			this.labelSHA512String.AutoSize = true;
			this.labelSHA512String.Location = new System.Drawing.Point(12, 169);
			this.labelSHA512String.Name = "labelSHA512String";
			this.labelSHA512String.Size = new System.Drawing.Size(50, 13);
			this.labelSHA512String.TabIndex = 24;
			this.labelSHA512String.Text = "SHA512:";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.SupportMultiDottedExtensions = true;
			this.saveFileDialog.Title = "Save hash value to file";
			// 
			// buttonShowFileProperties
			// 
			this.buttonShowFileProperties.Image = global::Hasher.Properties.Resources.fatcow_document_info_16;
			this.buttonShowFileProperties.Location = new System.Drawing.Point(473, 3);
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
			this.buttonSaveSHA512StringToFile.Location = new System.Drawing.Point(473, 163);
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
			this.buttonSaveSHA384StringToFile.Location = new System.Drawing.Point(473, 137);
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
			this.buttonSaveSHA256StringToFile.Location = new System.Drawing.Point(473, 111);
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
			this.buttonSaveSHA1StringToFile.Location = new System.Drawing.Point(473, 85);
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
			this.buttonSaveRIPEMD160ToFile.Location = new System.Drawing.Point(473, 59);
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
			this.buttonSaveMD5StringToFile.Location = new System.Drawing.Point(473, 33);
			this.buttonSaveMD5StringToFile.Name = "buttonSaveMD5StringToFile";
			this.buttonSaveMD5StringToFile.Size = new System.Drawing.Size(24, 24);
			this.buttonSaveMD5StringToFile.TabIndex = 7;
			this.buttonSaveMD5StringToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSaveMD5StringToFile.UseVisualStyleBackColor = true;
			this.buttonSaveMD5StringToFile.Click += new System.EventHandler(this.ButtonSaveMD5StringToFile_Click);
			// 
			// buttonCopySHA512StringToClipboard
			// 
			this.buttonCopySHA512StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA512StringToClipboard.Image")));
			this.buttonCopySHA512StringToClipboard.Location = new System.Drawing.Point(449, 163);
			this.buttonCopySHA512StringToClipboard.Name = "buttonCopySHA512StringToClipboard";
			this.buttonCopySHA512StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA512StringToClipboard.TabIndex = 26;
			this.buttonCopySHA512StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA512StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA512StringToClipboard.Click += new System.EventHandler(this.ButtonCopySHA512StringToClipboard_Click);
			// 
			// buttonCopySHA384StringToClipboard
			// 
			this.buttonCopySHA384StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA384StringToClipboard.Image")));
			this.buttonCopySHA384StringToClipboard.Location = new System.Drawing.Point(449, 137);
			this.buttonCopySHA384StringToClipboard.Name = "buttonCopySHA384StringToClipboard";
			this.buttonCopySHA384StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA384StringToClipboard.TabIndex = 22;
			this.buttonCopySHA384StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA384StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA384StringToClipboard.Click += new System.EventHandler(this.ButtonCopySHA384StringToClipboard_Click);
			// 
			// buttonCopySHA256StringToClipboard
			// 
			this.buttonCopySHA256StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA256StringToClipboard.Image")));
			this.buttonCopySHA256StringToClipboard.Location = new System.Drawing.Point(449, 111);
			this.buttonCopySHA256StringToClipboard.Name = "buttonCopySHA256StringToClipboard";
			this.buttonCopySHA256StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA256StringToClipboard.TabIndex = 18;
			this.buttonCopySHA256StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA256StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA256StringToClipboard.Click += new System.EventHandler(this.ButtonCopySHA256StringToClipboard_Click);
			// 
			// buttonCopySHA1StringToClipboard
			// 
			this.buttonCopySHA1StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopySHA1StringToClipboard.Image")));
			this.buttonCopySHA1StringToClipboard.Location = new System.Drawing.Point(449, 85);
			this.buttonCopySHA1StringToClipboard.Name = "buttonCopySHA1StringToClipboard";
			this.buttonCopySHA1StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopySHA1StringToClipboard.TabIndex = 14;
			this.buttonCopySHA1StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopySHA1StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopySHA1StringToClipboard.Click += new System.EventHandler(this.ButtonCopySHA1StringToClipboard_Click);
			// 
			// buttonCopyRIPEMD160StringToClipboard
			// 
			this.buttonCopyRIPEMD160StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyRIPEMD160StringToClipboard.Image")));
			this.buttonCopyRIPEMD160StringToClipboard.Location = new System.Drawing.Point(449, 59);
			this.buttonCopyRIPEMD160StringToClipboard.Name = "buttonCopyRIPEMD160StringToClipboard";
			this.buttonCopyRIPEMD160StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyRIPEMD160StringToClipboard.TabIndex = 10;
			this.buttonCopyRIPEMD160StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyRIPEMD160StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyRIPEMD160StringToClipboard.Click += new System.EventHandler(this.ButtonCopyRIPEMD160StringToClipboard_Click);
			// 
			// buttonCopyMD5StringToClipboard
			// 
			this.buttonCopyMD5StringToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyMD5StringToClipboard.Image")));
			this.buttonCopyMD5StringToClipboard.Location = new System.Drawing.Point(449, 33);
			this.buttonCopyMD5StringToClipboard.Name = "buttonCopyMD5StringToClipboard";
			this.buttonCopyMD5StringToClipboard.Size = new System.Drawing.Size(24, 24);
			this.buttonCopyMD5StringToClipboard.TabIndex = 6;
			this.buttonCopyMD5StringToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonCopyMD5StringToClipboard.UseVisualStyleBackColor = true;
			this.buttonCopyMD5StringToClipboard.Click += new System.EventHandler(this.ButtonCopyMD5StringToClipboard_Click);
			// 
			// buttonOpenAndCalculateFile
			// 
			this.buttonOpenAndCalculateFile.Image = global::Hasher.Properties.Resources.fatcow_document_hash_tag_16;
			this.buttonOpenAndCalculateFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonOpenAndCalculateFile.Location = new System.Drawing.Point(358, 3);
			this.buttonOpenAndCalculateFile.Name = "buttonOpenAndCalculateFile";
			this.buttonOpenAndCalculateFile.Size = new System.Drawing.Size(115, 24);
			this.buttonOpenAndCalculateFile.TabIndex = 2;
			this.buttonOpenAndCalculateFile.Text = "Open && Calculate";
			this.buttonOpenAndCalculateFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonOpenAndCalculateFile.UseVisualStyleBackColor = true;
			this.buttonOpenAndCalculateFile.Click += new System.EventHandler(this.OpenAndCalculateFile_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 201);
			this.Controls.Add(this.buttonShowFileProperties);
			this.Controls.Add(this.buttonSaveSHA512StringToFile);
			this.Controls.Add(this.buttonSaveSHA384StringToFile);
			this.Controls.Add(this.buttonSaveSHA256StringToFile);
			this.Controls.Add(this.buttonSaveSHA1StringToFile);
			this.Controls.Add(this.buttonSaveRIPEMD160ToFile);
			this.Controls.Add(this.buttonSaveMD5StringToFile);
			this.Controls.Add(this.buttonCopySHA512StringToClipboard);
			this.Controls.Add(this.textBoxSHA512String);
			this.Controls.Add(this.labelSHA512String);
			this.Controls.Add(this.buttonCopySHA384StringToClipboard);
			this.Controls.Add(this.textBoxSHA384String);
			this.Controls.Add(this.labelSHA384);
			this.Controls.Add(this.buttonCopySHA256StringToClipboard);
			this.Controls.Add(this.textBoxSHA256String);
			this.Controls.Add(this.labelSHA256String);
			this.Controls.Add(this.buttonCopySHA1StringToClipboard);
			this.Controls.Add(this.textBoxSHA1String);
			this.Controls.Add(this.labelSHA1String);
			this.Controls.Add(this.buttonCopyRIPEMD160StringToClipboard);
			this.Controls.Add(this.textBoxRIPEMD160String);
			this.Controls.Add(this.labelRIPEMD160String);
			this.Controls.Add(this.buttonCopyMD5StringToClipboard);
			this.Controls.Add(this.textBoxMD5String);
			this.Controls.Add(this.labelMD5String);
			this.Controls.Add(this.buttonOpenAndCalculateFile);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.labelFileName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasher";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Button buttonOpenAndCalculateFile;
		private System.Windows.Forms.Label labelMD5String;
		private System.Windows.Forms.TextBox textBoxMD5String;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonCopyMD5StringToClipboard;
		private System.Windows.Forms.Button buttonCopyRIPEMD160StringToClipboard;
		private System.Windows.Forms.TextBox textBoxRIPEMD160String;
		private System.Windows.Forms.Label labelRIPEMD160String;
		private System.Windows.Forms.Button buttonCopySHA1StringToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA1String;
		private System.Windows.Forms.Label labelSHA1String;
		private System.Windows.Forms.Button buttonCopySHA256StringToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA256String;
		private System.Windows.Forms.Label labelSHA256String;
		private System.Windows.Forms.Button buttonCopySHA384StringToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA384String;
		private System.Windows.Forms.Label labelSHA384;
		private System.Windows.Forms.Button buttonCopySHA512StringToClipboard;
		private System.Windows.Forms.TextBox textBoxSHA512String;
		private System.Windows.Forms.Label labelSHA512String;
		private System.Windows.Forms.Button buttonSaveSHA512StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA384StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA256StringToFile;
		private System.Windows.Forms.Button buttonSaveSHA1StringToFile;
		private System.Windows.Forms.Button buttonSaveRIPEMD160ToFile;
		private System.Windows.Forms.Button buttonSaveMD5StringToFile;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button buttonShowFileProperties;
	}
}

