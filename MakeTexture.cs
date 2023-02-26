namespace CTMCompactTexturePreparer
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using CTMCompactTexturePreparer.Properties;

	public partial class MakeTexture : Form
	{
		Bitmap texture;
		Color borderColor;
		Image pictureBoxTemp;

		public MakeTexture()
		{
			InitializeComponent();
			pictureBoxTexture.AllowDrop = true;
		}

		private void ButtonSelectTexture_Click(object sender, EventArgs e)
		{

			openFileDialog.ShowDialog();
			string filename = openFileDialog.FileName;

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename)))
				texture = new Bitmap(ms);

			SetTexture(texture);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

			string suffix = checkBoxIsEmissive.Checked ? "_e" : "";

			CTM0(texture, borderColor).Save(folderBrowserDialog.SelectedPath + $@"\0{suffix}.png");
			CTM1(texture, borderColor).Save(folderBrowserDialog.SelectedPath + $@"\1{suffix}.png");
			CTM2(texture, borderColor).Save(folderBrowserDialog.SelectedPath + $@"\2{suffix}.png");
			CTM3(texture, borderColor).Save(folderBrowserDialog.SelectedPath + $@"\3{suffix}.png");
			CTM4(texture, borderColor).Save(folderBrowserDialog.SelectedPath + $@"\4{suffix}.png");
		}

		private void PictureBoxTexture_MouseClick(object sender, MouseEventArgs e)
		{
			using (Bitmap bmp = new Bitmap(pictureBoxTexture.Width, pictureBoxTexture.Height))
			{
				pictureBoxTexture.DrawToBitmap(bmp, pictureBoxTexture.ClientRectangle);
				borderColor = bmp.GetPixel(e.X, e.Y);
				panelColor.BackColor = bmp.GetPixel(e.X, e.Y);
			}

			UpdatePictures();
		}

		private void PanelColor_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.Cancel)
				return;

			panelColor.BackColor = colorDialog.Color;
			borderColor = colorDialog.Color;
			UpdatePictures();
		}

		private void CheckBoxIsEmissive_CheckedChanged(object sender, EventArgs e)
		{
			textBoxEmissiveSuffix.Enabled = checkBoxIsEmissive.Checked;
			label1.Enabled = checkBoxIsEmissive.Checked;
		}

		private Bitmap CTM0(Bitmap texture, Color color)
		{
			if (colorDialog.Color == null) throw new NullReferenceException();
			if (texture.Width != texture.Height) throw new Exception();
			Bitmap result = new Bitmap(texture);
			int maxI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(maxI, i, color); // right
				result.SetPixel(i, maxI, color); // bottom
				result.SetPixel(0, i, color); // left
				result.SetPixel(i, 0, color); // top
			}

			return result;
		}
		private Bitmap CTM1(Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();
			if (colorDialog.Color == null) throw new NullReferenceException();

			Bitmap result = new Bitmap(texture);

			return result;
		}
		private Bitmap CTM2(Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();
			if (colorDialog.Color == null) throw new NullReferenceException();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(topI, i, color); // right
				result.SetPixel(0, i, color); // left
			}

			return result;
		}
		private Bitmap CTM3(Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();
			if (colorDialog.Color == null) throw new NullReferenceException();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(i, topI, color); // bottom
				result.SetPixel(i, 0, color); // top
			}

			return result;
		}
		private Bitmap CTM4(Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();
			if (colorDialog.Color == null) throw new NullReferenceException();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			result.SetPixel(0, 0, color); // top left
			result.SetPixel(0, topI, color); // top right
			result.SetPixel(topI, 0, color); // bottom left
			result.SetPixel(topI, topI, color); // bottom right

			return result;
		}

		private void UpdatePictures()
		{
			if (pictureBoxTexture.Image == null)
				return;
			
			int scaleFactor = 5;
			int defaultTextureWidth = 16;

			pictureBoxCTM0.Image = CTM0(texture, borderColor).Upscale(scaleFactor*defaultTextureWidth/texture.Width);
			pictureBoxCTM1.Image = CTM1(texture, borderColor).Upscale(scaleFactor*defaultTextureWidth/texture.Width);
			pictureBoxCTM2.Image = CTM2(texture, borderColor).Upscale(scaleFactor*defaultTextureWidth/texture.Width);
			pictureBoxCTM3.Image = CTM3(texture, borderColor).Upscale(scaleFactor*defaultTextureWidth/texture.Width);
			pictureBoxCTM4.Image = CTM4(texture, borderColor).Upscale(scaleFactor*defaultTextureWidth/texture.Width);
		}																										
																												
		private void PictureBoxTexture_DragEnter(object sender, DragEventArgs e)
		{
			pictureBoxTemp = pictureBoxTexture.Image;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				pictureBoxTexture.Image = Resources.dragOver;
				e.Effect = DragDropEffects.Move;
			}
		}

		private void PictureBoxTexture_DragLeave(object sender, EventArgs e)
		{
			pictureBoxTexture.Image = pictureBoxTemp;
		}

		private void PictureBoxTexture_DragDrop(object sender, DragEventArgs e)
		{
			string[] filename = (string[])e.Data.GetData(DataFormats.FileDrop);

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename[0])))
				texture = new Bitmap(ms);

			SetTexture(texture);
			UpdatePictures();
		}

		private void SetTexture(Bitmap texture)
		{
			int scaleFactor = 20;
			int defaultTextureWidth = 16;

			pictureBoxTexture.Image = texture.Upscale(scaleFactor*defaultTextureWidth/texture.Width);
			UpdatePictures();
		}
	}
}
