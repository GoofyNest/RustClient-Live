public static class ManagedNoise // TypeDefIndex: 10287
{	// Fields
	private static readonly int[] hash; // 0x0
	private const int hashMask = 255;
	private const double sqrt2 = 1,4142135623731;
	private const double rsqrt2 = 0,707106781186548;
	private const double squaresToTriangles = 0,211324865405187;
	private const double trianglesToSquares = 0,366025403784439;
	private const double simplexScale1D = 2,40740740740741;
	private const double simplexScale2D = 32,9907739830396;
	private const double gradientScale2D = 4;
	private static double[] gradients1D; // 0x8
	private const int gradientsMask1D = 1;
	private static double[] gradients2Dx; // 0x10
	private static double[] gradients2Dy; // 0x18
	private const int gradientsMask2D = 7;

	// Methods

	// RVA: 0x57B110 Offset: 0x57A510 VA: 0x18057B110
	public static double Simplex1D(double x) { }

	// RVA: 0x57AE40 Offset: 0x57A240 VA: 0x18057AE40
	public static double Simplex1D(double x, out double dx) { }

	// RVA: 0x57B350 Offset: 0x57A750 VA: 0x18057B350
	public static double Simplex2D(double x, double y) { }

	// RVA: 0x57BA50 Offset: 0x57AE50 VA: 0x18057BA50
	public static double Simplex2D(double x, double y, out double dx, out double dy) { }

	// RVA: 0x57C690 Offset: 0x57BA90 VA: 0x18057C690
	public static double Turbulence(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x579FC0 Offset: 0x5793C0 VA: 0x180579FC0
	public static double Billow(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57A7A0 Offset: 0x579BA0 VA: 0x18057A7A0
	public static double Ridge(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57AD10 Offset: 0x57A110 VA: 0x18057AD10
	public static double Sharp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57C2C0 Offset: 0x57B6C0 VA: 0x18057C2C0
	public static double TurbulenceIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x579BD0 Offset: 0x578FD0 VA: 0x180579BD0
	public static double BillowIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57A3A0 Offset: 0x5797A0 VA: 0x18057A3A0
	public static double RidgeIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57A930 Offset: 0x579D30 VA: 0x18057A930
	public static double SharpIQ(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain) { }

	// RVA: 0x57C480 Offset: 0x57B880 VA: 0x18057C480
	public static double TurbulenceWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x579DA0 Offset: 0x5791A0 VA: 0x180579DA0
	public static double BillowWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x57A570 Offset: 0x579970 VA: 0x18057A570
	public static double RidgeWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x57AAF0 Offset: 0x579EF0 VA: 0x18057AAF0
	public static double SharpWarp(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp) { }

	// RVA: 0x57A130 Offset: 0x579530 VA: 0x18057A130
	public static double Jordan(double x, double y, int octaves, double frequency, double amplitude, double lacunarity, double gain, double warp, double damp, double damp_scale) { }

	// RVA: 0x57A120 Offset: 0x579520 VA: 0x18057A120
	private static int Floor(double x) { }

	// RVA: 0x579BB0 Offset: 0x578FB0 VA: 0x180579BB0
	private static double Abs(double x) { }

	// RVA: 0x57A910 Offset: 0x579D10 VA: 0x18057A910
	private static double Saturate(double x) { }

	// RVA: 0x57C7B0 Offset: 0x57BBB0 VA: 0x18057C7B0
	private static void .cctor() { }

}

