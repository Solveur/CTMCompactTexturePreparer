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
		int scaleFactor = 5;
		int defaultTextureWidth = 16;

		public Form_MakeTexture()
		{
			InitializeComponent();
			pictureBox_Texture.AllowDrop = true;
		}

		private void ButtonSelectTexture_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;


			string texturePath = openFileDialog.FileName;

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(texturePath)))
				texture = new Bitmap(ms);

			SetTexture(texture);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "*.png|";
			saveFileDialog.FileName = openFileDialog.SafeFileName;
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;

			int textureSize = defaultTextureWidth;
			Bitmap CTM0 = texture.CTM0(borderColor);
			Bitmap CTM1 = texture.CTM1(borderColor);
			Bitmap CTM2 = texture.CTM2(borderColor);
			Bitmap CTM3 = texture.CTM3(borderColor);
			Bitmap CTM4 = texture.CTM4(borderColor);

			Bitmap fusionTexture = new Bitmap(textureSize * 5, textureSize);
			for (int x = 0; x < textureSize; x++)
			{
				for (int y = 0; y < textureSize; y++)
				{
					fusionTexture.SetPixel(0 * textureSize + x, y, CTM0.GetPixel(x, y));
					fusionTexture.SetPixel(1 * textureSize + x, y, CTM1.GetPixel(x, y));
					fusionTexture.SetPixel(2 * textureSize + x, y, CTM2.GetPixel(x, y));
					fusionTexture.SetPixel(3 * textureSize + x, y, CTM3.GetPixel(x, y));
					fusionTexture.SetPixel(4 * textureSize + x, y, CTM4.GetPixel(x, y));
				}
			}

			fusionTexture.Save(saveFileDialog.FileName);
			return;
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

		private void CheckBox_DeleteBackground_CheckedChanged(object sender, EventArgs e)
		{
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
			openFileDialog.FileName = filename[0];
			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename[0])))
				texture = new Bitmap(ms);

			SetTexture(texture);
			UpdatePictures();
		}

		private void UpdatePictures()
		{
			if (pictureBox_Texture.Image == null)
				return;

			pictureBoxCTM0.Image = texture.CTM0(borderColor).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			pictureBoxCTM1.Image = texture.CTM1(borderColor).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			pictureBoxCTM2.Image = texture.CTM2(borderColor).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			pictureBoxCTM3.Image = texture.CTM3(borderColor).Upscale(scaleFactor * defaultTextureWidth / texture.Width);
			pictureBoxCTM4.Image = texture.CTM4(borderColor).Upscale(scaleFactor * defaultTextureWidth / texture.Width);

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
