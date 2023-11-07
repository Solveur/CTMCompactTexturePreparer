namespace CTMCompactTexturePreparer
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	internal static class Extensions
	{
		public static Bitmap Upscale(this Bitmap source, int factor)
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

		public static Bitmap DeleteBackground(this Bitmap image)
		{
			int size = image.Width;
			Bitmap result = new Bitmap(size,size);

			Color avgColor = image.GetAvgColor();
			int avgGrey = (avgColor.R + avgColor.G + avgColor.B) / 3;

			for (int y = 0; y < size; y++)
				for (int x = 0; x < size; x++)
				{

					int diffRed = avgGrey - image.GetPixel(x,y).R;
					int diffGreen = avgGrey - image.GetPixel(x,y).G;
					int diffBlue = avgGrey - image.GetPixel(x,y).B;

					diffRed = Math.Abs(diffRed);
					diffGreen = Math.Abs(diffGreen);
					diffBlue = Math.Abs(diffBlue);

					if (diffRed < 40 && diffGreen < 40 && diffBlue < 40) // Magic numbers but works
						result.SetPixel(x, y, Color.Transparent);
					else
						result.SetPixel(x, y, image.GetPixel(x, y));
				}

			return result;
		}

		public static Color GetAvgColor(this Bitmap image)
		{
			int totalRed = 0;
			int numRed = 0;
			int totalGreen = 0;
			int numGreen = 0;
			int totalBlue = 0;
			int numBlue = 0;

			int size = image.Width;
			
			for (int y = 0; y < size; y++)
				for (int x = 0; x < size; x++)
				{
					totalRed += image.GetPixel(x, y).R;
					numRed++;

					totalGreen += image.GetPixel(x, y).G;
					numGreen++;

					totalBlue += image.GetPixel(x, y).B;
					numBlue++;
				}

			int avgRed = totalRed / numRed;
			int avgGreen = totalGreen / numGreen;
			int avgBlue = totalBlue / numBlue;

			return Color.FromArgb(avgRed, avgGreen, avgBlue);
		}

		public static Bitmap CTM0(this Bitmap texture, Color color)
		{
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

		public static Bitmap CTM1(this Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();

			Bitmap result = new Bitmap(texture);

			return result;
		}

		public static Bitmap CTM2(this Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(topI, i, color); // right
				result.SetPixel(0, i, color); // left
			}

			return result;
		}

		public static Bitmap CTM3(this Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			for (int i = 0; i < texture.Width; i++)
			{
				result.SetPixel(i, topI, color); // bottom
				result.SetPixel(i, 0, color); // top
			}

			return result;
		}

		public static Bitmap CTM4(this Bitmap texture, Color color)
		{
			if (texture.Width != texture.Height) throw new Exception();

			Bitmap result = new Bitmap(texture);
			int topI = texture.Width - 1; // 15|31|63|127

			result.SetPixel(0, 0, color); // top left
			result.SetPixel(0, topI, color); // top right
			result.SetPixel(topI, 0, color); // bottom left
			result.SetPixel(topI, topI, color); // bottom right

			return result;
		}
	}
}
