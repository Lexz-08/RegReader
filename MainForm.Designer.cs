namespace RegReader
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblPath = new CometUI.CometLabel();
			this.txtPath = new CometUI.CometTextBox();
			this.txtKey = new CometUI.CometTextBox();
			this.lblKey = new CometUI.CometLabel();
			this.btnReadKey = new CometUI.CometFlatButton();
			this.txtReadResult = new CometUI.CometMultilineTextBox();
			this.txtValue = new CometUI.CometTextBox();
			this.lblValue = new CometUI.CometLabel();
			this.SuspendLayout();
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblPath.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblPath.Location = new System.Drawing.Point(12, 51);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(40, 19);
			this.lblPath.TabIndex = 0;
			this.lblPath.Text = "Path:";
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPath.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtPath.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtPath.Location = new System.Drawing.Point(63, 48);
			this.txtPath.Multiline = false;
			this.txtPath.Name = "txtPath";
			this.txtPath.Readonly = false;
			this.txtPath.Size = new System.Drawing.Size(418, 26);
			this.txtPath.TabIndex = 1;
			this.txtPath.UnderlineBorder = false;
			this.txtPath.UseSystemPasswordChar = false;
			// 
			// txtKey
			// 
			this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtKey.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtKey.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtKey.Location = new System.Drawing.Point(63, 80);
			this.txtKey.Multiline = false;
			this.txtKey.Name = "txtKey";
			this.txtKey.Readonly = false;
			this.txtKey.Size = new System.Drawing.Size(418, 26);
			this.txtKey.TabIndex = 3;
			this.txtKey.UnderlineBorder = false;
			this.txtKey.UseSystemPasswordChar = false;
			// 
			// lblKey
			// 
			this.lblKey.AutoSize = true;
			this.lblKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblKey.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblKey.Location = new System.Drawing.Point(12, 83);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(34, 19);
			this.lblKey.TabIndex = 2;
			this.lblKey.Text = "Key:";
			// 
			// btnReadKey
			// 
			this.btnReadKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReadKey.BorderWidth = 1;
			this.btnReadKey.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReadKey.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnReadKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.btnReadKey.Location = new System.Drawing.Point(407, 144);
			this.btnReadKey.Name = "btnReadKey";
			this.btnReadKey.Size = new System.Drawing.Size(74, 28);
			this.btnReadKey.TabIndex = 4;
			this.btnReadKey.Text = "Read Key";
			this.btnReadKey.Click += new System.EventHandler(this.ReadSubkey);
			// 
			// txtReadResult
			// 
			this.txtReadResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtReadResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtReadResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtReadResult.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtReadResult.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtReadResult.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtReadResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtReadResult.Location = new System.Drawing.Point(63, 144);
			this.txtReadResult.Name = "txtReadResult";
			this.txtReadResult.Readonly = false;
			this.txtReadResult.Size = new System.Drawing.Size(338, 139);
			this.txtReadResult.TabIndex = 5;
			this.txtReadResult.UnderlineBorder = false;
			// 
			// txtValue
			// 
			this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txtValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtValue.FocusedBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txtValue.Location = new System.Drawing.Point(63, 112);
			this.txtValue.Multiline = false;
			this.txtValue.Name = "txtValue";
			this.txtValue.Readonly = false;
			this.txtValue.Size = new System.Drawing.Size(418, 26);
			this.txtValue.TabIndex = 7;
			this.txtValue.UnderlineBorder = false;
			this.txtValue.UseSystemPasswordChar = false;
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblValue.Location = new System.Drawing.Point(12, 115);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(45, 19);
			this.lblValue.TabIndex = 6;
			this.lblValue.Text = "Value:";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(493, 295);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.txtReadResult);
			this.Controls.Add(this.btnReadKey);
			this.Controls.Add(this.txtKey);
			this.Controls.Add(this.lblKey);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.lblPath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeColor = System.Drawing.Color.DeepSkyBlue;
			this.MinimizeColor = System.Drawing.Color.DeepSkyBlue;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegReader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometLabel lblPath;
		private CometUI.CometTextBox txtPath;
		private CometUI.CometTextBox txtKey;
		private CometUI.CometLabel lblKey;
		private CometUI.CometFlatButton btnReadKey;
		private CometUI.CometMultilineTextBox txtReadResult;
		private CometUI.CometTextBox txtValue;
		private CometUI.CometLabel lblValue;
	}
}

