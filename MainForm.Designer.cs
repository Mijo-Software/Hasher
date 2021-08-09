
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
			this.buttonOpenFile = new System.Windows.Forms.Button();
			this.labelMD5String = new System.Windows.Forms.Label();
			this.textBoxMD5String = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonCopyMD5String = new System.Windows.Forms.Button();
			this.buttonCalculateFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelFileName
			// 
			this.labelFileName.AutoSize = true;
			this.labelFileName.Location = new System.Drawing.Point(12, 9);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(35, 13);
			this.labelFileName.TabIndex = 0;
			this.labelFileName.Text = "Datei:";
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(53, 6);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.ReadOnly = true;
			this.textBoxFileName.Size = new System.Drawing.Size(390, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// buttonOpenFile
			// 
			this.buttonOpenFile.Location = new System.Drawing.Point(449, 5);
			this.buttonOpenFile.Name = "buttonOpenFile";
			this.buttonOpenFile.Size = new System.Drawing.Size(75, 21);
			this.buttonOpenFile.TabIndex = 2;
			this.buttonOpenFile.Text = "Öffnen";
			this.buttonOpenFile.UseVisualStyleBackColor = true;
			this.buttonOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
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
			this.textBoxMD5String.Location = new System.Drawing.Point(53, 36);
			this.textBoxMD5String.Name = "textBoxMD5String";
			this.textBoxMD5String.ReadOnly = true;
			this.textBoxMD5String.Size = new System.Drawing.Size(390, 20);
			this.textBoxMD5String.TabIndex = 5;
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
			this.buttonCopyMD5String.Size = new System.Drawing.Size(75, 20);
			this.buttonCopyMD5String.TabIndex = 6;
			this.buttonCopyMD5String.Text = "Kopieren";
			this.buttonCopyMD5String.UseVisualStyleBackColor = true;
			this.buttonCopyMD5String.Click += new System.EventHandler(this.ButtonCopyMD5String_Click);
			// 
			// buttonCalculateFile
			// 
			this.buttonCalculateFile.Location = new System.Drawing.Point(530, 5);
			this.buttonCalculateFile.Name = "buttonCalculateFile";
			this.buttonCalculateFile.Size = new System.Drawing.Size(75, 21);
			this.buttonCalculateFile.TabIndex = 3;
			this.buttonCalculateFile.Text = "Berechnen";
			this.buttonCalculateFile.UseVisualStyleBackColor = true;
			this.buttonCalculateFile.Click += new System.EventHandler(this.ButtonCalculateFile_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 75);
			this.Controls.Add(this.buttonCalculateFile);
			this.Controls.Add(this.buttonCopyMD5String);
			this.Controls.Add(this.textBoxMD5String);
			this.Controls.Add(this.labelMD5String);
			this.Controls.Add(this.buttonOpenFile);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.labelFileName);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFileName;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Button buttonOpenFile;
		private System.Windows.Forms.Label labelMD5String;
		private System.Windows.Forms.TextBox textBoxMD5String;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonCopyMD5String;
		private System.Windows.Forms.Button buttonCalculateFile;
	}
}

