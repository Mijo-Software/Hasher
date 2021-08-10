
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
			this.labelFileName = new System.Windows.Forms.Label();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.buttonOpenAndCalculateFile = new System.Windows.Forms.Button();
			this.labelMD5String = new System.Windows.Forms.Label();
			this.textBoxMD5String = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonCopyMD5String = new System.Windows.Forms.Button();
			this.buttonCopyRIPEMD160String = new System.Windows.Forms.Button();
			this.textBoxRIPEMD160String = new System.Windows.Forms.TextBox();
			this.labelRIPEMD160String = new System.Windows.Forms.Label();
			this.buttonCopySHA1String = new System.Windows.Forms.Button();
			this.textBoxSHA1String = new System.Windows.Forms.TextBox();
			this.labelSHA1String = new System.Windows.Forms.Label();
			this.buttonCopySHA256String = new System.Windows.Forms.Button();
			this.textBoxSHA256String = new System.Windows.Forms.TextBox();
			this.labelSHA256String = new System.Windows.Forms.Label();
			this.buttonCopySHA384String = new System.Windows.Forms.Button();
			this.textBoxSHA384String = new System.Windows.Forms.TextBox();
			this.labelSHA384 = new System.Windows.Forms.Label();
			this.buttonbuttonCopySHA512String = new System.Windows.Forms.Button();
			this.textBoxSHA512String = new System.Windows.Forms.TextBox();
			this.labelSHA512String = new System.Windows.Forms.Label();
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
			this.textBoxFileName.Size = new System.Drawing.Size(390, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// buttonOpenAndCalculateFile
			// 
			this.buttonOpenAndCalculateFile.Location = new System.Drawing.Point(449, 5);
			this.buttonOpenAndCalculateFile.Name = "buttonOpenAndCalculateFile";
			this.buttonOpenAndCalculateFile.Size = new System.Drawing.Size(99, 21);
			this.buttonOpenAndCalculateFile.TabIndex = 2;
			this.buttonOpenAndCalculateFile.Text = "Open && Calculate";
			this.buttonOpenAndCalculateFile.UseVisualStyleBackColor = true;
			this.buttonOpenAndCalculateFile.Click += new System.EventHandler(this.OpenAndCalculateFile_Click);
			// 
			// labelMD5String
			// 
			this.labelMD5String.AutoSize = true;
			this.labelMD5String.Location = new System.Drawing.Point(12, 39);
			this.labelMD5String.Name = "labelMD5String";
			this.labelMD5String.Size = new System.Drawing.Size(33, 13);
			this.labelMD5String.TabIndex = 3;
			this.labelMD5String.Text = "MD5:";
			// 
			// textBoxMD5String
			// 
			this.textBoxMD5String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMD5String.Location = new System.Drawing.Point(88, 36);
			this.textBoxMD5String.Name = "textBoxMD5String";
			this.textBoxMD5String.ReadOnly = true;
			this.textBoxMD5String.Size = new System.Drawing.Size(355, 20);
			this.textBoxMD5String.TabIndex = 4;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.SupportMultiDottedExtensions = true;
			// 
			// buttonCopyMD5String
			// 
			this.buttonCopyMD5String.Location = new System.Drawing.Point(450, 36);
			this.buttonCopyMD5String.Name = "buttonCopyMD5String";
			this.buttonCopyMD5String.Size = new System.Drawing.Size(98, 20);
			this.buttonCopyMD5String.TabIndex = 5;
			this.buttonCopyMD5String.Text = "Copy to Clipboard";
			this.buttonCopyMD5String.UseVisualStyleBackColor = true;
			this.buttonCopyMD5String.Click += new System.EventHandler(this.ButtonCopyMD5String_Click);
			// 
			// buttonCopyRIPEMD160String
			// 
			this.buttonCopyRIPEMD160String.Location = new System.Drawing.Point(450, 62);
			this.buttonCopyRIPEMD160String.Name = "buttonCopyRIPEMD160String";
			this.buttonCopyRIPEMD160String.Size = new System.Drawing.Size(98, 20);
			this.buttonCopyRIPEMD160String.TabIndex = 8;
			this.buttonCopyRIPEMD160String.Text = "Copy to Clipboard";
			this.buttonCopyRIPEMD160String.UseVisualStyleBackColor = true;
			this.buttonCopyRIPEMD160String.Click += new System.EventHandler(this.ButtonCopyRIPEMD160String_Click);
			// 
			// textBoxRIPEMD160String
			// 
			this.textBoxRIPEMD160String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRIPEMD160String.Location = new System.Drawing.Point(88, 62);
			this.textBoxRIPEMD160String.Name = "textBoxRIPEMD160String";
			this.textBoxRIPEMD160String.ReadOnly = true;
			this.textBoxRIPEMD160String.Size = new System.Drawing.Size(355, 20);
			this.textBoxRIPEMD160String.TabIndex = 7;
			// 
			// labelRIPEMD160String
			// 
			this.labelRIPEMD160String.AutoSize = true;
			this.labelRIPEMD160String.Location = new System.Drawing.Point(12, 65);
			this.labelRIPEMD160String.Name = "labelRIPEMD160String";
			this.labelRIPEMD160String.Size = new System.Drawing.Size(70, 13);
			this.labelRIPEMD160String.TabIndex = 6;
			this.labelRIPEMD160String.Text = "RIPEMD160:";
			// 
			// buttonCopySHA1String
			// 
			this.buttonCopySHA1String.Location = new System.Drawing.Point(450, 88);
			this.buttonCopySHA1String.Name = "buttonCopySHA1String";
			this.buttonCopySHA1String.Size = new System.Drawing.Size(98, 20);
			this.buttonCopySHA1String.TabIndex = 11;
			this.buttonCopySHA1String.Text = "Copy to Clipboard";
			this.buttonCopySHA1String.UseVisualStyleBackColor = true;
			this.buttonCopySHA1String.Click += new System.EventHandler(this.ButtonCopySHA1String_Click);
			// 
			// textBoxSHA1String
			// 
			this.textBoxSHA1String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA1String.Location = new System.Drawing.Point(88, 88);
			this.textBoxSHA1String.Name = "textBoxSHA1String";
			this.textBoxSHA1String.ReadOnly = true;
			this.textBoxSHA1String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA1String.TabIndex = 10;
			// 
			// labelSHA1String
			// 
			this.labelSHA1String.AutoSize = true;
			this.labelSHA1String.Location = new System.Drawing.Point(12, 91);
			this.labelSHA1String.Name = "labelSHA1String";
			this.labelSHA1String.Size = new System.Drawing.Size(38, 13);
			this.labelSHA1String.TabIndex = 9;
			this.labelSHA1String.Text = "SHA1:";
			// 
			// buttonCopySHA256String
			// 
			this.buttonCopySHA256String.Location = new System.Drawing.Point(450, 114);
			this.buttonCopySHA256String.Name = "buttonCopySHA256String";
			this.buttonCopySHA256String.Size = new System.Drawing.Size(98, 20);
			this.buttonCopySHA256String.TabIndex = 14;
			this.buttonCopySHA256String.Text = "Copy to Clipboard";
			this.buttonCopySHA256String.UseVisualStyleBackColor = true;
			this.buttonCopySHA256String.Click += new System.EventHandler(this.ButtonCopySHA256String_Click);
			// 
			// textBoxSHA256String
			// 
			this.textBoxSHA256String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA256String.Location = new System.Drawing.Point(88, 114);
			this.textBoxSHA256String.Name = "textBoxSHA256String";
			this.textBoxSHA256String.ReadOnly = true;
			this.textBoxSHA256String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA256String.TabIndex = 13;
			// 
			// labelSHA256String
			// 
			this.labelSHA256String.AutoSize = true;
			this.labelSHA256String.Location = new System.Drawing.Point(12, 117);
			this.labelSHA256String.Name = "labelSHA256String";
			this.labelSHA256String.Size = new System.Drawing.Size(50, 13);
			this.labelSHA256String.TabIndex = 12;
			this.labelSHA256String.Text = "SHA256:";
			// 
			// buttonCopySHA384String
			// 
			this.buttonCopySHA384String.Location = new System.Drawing.Point(450, 140);
			this.buttonCopySHA384String.Name = "buttonCopySHA384String";
			this.buttonCopySHA384String.Size = new System.Drawing.Size(98, 20);
			this.buttonCopySHA384String.TabIndex = 17;
			this.buttonCopySHA384String.Text = "Copy to Clipboard";
			this.buttonCopySHA384String.UseVisualStyleBackColor = true;
			this.buttonCopySHA384String.Click += new System.EventHandler(this.ButtonCopySHA384String_Click);
			// 
			// textBoxSHA384String
			// 
			this.textBoxSHA384String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA384String.Location = new System.Drawing.Point(88, 140);
			this.textBoxSHA384String.Name = "textBoxSHA384String";
			this.textBoxSHA384String.ReadOnly = true;
			this.textBoxSHA384String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA384String.TabIndex = 16;
			// 
			// labelSHA384
			// 
			this.labelSHA384.AutoSize = true;
			this.labelSHA384.Location = new System.Drawing.Point(12, 143);
			this.labelSHA384.Name = "labelSHA384";
			this.labelSHA384.Size = new System.Drawing.Size(50, 13);
			this.labelSHA384.TabIndex = 15;
			this.labelSHA384.Text = "SHA384:";
			// 
			// buttonbuttonCopySHA512String
			// 
			this.buttonbuttonCopySHA512String.Location = new System.Drawing.Point(450, 166);
			this.buttonbuttonCopySHA512String.Name = "buttonbuttonCopySHA512String";
			this.buttonbuttonCopySHA512String.Size = new System.Drawing.Size(98, 20);
			this.buttonbuttonCopySHA512String.TabIndex = 20;
			this.buttonbuttonCopySHA512String.Text = "Copy to Clipboard";
			this.buttonbuttonCopySHA512String.UseVisualStyleBackColor = true;
			this.buttonbuttonCopySHA512String.Click += new System.EventHandler(this.ButtonbuttonCopySHA512String_Click);
			// 
			// textBoxSHA512String
			// 
			this.textBoxSHA512String.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSHA512String.Location = new System.Drawing.Point(88, 166);
			this.textBoxSHA512String.Name = "textBoxSHA512String";
			this.textBoxSHA512String.ReadOnly = true;
			this.textBoxSHA512String.Size = new System.Drawing.Size(355, 20);
			this.textBoxSHA512String.TabIndex = 19;
			// 
			// labelSHA512String
			// 
			this.labelSHA512String.AutoSize = true;
			this.labelSHA512String.Location = new System.Drawing.Point(12, 169);
			this.labelSHA512String.Name = "labelSHA512String";
			this.labelSHA512String.Size = new System.Drawing.Size(50, 13);
			this.labelSHA512String.TabIndex = 18;
			this.labelSHA512String.Text = "SHA512:";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 201);
			this.Controls.Add(this.buttonbuttonCopySHA512String);
			this.Controls.Add(this.textBoxSHA512String);
			this.Controls.Add(this.labelSHA512String);
			this.Controls.Add(this.buttonCopySHA384String);
			this.Controls.Add(this.textBoxSHA384String);
			this.Controls.Add(this.labelSHA384);
			this.Controls.Add(this.buttonCopySHA256String);
			this.Controls.Add(this.textBoxSHA256String);
			this.Controls.Add(this.labelSHA256String);
			this.Controls.Add(this.buttonCopySHA1String);
			this.Controls.Add(this.textBoxSHA1String);
			this.Controls.Add(this.labelSHA1String);
			this.Controls.Add(this.buttonCopyRIPEMD160String);
			this.Controls.Add(this.textBoxRIPEMD160String);
			this.Controls.Add(this.labelRIPEMD160String);
			this.Controls.Add(this.buttonCopyMD5String);
			this.Controls.Add(this.textBoxMD5String);
			this.Controls.Add(this.labelMD5String);
			this.Controls.Add(this.buttonOpenAndCalculateFile);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.labelFileName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
		private System.Windows.Forms.Button buttonCopyMD5String;
		private System.Windows.Forms.Button buttonCopyRIPEMD160String;
		private System.Windows.Forms.TextBox textBoxRIPEMD160String;
		private System.Windows.Forms.Label labelRIPEMD160String;
		private System.Windows.Forms.Button buttonCopySHA1String;
		private System.Windows.Forms.TextBox textBoxSHA1String;
		private System.Windows.Forms.Label labelSHA1String;
		private System.Windows.Forms.Button buttonCopySHA256String;
		private System.Windows.Forms.TextBox textBoxSHA256String;
		private System.Windows.Forms.Label labelSHA256String;
		private System.Windows.Forms.Button buttonCopySHA384String;
		private System.Windows.Forms.TextBox textBoxSHA384String;
		private System.Windows.Forms.Label labelSHA384;
		private System.Windows.Forms.Button buttonbuttonCopySHA512String;
		private System.Windows.Forms.TextBox textBoxSHA512String;
		private System.Windows.Forms.Label labelSHA512String;
	}
}

