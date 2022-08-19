public static class NativeNoise // TypeDefIndex: 10288
{	// Methods

	// RVA: 0x7C7DF0 Offset: 0x7C71F0 VA: 0x1807C7DF0
	public static extern float Simplex1D(float x) { }

	// RVA: 0x7C7D60 Offset: 0x7C7160 VA: 0x1807C7D60
	public static extern float Simplex1D(float x, out float dx) { }

	// RVA: 0x7C7E70 Offset: 0x7C7270 VA: 0x1807C7E70
	public static extern float Simplex2D(float x, float y) { }

	// RVA: 0x7C7F00 Offset: 0x7C7300 VA: 0x1807C7F00
	public static extern float Simplex2D(float x, float y, out float dx, out float dy) { }

	// RVA: 0x7C8190 Offset: 0x7C7590 VA: 0x1807C8190
	public static extern float Turbulence(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C75C0 Offset: 0x7C69C0 VA: 0x1807C75C0
	public static extern float Billow(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C79A0 Offset: 0x7C6DA0 VA: 0x1807C79A0
	public static extern float Ridge(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C7C70 Offset: 0x7C7070 VA: 0x1807C7C70
	public static extern float Sharp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C7FB0 Offset: 0x7C73B0 VA: 0x1807C7FB0
	public static extern float TurbulenceIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C73E0 Offset: 0x7C67E0 VA: 0x1807C73E0
	public static extern float BillowIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C77C0 Offset: 0x7C6BC0 VA: 0x1807C77C0
	public static extern float RidgeIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C7A90 Offset: 0x7C6E90 VA: 0x1807C7A90
	public static extern float SharpIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C80A0 Offset: 0x7C74A0 VA: 0x1807C80A0
	public static extern float TurbulenceWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C74D0 Offset: 0x7C68D0 VA: 0x1807C74D0
	public static extern float BillowWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C78B0 Offset: 0x7C6CB0 VA: 0x1807C78B0
	public static extern float RidgeWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C7B80 Offset: 0x7C6F80 VA: 0x1807C7B80
	public static extern float SharpWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C76B0 Offset: 0x7C6AB0 VA: 0x1807C76B0
	public static extern float Jordan(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp, float damp, float damp_scale) { }

}

