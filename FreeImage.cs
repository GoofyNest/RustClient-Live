public static class FreeImage // TypeDefIndex: 8042
{
	public const uint FI_RGBA_RED_MASK = 16711680;
	public const uint FI_RGBA_GREEN_MASK = 65280;
	public const uint FI_RGBA_BLUE_MASK = 255;
	public const string FreeImageLibrary = "FreeImage";


	public static extern FreeImage.Format GetFIFFromFilename(string filename) { }

	public static extern FreeImage.Bitmap Load(FreeImage.Format fif, string filename, FreeImage.LoadFlags flags = 0) { }

	public static extern bool Save(FreeImage.Format fif, FreeImage.Bitmap bitmap, string filename, FreeImage.SaveFlags flags = 0) { }

	public static extern FreeImage.Bitmap Allocate(int width, int height, int bpp, uint red_mask = 16711680, uint green_mask = 65280, uint blue_mask = 255) { }

	public static extern void Unload(FreeImage.Bitmap bitmap) { }

	public static extern IntPtr GetBits(FreeImage.Bitmap bitmap) { }

	public static extern uint GetBPP(FreeImage.Bitmap bitmap) { }

	public static extern uint GetWidth(FreeImage.Bitmap bitmap) { }

	public static extern uint GetHeight(FreeImage.Bitmap bitmap) { }

	public static extern uint GetLine(FreeImage.Bitmap bitmap) { }

	public static extern uint GetPitch(FreeImage.Bitmap bitmap) { }

	public static extern bool GetPixelColor(FreeImage.Bitmap bitmap, uint x, uint y, out FreeImage.RGBQuad value) { }

	public static extern FreeImage.Bitmap Rescale(FreeImage.Bitmap bitmap, int dst_width, int dst_height, FreeImage.Filter filter) { }

	public static extern FreeImage.Bitmap ConvertTo24Bits(FreeImage.Bitmap bitmap) { }

	public static extern FreeImage.Bitmap ConvertTo32Bits(FreeImage.Bitmap bitmap) { }

}

public enum FreeImage.Format // TypeDefIndex: 8043
{
	public int value__;
	public const FreeImage.Format Unknown = -1;
	public const FreeImage.Format BMP = 0;
	public const FreeImage.Format JPEG = 2;
	public const FreeImage.Format PNG = 13;
	public const FreeImage.Format TARGA = 17;
	public const FreeImage.Format TIFF = 18;
	public const FreeImage.Format PSD = 20;
	public const FreeImage.Format DDS = 24;
	public const FreeImage.Format HDR = 26;
	public const FreeImage.Format EXR = 29;
	public const FreeImage.Format J2K = 30;
	public const FreeImage.Format JP2 = 31;
	public const FreeImage.Format WEBP = 35;
	public const FreeImage.Format JXR = 36;

}

public enum FreeImage.SaveFlags // TypeDefIndex: 8044
{
	public int value__;
	public const FreeImage.SaveFlags DEFAULT = 0;
	public const FreeImage.SaveFlags BMP_SAVE_RLE = 1;
	public const FreeImage.SaveFlags EXR_FLOAT = 1;
	public const FreeImage.SaveFlags EXR_NONE = 2;
	public const FreeImage.SaveFlags EXR_ZIP = 4;
	public const FreeImage.SaveFlags EXR_PIZ = 8;
	public const FreeImage.SaveFlags EXR_PXR24 = 16;
	public const FreeImage.SaveFlags EXR_B44 = 32;
	public const FreeImage.SaveFlags EXR_LC = 64;
	public const FreeImage.SaveFlags JPEG_QUALITYSUPERB = 128;
	public const FreeImage.SaveFlags JPEG_QUALITYGOOD = 256;
	public const FreeImage.SaveFlags JPEG_QUALITYNORMAL = 512;
	public const FreeImage.SaveFlags JPEG_QUALITYAVERAGE = 1024;
	public const FreeImage.SaveFlags JPEG_QUALITYBAD = 2048;
	public const FreeImage.SaveFlags JPEG_PROGRESSIVE = 8192;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_411 = 4096;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_420 = 16384;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_422 = 32768;
	public const FreeImage.SaveFlags JPEG_SUBSAMPLING_444 = 65536;
	public const FreeImage.SaveFlags JPEG_OPTIMIZE = 131072;
	public const FreeImage.SaveFlags JPEG_BASELINE = 262144;
	public const FreeImage.SaveFlags PNG_Z_BEST_SPEED = 1;
	public const FreeImage.SaveFlags PNG_Z_DEFAULT_COMPRESSION = 6;
	public const FreeImage.SaveFlags PNG_Z_BEST_COMPRESSION = 9;
	public const FreeImage.SaveFlags PNG_Z_NO_COMPRESSION = 256;
	public const FreeImage.SaveFlags PNG_INTERLACED = 512;
	public const FreeImage.SaveFlags PNM_SAVE_ASCII = 1;
	public const FreeImage.SaveFlags TIFF_CMYK = 1;
	public const FreeImage.SaveFlags TIFF_PACKBITS = 256;
	public const FreeImage.SaveFlags TIFF_DEFLATE = 512;
	public const FreeImage.SaveFlags TIFF_ADOBE_DEFLATE = 1024;
	public const FreeImage.SaveFlags TIFF_NONE = 2048;
	public const FreeImage.SaveFlags TIFF_CCITTFAX3 = 4096;
	public const FreeImage.SaveFlags TIFF_CCITTFAX4 = 8192;
	public const FreeImage.SaveFlags TIFF_LZW = 16384;
	public const FreeImage.SaveFlags TIFF_JPEG = 32768;

}

public enum FreeImage.LoadFlags // TypeDefIndex: 8045
{
	public int value__;
	public const FreeImage.LoadFlags DEFAULT = 0;
	public const FreeImage.LoadFlags GIF_LOAD256 = 1;
	public const FreeImage.LoadFlags GIF_PLAYBACK = 2;
	public const FreeImage.LoadFlags ICO_MAKEALPHA = 1;
	public const FreeImage.LoadFlags JPEG_FAST = 1;
	public const FreeImage.LoadFlags JPEG_ACCURATE = 2;
	public const FreeImage.LoadFlags JPEG_CMYK = 4;
	public const FreeImage.LoadFlags JPEG_EXIFROTATE = 8;
	public const FreeImage.LoadFlags PCD_BASE = 1;
	public const FreeImage.LoadFlags PCD_BASEDIV4 = 2;
	public const FreeImage.LoadFlags PCD_BASEDIV16 = 3;
	public const FreeImage.LoadFlags PNG_IGNOREGAMMA = 1;
	public const FreeImage.LoadFlags TARGA_LOAD_RGB888 = 1;
	public const FreeImage.LoadFlags TIFF_CMYK = 1;
	public const FreeImage.LoadFlags RAW_PREVIEW = 1;
	public const FreeImage.LoadFlags RAW_DISPLAY = 2;

}

public struct FreeImage.Header // TypeDefIndex: 8046
{
	public uint size;
	public int width;
	public int height;
	public ushort planes;
	public ushort bitCount;
	public uint compression;
	public uint sizeImage;
	public int xPelsPerMeter;
	public int yPelsPerMeter;
	public uint clrUsed;
	public uint clrImportant;

}

public struct FreeImage.Bitmap // TypeDefIndex: 8047
{
	public IntPtr data;
	public static FreeImage.Bitmap Null;

	public bool IsNull { get; }


	public bool get_IsNull() { }

	public void Unload() { }

	private static void .cctor() { }

}

public struct FreeImage.RGBQuad // TypeDefIndex: 8048
{
	public byte rgbBlue;
	public byte rgbGreen;
	public byte rgbRed;
	public byte rgbReserved;
	public uint uintValue;

}

public enum FreeImage.Filter // TypeDefIndex: 8049
{
	public int value__;
	public const FreeImage.Filter Box = 0;
	public const FreeImage.Filter Bicubic = 1;
	public const FreeImage.Filter Bilinear = 2;
	public const FreeImage.Filter Bspline = 3;
	public const FreeImage.Filter CatmullRom = 4;
	public const FreeImage.Filter Lanczos3 = 5;

}

