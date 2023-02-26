namespace CTMCompactTexturePreparer
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

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
	}
}
