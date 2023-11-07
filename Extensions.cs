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

		public static Bitmap DeleteBackground(this Bitmap source, Bitmap background)
		{
			if (source.Width != background.Width || source.Height != background.Height)
			{
				throw new Exception("Size of picture and background are not the same");
			}

			int size = source.Width;
			Bitmap result = source;

			for (int y = 0; y < size; y++)
			{
				for (int x = 0; x < size; x++)
				{
					if (source.GetPixel(x, y) == background.GetPixel(x, y))
					{
						source.SetPixel(x, y, Color.Transparent);
					}
				}
			}

			return result;
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
