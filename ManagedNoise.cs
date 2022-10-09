public static class ManagedNoise // TypeDefIndex: 12006
{
	private static readonly int[] hash; 
	private const int hashMask = 255;
	private const double sqrt2 = 1,4142135623731;
	private const double rsqrt2 = 0,707106781186548;
	private const double squaresToTriangles = 0,211324865405187;
	private const double trianglesToSquares = 0,366025403784439;
	private const double simplexScale1D = 2,40740740740741;
	private const double simplexScale2D = 32,9907739830396;
	private const double gradientScale2D = 4;
	private static double[] gradients1D; 
	private const int gradientsMask1D = 1;
	private static double[] gradients2Dx; 
	private static double[] gradients2Dy; 
	private const int gradientsMask2D = 7;


	public static double Simplex1D(double x) { }

	public static double Simplex1D(double x, out double dx) { }

	public static double Simplex2D(double x, double y) { }

	public static double Simplex2D(double x, double y, out double dx, out double dy) { }

	public static double Turbulence(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double Billow(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double Ridge(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double Sharp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double TurbulenceIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double BillowIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double RidgeIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double SharpIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	public static double TurbulenceWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	public static double BillowWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	public static double RidgeWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	public static double SharpWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	public static double Jordan(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp, double damp, double damp_scale) { }

	private static int Floor(double x) { }

	private static double Abs(double x) { }

	private static double Saturate(double x) { }

	private static void .cctor() { }

}

