public class WaterGerstner // TypeDefIndex: 10610
{	// Fields
	public const int WaveCount = 6;

	// Methods

	// RVA: 0xC0D770 Offset: 0xC0CB70 VA: 0x180C0D770
	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	// RVA: 0xC0D490 Offset: 0xC0C890 VA: 0x180C0D490
	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	// RVA: 0xC0DE40 Offset: 0xC0D240 VA: 0x180C0DE40
	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	// RVA: 0xC0DB70 Offset: 0xC0CF70 VA: 0x180C0DB70
	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	// RVA: 0xC0BEB0 Offset: 0xC0B2B0 VA: 0x180C0BEB0
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	// RVA: 0xC0BD60 Offset: 0xC0B160 VA: 0x180C0BD60
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	// RVA: 0xC0BC50 Offset: 0xC0B050 VA: 0x180C0BC50
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	// RVA: 0xC0BAD0 Offset: 0xC0AED0 VA: 0x180C0BAD0
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	// RVA: 0xC0BF80 Offset: 0xC0B380 VA: 0x180C0BF80
	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC0CC40 Offset: 0xC0C040 VA: 0x180C0CC40
	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC0C580 Offset: 0xC0B980 VA: 0x180C0C580
	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0xC0D090 Offset: 0xC0C490 VA: 0x180C0D090
	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC0C720 Offset: 0xC0BB20 VA: 0x180C0C720
	public static void SampleHeightArray(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class WaterGerstner.WaveParams // TypeDefIndex: 10611
{	// Fields
	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float Angle; // 0x10
	[RangeAttribute] // RVA: 0xE6F00 Offset: 0xE6300 VA: 0x1800E6F00
	public float Steepness; // 0x14
	[RangeAttribute] // RVA: 0xE7080 Offset: 0xE6480 VA: 0x1800E7080
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBEBD0 Offset: 0xBDFD0 VA: 0x1800BEBD0
	public float Speed; // 0x1C

	// Methods

	// RVA: 0xC27710 Offset: 0xC26B10 VA: 0x180C27710
	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 10612
{	// Fields
	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
	public float Steepness; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Amplitude; // 0x14
	[RangeAttribute] // RVA: 0xE7080 Offset: 0xE6480 VA: 0x1800E7080
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBEBD0 Offset: 0xBDFD0 VA: 0x1800BEBD0
	public float Speed; // 0x1C
	public float[] DirectionAngles; // 0x20
	public float DirectionVarFreq; // 0x28
	public float DirectionVarAmp; // 0x2C

	// Methods

	// RVA: 0xC0B650 Offset: 0xC0AA50 VA: 0x180C0B650
	public void .ctor() { }

}

public struct WaterGerstner.PrecomputedWave // TypeDefIndex: 10613
{	// Fields
	public float Angle; // 0x0
	public Vector2 Direction; // 0x4
	public float Steepness; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public static WaterGerstner.PrecomputedWave Default; // 0x0

	// Methods

	// RVA: 0xC0B560 Offset: 0xC0A960 VA: 0x180C0B560
	private static void .cctor() { }

}

public struct WaterGerstner.PrecomputedShoreWaves // TypeDefIndex: 10614
{	// Fields
	public Vector2[] Directions; // 0x0
	public float Steepness; // 0x8
	public float Amplitude; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public float DirectionVarFreq; // 0x1C
	public float DirectionVarAmp; // 0x20
	public static WaterGerstner.PrecomputedShoreWaves Default; // 0x0

	// Methods

	// RVA: 0xC0B300 Offset: 0xC0A700 VA: 0x180C0B300
	private static void .cctor() { }

}

