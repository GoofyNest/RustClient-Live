public class WaterGerstner // TypeDefIndex: 10610
{	public const int WaveCount = 6;


	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	public static void SampleHeightArray(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	public void .ctor() { }

}

public class WaterGerstner.WaveParams // TypeDefIndex: 10611
{	[RangeAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public float Angle; // 0x10
	[RangeAttribute] // RVA: 0xE6F00 Offset: 0xE6300 VA: 0x1800E6F00
	public float Steepness; // 0x14
	[RangeAttribute] // RVA: 0xE7080 Offset: 0xE6480 VA: 0x1800E7080
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBEBD0 Offset: 0xBDFD0 VA: 0x1800BEBD0
	public float Speed; // 0x1C


	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 10612
{	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
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


	public void .ctor() { }

}

public struct WaterGerstner.PrecomputedWave // TypeDefIndex: 10613
{	public float Angle; // 0x0
	public Vector2 Direction; // 0x4
	public float Steepness; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public static WaterGerstner.PrecomputedWave Default; // 0x0


	private static void .cctor() { }

}

public struct WaterGerstner.PrecomputedShoreWaves // TypeDefIndex: 10614
{	public Vector2[] Directions; // 0x0
	public float Steepness; // 0x8
	public float Amplitude; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public float DirectionVarFreq; // 0x1C
	public float DirectionVarAmp; // 0x20
	public static WaterGerstner.PrecomputedShoreWaves Default; // 0x0


	private static void .cctor() { }

}

