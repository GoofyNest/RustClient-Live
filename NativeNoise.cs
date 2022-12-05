public static class NativeNoise // TypeDefIndex: 12047
{

	public static extern float Simplex1D(float x) { }

	public static extern float Simplex1D(float x, out float dx) { }

	public static extern float Simplex2D(float x, float y) { }

	public static extern float Simplex2D(float x, float y, out float dx, out float dy) { }

	public static extern float Turbulence(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float Billow(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float Ridge(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float Sharp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float TurbulenceIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float BillowIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float RidgeIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float SharpIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	public static extern float TurbulenceWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	public static extern float BillowWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	public static extern float RidgeWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	public static extern float SharpWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	public static extern float Jordan(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp, float damp, float damp_scale) { }

}

