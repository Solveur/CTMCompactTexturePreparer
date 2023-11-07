namespace CTMCompactTexturePreparer
{
	partial class Form_MakeTexture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MakeTexture));
			openFileDialog = new System.Windows.Forms.OpenFileDialog();
			buttonSelectTexture = new System.Windows.Forms.Button();
			pictureBox_Texture = new System.Windows.Forms.PictureBox();
			colorDialog = new System.Windows.Forms.ColorDialog();
			labelColor = new System.Windows.Forms.Label();
			pictureBoxCTM0 = new System.Windows.Forms.PictureBox();
			pictureBoxCTM1 = new System.Windows.Forms.PictureBox();
			pictureBoxCTM4 = new System.Windows.Forms.PictureBox();
			pictureBoxCTM3 = new System.Windows.Forms.PictureBox();
			pictureBoxCTM2 = new System.Windows.Forms.PictureBox();
			GroupBoxParameters = new System.Windows.Forms.GroupBox();
			panel_Color = new System.Windows.Forms.Panel();
			buttonSave = new System.Windows.Forms.Button();
			GroupBox = new System.Windows.Forms.GroupBox();
			folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			checkBoxIsEmissive = new System.Windows.Forms.CheckBox();
			textBox_EmissiveSuffix = new System.Windows.Forms.TextBox();
			label_EmissiveSuffix = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			button_SelectBackground = new System.Windows.Forms.Button();
			checkBox_DeleteBackground = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)pictureBox_Texture).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM0).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM2).BeginInit();
			GroupBoxParameters.SuspendLayout();
			GroupBox.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog";
			// 
			// buttonSelectTexture
			// 
			buttonSelectTexture.BackColor = System.Drawing.SystemColors.ScrollBar;
			buttonSelectTexture.FlatAppearance.BorderColor = System.Drawing.Color.White;
			buttonSelectTexture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			buttonSelectTexture.Location = new System.Drawing.Point(6, 19);
			buttonSelectTexture.Name = "buttonSelectTexture";
			buttonSelectTexture.Size = new System.Drawing.Size(320, 23);
			buttonSelectTexture.TabIndex = 0;
			buttonSelectTexture.Text = "Select texture";
			buttonSelectTexture.UseVisualStyleBackColor = false;
			buttonSelectTexture.Click += ButtonSelectTexture_Click;
			// 
			// pictureBox_Texture
			// 
			pictureBox_Texture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pictureBox_Texture.Cursor = System.Windows.Forms.Cursors.Cross;
			pictureBox_Texture.Location = new System.Drawing.Point(6, 48);
			pictureBox_Texture.Name = "pictureBox_Texture";
			pictureBox_Texture.Size = new System.Drawing.Size(320, 320);
			pictureBox_Texture.TabIndex = 1;
			pictureBox_Texture.TabStop = false;
			pictureBox_Texture.DragDrop += PictureBoxTexture_DragDrop;
			pictureBox_Texture.DragEnter += PictureBoxTexture_DragEnter;
			pictureBox_Texture.DragLeave += PictureBoxTexture_DragLeave;
			pictureBox_Texture.MouseClick += PictureBoxTexture_MouseClick;
			// 
			// labelColor
			// 
			labelColor.AutoSize = true;
			labelColor.Location = new System.Drawing.Point(123, 180);
			labelColor.Name = "labelColor";
			labelColor.Size = new System.Drawing.Size(0, 13);
			labelColor.TabIndex = 4;
			// 
			// pictureBoxCTM0
			// 
			pictureBoxCTM0.Location = new System.Drawing.Point(6, 19);
			pictureBoxCTM0.Name = "pictureBoxCTM0";
			pictureBoxCTM0.Size = new System.Drawing.Size(80, 80);
			pictureBoxCTM0.TabIndex = 5;
			pictureBoxCTM0.TabStop = false;
			// 
			// pictureBoxCTM1
			// 
			pictureBoxCTM1.Location = new System.Drawing.Point(6, 105);
			pictureBoxCTM1.Name = "pictureBoxCTM1";
			pictureBoxCTM1.Size = new System.Drawing.Size(80, 80);
			pictureBoxCTM1.TabIndex = 6;
			pictureBoxCTM1.TabStop = false;
			// 
			// pictureBoxCTM4
			// 
			pictureBoxCTM4.Location = new System.Drawing.Point(6, 363);
			pictureBoxCTM4.Name = "pictureBoxCTM4";
			pictureBoxCTM4.Size = new System.Drawing.Size(80, 80);
			pictureBoxCTM4.TabIndex = 7;
			pictureBoxCTM4.TabStop = false;
			// 
			// pictureBoxCTM3
			// 
			pictureBoxCTM3.Location = new System.Drawing.Point(6, 277);
			pictureBoxCTM3.Name = "pictureBoxCTM3";
			pictureBoxCTM3.Size = new System.Drawing.Size(80, 80);
			pictureBoxCTM3.TabIndex = 8;
			pictureBoxCTM3.TabStop = false;
			// 
			// pictureBoxCTM2
			// 
			pictureBoxCTM2.Location = new System.Drawing.Point(6, 191);
			pictureBoxCTM2.Name = "pictureBoxCTM2";
			pictureBoxCTM2.Size = new System.Drawing.Size(80, 80);
			pictureBoxCTM2.TabIndex = 9;
			pictureBoxCTM2.TabStop = false;
			// 
			// GroupBoxParameters
			// 
			GroupBoxParameters.Controls.Add(pictureBox_Texture);
			GroupBoxParameters.Controls.Add(panel_Color);
			GroupBoxParameters.Controls.Add(buttonSelectTexture);
			GroupBoxParameters.Location = new System.Drawing.Point(12, 12);
			GroupBoxParameters.Name = "GroupBoxParameters";
			GroupBoxParameters.Size = new System.Drawing.Size(332, 430);
			GroupBoxParameters.TabIndex = 10;
			GroupBoxParameters.TabStop = false;
			GroupBoxParameters.Text = "Parameters";
			// 
			// panel_Color
			// 
			panel_Color.BackColor = System.Drawing.SystemColors.ScrollBar;
			panel_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel_Color.Location = new System.Drawing.Point(6, 374);
			panel_Color.Name = "panel_Color";
			panel_Color.Size = new System.Drawing.Size(320, 50);
			panel_Color.TabIndex = 3;
			panel_Color.Click += PanelColor_Click;
			// 
			// buttonSave
			// 
			buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			buttonSave.BackColor = System.Drawing.Color.Chartreuse;
			buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
			buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			buttonSave.Location = new System.Drawing.Point(12, 555);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new System.Drawing.Size(75, 23);
			buttonSave.TabIndex = 12;
			buttonSave.Text = "Save";
			buttonSave.UseVisualStyleBackColor = false;
			buttonSave.Click += ButtonSave_Click;
			// 
			// GroupBox
			// 
			GroupBox.Controls.Add(pictureBoxCTM1);
			GroupBox.Controls.Add(pictureBoxCTM0);
			GroupBox.Controls.Add(pictureBoxCTM2);
			GroupBox.Controls.Add(pictureBoxCTM4);
			GroupBox.Controls.Add(pictureBoxCTM3);
			GroupBox.Location = new System.Drawing.Point(350, 12);
			GroupBox.Name = "GroupBox";
			GroupBox.Size = new System.Drawing.Size(92, 449);
			GroupBox.TabIndex = 13;
			GroupBox.TabStop = false;
			GroupBox.Text = "Result";
			// 
			// checkBoxIsEmissive
			// 
			checkBoxIsEmissive.AutoSize = true;
			checkBoxIsEmissive.Location = new System.Drawing.Point(6, 19);
			checkBoxIsEmissive.Name = "checkBoxIsEmissive";
			checkBoxIsEmissive.Size = new System.Drawing.Size(73, 17);
			checkBoxIsEmissive.TabIndex = 14;
			checkBoxIsEmissive.Text = "Emissive?";
			checkBoxIsEmissive.UseVisualStyleBackColor = true;
			checkBoxIsEmissive.CheckedChanged += CheckBoxIsEmissive_CheckedChanged;
			// 
			// textBox_EmissiveSuffix
			// 
			textBox_EmissiveSuffix.Enabled = false;
			textBox_EmissiveSuffix.Location = new System.Drawing.Point(85, 16);
			textBox_EmissiveSuffix.Name = "textBox_EmissiveSuffix";
			textBox_EmissiveSuffix.Size = new System.Drawing.Size(53, 20);
			textBox_EmissiveSuffix.TabIndex = 15;
			textBox_EmissiveSuffix.Text = "_e";
			// 
			// label_EmissiveSuffix
			// 
			label_EmissiveSuffix.AutoSize = true;
			label_EmissiveSuffix.Enabled = false;
			label_EmissiveSuffix.Location = new System.Drawing.Point(144, 20);
			label_EmissiveSuffix.Name = "label_EmissiveSuffix";
			label_EmissiveSuffix.Size = new System.Drawing.Size(75, 13);
			label_EmissiveSuffix.TabIndex = 16;
			label_EmissiveSuffix.Text = "Emissive suffix";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button_SelectBackground);
			groupBox1.Controls.Add(checkBox_DeleteBackground);
			groupBox1.Controls.Add(checkBoxIsEmissive);
			groupBox1.Controls.Add(label_EmissiveSuffix);
			groupBox1.Controls.Add(textBox_EmissiveSuffix);
			groupBox1.Location = new System.Drawing.Point(18, 442);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(326, 71);
			groupBox1.TabIndex = 17;
			groupBox1.TabStop = false;
			groupBox1.Text = "Emissive";
			// 
			// button_SelectBackground
			// 
			button_SelectBackground.Enabled = false;
			button_SelectBackground.Location = new System.Drawing.Point(135, 38);
			button_SelectBackground.Name = "button_SelectBackground";
			button_SelectBackground.Size = new System.Drawing.Size(135, 23);
			button_SelectBackground.TabIndex = 18;
			button_SelectBackground.Text = "Select background";
			button_SelectBackground.UseVisualStyleBackColor = true;
			button_SelectBackground.Visible = false;
			button_SelectBackground.Click += button_SelectBackground_Click;
			// 
			// checkBox_DeleteBackground
			// 
			checkBox_DeleteBackground.AutoSize = true;
			checkBox_DeleteBackground.Enabled = false;
			checkBox_DeleteBackground.Location = new System.Drawing.Point(6, 42);
			checkBox_DeleteBackground.Name = "checkBox_DeleteBackground";
			checkBox_DeleteBackground.Size = new System.Drawing.Size(123, 17);
			checkBox_DeleteBackground.TabIndex = 17;
			checkBox_DeleteBackground.Text = "Delete background?";
			checkBox_DeleteBackground.UseVisualStyleBackColor = true;
			checkBox_DeleteBackground.CheckedChanged += CheckBox_DeleteBackground_CheckedChanged;
			// 
			// Form_MakeTexture
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(455, 590);
			Controls.Add(groupBox1);
			Controls.Add(GroupBox);
			Controls.Add(buttonSave);
			Controls.Add(GroupBoxParameters);
			Controls.Add(labelColor);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Name = "Form_MakeTexture";
			Text = "MakeTexture";
			((System.ComponentModel.ISupportInitialize)pictureBox_Texture).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM0).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxCTM2).EndInit();
			GroupBoxParameters.ResumeLayout(false);
			GroupBox.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button buttonSelectTexture;
		private System.Windows.Forms.PictureBox pictureBox_Texture;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.PictureBox pictureBoxCTM0;
		private System.Windows.Forms.PictureBox pictureBoxCTM1;
		private System.Windows.Forms.PictureBox pictureBoxCTM4;
		private System.Windows.Forms.PictureBox pictureBoxCTM3;
		private System.Windows.Forms.PictureBox pictureBoxCTM2;
		private System.Windows.Forms.GroupBox GroupBoxParameters;
		private System.Windows.Forms.Panel panel_Color;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.CheckBox checkBoxIsEmissive;
		private System.Windows.Forms.TextBox textBox_EmissiveSuffix;
		private System.Windows.Forms.Label label_EmissiveSuffix;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox_DeleteBackground;
		private System.Windows.Forms.Button button_SelectBackground;
	}
}

