public static class Noise // TypeDefIndex: 12040
{
	public const float MIN = -1000000;
	public const float MAX = 1000000;


	public static float Simplex1D(float x) { }

	public static float Simplex2D(float x, float y) { }

	public static float Turbulence(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float Billow(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float Ridge(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float Sharp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float TurbulenceIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float BillowIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float RidgeIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float SharpIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	public static float TurbulenceWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	public static float BillowWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	public static float RidgeWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	public static float SharpWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	public static float Jordan(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 1, float damp = 1, float damp_scale = 1) { }

}

