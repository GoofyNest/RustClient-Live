public static class Noise // TypeDefIndex: 10289
{	// Fields
	public const float MIN = -1000000;
	public const float MAX = 1000000;

	// Methods

	// RVA: 0xA36300 Offset: 0xA35700 VA: 0x180A36300
	public static float Simplex1D(float x) { }

	// RVA: 0xA36310 Offset: 0xA35710 VA: 0x180A36310
	public static float Simplex2D(float x, float y) { }

	// RVA: 0xA36340 Offset: 0xA35740 VA: 0x180A36340
	public static float Turbulence(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA36210 Offset: 0xA35610 VA: 0x180A36210
	public static float Billow(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA362C0 Offset: 0xA356C0 VA: 0x180A362C0
	public static float Ridge(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA362F0 Offset: 0xA356F0 VA: 0x180A362F0
	public static float Sharp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA36320 Offset: 0xA35720 VA: 0x180A36320
	public static float TurbulenceIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA361F0 Offset: 0xA355F0 VA: 0x180A361F0
	public static float BillowIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA362A0 Offset: 0xA356A0 VA: 0x180A362A0
	public static float RidgeIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA362D0 Offset: 0xA356D0 VA: 0x180A362D0
	public static float SharpIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0xA36330 Offset: 0xA35730 VA: 0x180A36330
	public static float TurbulenceWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0xA36200 Offset: 0xA35600 VA: 0x180A36200
	public static float BillowWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0xA362B0 Offset: 0xA356B0 VA: 0x180A362B0
	public static float RidgeWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0xA362E0 Offset: 0xA356E0 VA: 0x180A362E0
	public static float SharpWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0xA36220 Offset: 0xA35620 VA: 0x180A36220
	public static float Jordan(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 1, float damp = 1, float damp_scale = 1) { }

}

