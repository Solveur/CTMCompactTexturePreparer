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

			pictureBoxTexture.Image = Upscale(texture, 20);
			Execute();
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
			Execute();
		}

		private void PanelColor_Click(object sender, EventArgs e)
		{
			colorDialog.ShowDialog();
			panelColor.BackColor = colorDialog.Color;
			borderColor = colorDialog.Color;
			Execute();
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
			int topI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(topI, i, color); // right
				result.SetPixel(i, topI, color); // bottom
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

			result.SetPixel(0, 0, color);
			result.SetPixel(0, topI, color);
			result.SetPixel(topI, 0, color);
			result.SetPixel(topI, topI, color);

			return result;
		}

		private Bitmap Upscale(Bitmap source, int factor)
		{
			int sourceSize = source.Width;
			int size = sourceSize * factor;
			Bitmap result = new Bitmap(size, size);
			
			for(int x = 0; x < size; x++)
				for(int y = 0; y < size; y++)
				{
					result.SetPixel(x, y, source.GetPixel(x / factor, y / factor));
				}

			return result;
		}

		private void Execute()
		{
			if (pictureBoxTexture.Image == null) return;
			pictureBoxCTM0.Image = Upscale(CTM0(texture, borderColor), 5);
			pictureBoxCTM1.Image = Upscale(CTM1(texture, borderColor), 5);
			pictureBoxCTM2.Image = Upscale(CTM2(texture, borderColor), 5);
			pictureBoxCTM3.Image = Upscale(CTM3(texture, borderColor), 5);
			pictureBoxCTM4.Image = Upscale(CTM4(texture, borderColor), 5);
		}

		private void PictureBoxTexture_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string filename = @"S:\VS Source\CTMCompactTexturePreparer\dragOver.png";
				using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename)))
					pictureBoxTexture.Image = new Bitmap(ms);

				e.Effect = DragDropEffects.Move;
			}
		}

		private void PictureBoxTexture_DragLeave(object sender, EventArgs e)
		{
			pictureBoxTexture.Image = null;
		}

		private void PictureBoxTexture_DragDrop(object sender, DragEventArgs e)
		{
			string filename = e.Data.GetData(DataFormats.FileDrop).ToString();

			using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filename)))
				texture = new Bitmap(ms);

			pictureBoxTexture.Image = Upscale(texture, 20);
			Execute();
		}
	}
}
