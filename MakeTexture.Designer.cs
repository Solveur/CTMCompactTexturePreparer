namespace CTMCompactTexturePreparer
{
	partial class MakeTexture
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeTexture));
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.buttonSelectTexture = new System.Windows.Forms.Button();
			this.pictureBoxTexture = new System.Windows.Forms.PictureBox();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.labelColor = new System.Windows.Forms.Label();
			this.pictureBoxCTM0 = new System.Windows.Forms.PictureBox();
			this.pictureBoxCTM1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxCTM4 = new System.Windows.Forms.PictureBox();
			this.pictureBoxCTM3 = new System.Windows.Forms.PictureBox();
			this.pictureBoxCTM2 = new System.Windows.Forms.PictureBox();
			this.GroupBoxParameters = new System.Windows.Forms.GroupBox();
			this.panelColor = new System.Windows.Forms.Panel();
			this.buttonSave = new System.Windows.Forms.Button();
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM2)).BeginInit();
			this.GroupBoxParameters.SuspendLayout();
			this.GroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// buttonSelectTexture
			// 
			this.buttonSelectTexture.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.buttonSelectTexture.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSelectTexture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelectTexture.Location = new System.Drawing.Point(6, 19);
			this.buttonSelectTexture.Name = "buttonSelectTexture";
			this.buttonSelectTexture.Size = new System.Drawing.Size(320, 23);
			this.buttonSelectTexture.TabIndex = 0;
			this.buttonSelectTexture.Text = "Select texture";
			this.buttonSelectTexture.UseVisualStyleBackColor = false;
			this.buttonSelectTexture.Click += new System.EventHandler(this.ButtonSelectTexture_Click);
			// 
			// pictureBoxTexture
			// 
			this.pictureBoxTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxTexture.Location = new System.Drawing.Point(6, 48);
			this.pictureBoxTexture.Name = "pictureBoxTexture";
			this.pictureBoxTexture.Size = new System.Drawing.Size(320, 320);
			this.pictureBoxTexture.TabIndex = 1;
			this.pictureBoxTexture.TabStop = false;
			this.pictureBoxTexture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxTexture_MouseClick);
			// 
			// labelColor
			// 
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new System.Drawing.Point(123, 180);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(0, 13);
			this.labelColor.TabIndex = 4;
			// 
			// pictureBoxCTM0
			// 
			this.pictureBoxCTM0.Location = new System.Drawing.Point(6, 19);
			this.pictureBoxCTM0.Name = "pictureBoxCTM0";
			this.pictureBoxCTM0.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCTM0.TabIndex = 5;
			this.pictureBoxCTM0.TabStop = false;
			// 
			// pictureBoxCTM1
			// 
			this.pictureBoxCTM1.Location = new System.Drawing.Point(6, 89);
			this.pictureBoxCTM1.Name = "pictureBoxCTM1";
			this.pictureBoxCTM1.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCTM1.TabIndex = 6;
			this.pictureBoxCTM1.TabStop = false;
			// 
			// pictureBoxCTM4
			// 
			this.pictureBoxCTM4.Location = new System.Drawing.Point(6, 299);
			this.pictureBoxCTM4.Name = "pictureBoxCTM4";
			this.pictureBoxCTM4.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCTM4.TabIndex = 7;
			this.pictureBoxCTM4.TabStop = false;
			// 
			// pictureBoxCTM3
			// 
			this.pictureBoxCTM3.Location = new System.Drawing.Point(6, 229);
			this.pictureBoxCTM3.Name = "pictureBoxCTM3";
			this.pictureBoxCTM3.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCTM3.TabIndex = 8;
			this.pictureBoxCTM3.TabStop = false;
			// 
			// pictureBoxCTM2
			// 
			this.pictureBoxCTM2.Location = new System.Drawing.Point(6, 159);
			this.pictureBoxCTM2.Name = "pictureBoxCTM2";
			this.pictureBoxCTM2.Size = new System.Drawing.Size(64, 64);
			this.pictureBoxCTM2.TabIndex = 9;
			this.pictureBoxCTM2.TabStop = false;
			// 
			// GroupBoxParameters
			// 
			this.GroupBoxParameters.Controls.Add(this.pictureBoxTexture);
			this.GroupBoxParameters.Controls.Add(this.panelColor);
			this.GroupBoxParameters.Controls.Add(this.buttonSelectTexture);
			this.GroupBoxParameters.Location = new System.Drawing.Point(12, 12);
			this.GroupBoxParameters.Name = "GroupBoxParameters";
			this.GroupBoxParameters.Size = new System.Drawing.Size(332, 430);
			this.GroupBoxParameters.TabIndex = 10;
			this.GroupBoxParameters.TabStop = false;
			this.GroupBoxParameters.Text = "Parameters";
			// 
			// panelColor
			// 
			this.panelColor.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColor.Location = new System.Drawing.Point(6, 374);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(320, 50);
			this.panelColor.TabIndex = 3;
			this.panelColor.Click += new System.EventHandler(this.PanelColor_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSave.BackColor = System.Drawing.Color.Chartreuse;
			this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Location = new System.Drawing.Point(12, 463);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 12;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// GroupBox
			// 
			this.GroupBox.Controls.Add(this.pictureBoxCTM1);
			this.GroupBox.Controls.Add(this.pictureBoxCTM0);
			this.GroupBox.Controls.Add(this.pictureBoxCTM2);
			this.GroupBox.Controls.Add(this.pictureBoxCTM4);
			this.GroupBox.Controls.Add(this.pictureBoxCTM3);
			this.GroupBox.Location = new System.Drawing.Point(350, 12);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(76, 369);
			this.GroupBox.TabIndex = 13;
			this.GroupBox.TabStop = false;
			this.GroupBox.Text = "Result";
			// 
			// MakeTexture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 498);
			this.Controls.Add(this.GroupBox);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.GroupBoxParameters);
			this.Controls.Add(this.labelColor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MakeTexture";
			this.Text = "MakeTexture";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCTM2)).EndInit();
			this.GroupBoxParameters.ResumeLayout(false);
			this.GroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonSelectTexture;
		private System.Windows.Forms.PictureBox pictureBoxTexture;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.PictureBox pictureBoxCTM0;
		private System.Windows.Forms.PictureBox pictureBoxCTM1;
		private System.Windows.Forms.PictureBox pictureBoxCTM4;
		private System.Windows.Forms.PictureBox pictureBoxCTM3;
		private System.Windows.Forms.PictureBox pictureBoxCTM2;
		private System.Windows.Forms.GroupBox GroupBoxParameters;
		private System.Windows.Forms.Panel panelColor;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

