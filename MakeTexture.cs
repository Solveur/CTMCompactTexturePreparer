namespace CTMCompactTexturePreparer
{
	using System;
	using System.Drawing;
	using System.IO;
	using System.Windows.Forms;
	using CTMCompactTexturePreparer.Properties;

	public partial class Form_MakeTexture : Form
	{
		Bitmap texture;
		Bitmap background;
		Color borderColor;
		Image pictureBox_Temp;

		public Form_MakeTexture()
		{
			InitializeComponent();
			pictureBox_Texture.AllowDrop = true;
		}

		private void ButtonSelectTexture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = openFileDialog.FileName;

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename)))
				texture = new Bitmap(ms);

			SetTexture(texture);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string suffix = checkBoxIsEmissive.Checked ? "_e" : "";
			if (checkBox_DeleteBackground.Checked)
			{
				texture.CTM0(borderColor).DeleteBackground(background).Save(folderBrowserDialog.SelectedPath + $@"\0{suffix}.png");
				texture.CTM1(borderColor).DeleteBackground(background).Save(folderBrowserDialog.SelectedPath + $@"\1{suffix}.png");
				texture.CTM2(borderColor).DeleteBackground(background).Save(folderBrowserDialog.SelectedPath + $@"\2{suffix}.png");
				texture.CTM3(borderColor).DeleteBackground(background).Save(folderBrowserDialog.SelectedPath + $@"\3{suffix}.png");
				texture.CTM4(borderColor).DeleteBackground(background).Save(folderBrowserDialog.SelectedPath + $@"\4{suffix}.png");
			}
			else
			{
				texture.CTM0(borderColor).Save(folderBrowserDialog.SelectedPath + $@"\0{suffix}.png");
				texture.CTM1(borderColor).Save(folderBrowserDialog.SelectedPath + $@"\1{suffix}.png");
				texture.CTM2(borderColor).Save(folderBrowserDialog.SelectedPath + $@"\2{suffix}.png");
				texture.CTM3(borderColor).Save(folderBrowserDialog.SelectedPath + $@"\3{suffix}.png");
				texture.CTM4(borderColor).Save(folderBrowserDialog.SelectedPath + $@"\4{suffix}.png");
			}
		}

		private void PictureBoxTexture_MouseClick(object sender, MouseEventArgs e)
		{
			using (Bitmap bmp = new Bitmap(pictureBox_Texture.Width, pictureBox_Texture.Height))
			{
				pictureBox_Texture.DrawToBitmap(bmp, pictureBox_Texture.ClientRectangle);
				borderColor = bmp.GetPixel(e.X, e.Y);
				panel_Color.BackColor = bmp.GetPixel(e.X, e.Y);
			}

			UpdatePictures();
		}

		private void PanelColor_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.Cancel)
				return;

			panel_Color.BackColor = colorDialog.Color;
			borderColor = colorDialog.Color;
			UpdatePictures();
		}

		private void CheckBoxIsEmissive_CheckedChanged(object sender, EventArgs e)
		{
			textBox_EmissiveSuffix.Enabled = checkBoxIsEmissive.Checked;
			label_EmissiveSuffix.Enabled = checkBoxIsEmissive.Checked;
			checkBox_DeleteBackground.Enabled = checkBoxIsEmissive.Checked;
			button_SelectBackground.Enabled = checkBoxIsEmissive.Checked && checkBox_DeleteBackground.Checked;
		}

		private void Button_SelectBackground_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;

			string filePath = openFileDialog.FileName;
			string fileName = openFileDialog.SafeFileName;
			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filePath)))
				background = new Bitmap(ms);

			button_SelectBackground.Text = fileName;
			UpdatePictures();
		}

		private void CheckBox_DeleteBackground_CheckedChanged(object sender, EventArgs e)
		{
			button_SelectBackground.Enabled = checkBoxIsEmissive.Checked && checkBox_DeleteBackground.Checked;
			UpdatePictures();
		}

		private void PictureBoxTexture_DragEnter(object sender, DragEventArgs e)
		{
			pictureBox_Temp = pictureBox_Texture.Image;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				pictureBox_Texture.Image = Resources.dragOver;
				e.Effect = DragDropEffects.Move;
			}
		}

		private void PictureBoxTexture_DragLeave(object sender, EventArgs e)
		{
			pictureBox_Texture.Image = pictureBox_Temp;
		}

		private void PictureBoxTexture_DragDrop(object sender, DragEventArgs e)
		{
			string[] filename = (string[])e.Data.GetData(DataFormats.FileDrop);

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename[0])))
				texture = new Bitmap(ms);

			SetTexture(texture);
			UpdatePictures();
		}

		private void UpdatePictures()
		{
			if (pictureBox_Texture.Image == null)
				return;

			int scaleFactor = 5;
			int defaultTextureWidth = 16;
			Bitmap[] ctm = new Bitmap[] {
				texture.CTM0(borderColor),
				texture.CTM1(borderColor),
				texture.CTM2(borderColor),
				texture.CTM3(borderColor),
				texture.CTM4(borderColor) 
			};

			if (checkBox_DeleteBackground.Checked && background != null)
			{
				pictureBoxCTM0.Image = ctm[0].DeleteBackground(background).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM1.Image = ctm[1].DeleteBackground(background).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM2.Image = ctm[2].DeleteBackground(background).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM3.Image = ctm[3].DeleteBackground(background).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM4.Image = ctm[4].DeleteBackground(background).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			}
			else
			{
				pictureBoxCTM0.Image = ctm[0].Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM1.Image = ctm[1].Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM2.Image = ctm[2].Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM3.Image = ctm[3].Upscale(scaleFactor * defaultTextureWidth / texture.Width);
				pictureBoxCTM4.Image = ctm[4].Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			}
		}

		private void SetTexture(Bitmap texture)
		{
			int scaleFactor = 20;
			int defaultTextureWidth = 16;

			pictureBox_Texture.Image = texture.Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			UpdatePictures();
		}
	}
}
