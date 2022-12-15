public class WaterGerstner // TypeDefIndex: 12380
{
	public const int WaveCount = 6;


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

public class WaterGerstner.WaveParams // TypeDefIndex: 12381
{
	[RangeAttribute]
	public float Angle;
	[RangeAttribute]
	public float Steepness;
	[RangeAttribute]
	public float Length;
	[RangeAttribute]
	public float Speed;


	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 12382
{
	[RangeAttribute]
	public float Steepness;
	[RangeAttribute]
	public float Amplitude;
	[RangeAttribute]
	public float Length;
	[RangeAttribute]
	public float Speed;
	public float[] DirectionAngles;
	public float DirectionVarFreq;
	public float DirectionVarAmp;


	public void .ctor() { }

}

public struct WaterGerstner.PrecomputedWave // TypeDefIndex: 12383
{
	public float Angle;
	public Vector2 Direction;
	public float Steepness;
	public float K;
	public float C;
	public float A;
	public static WaterGerstner.PrecomputedWave Default;


	private static void .cctor() { }

}

public struct WaterGerstner.PrecomputedShoreWaves // TypeDefIndex: 12384
{
	public Vector2[] Directions;
	public float Steepness;
	public float Amplitude;
	public float K;
	public float C;
	public float A;
	public float DirectionVarFreq;
	public float DirectionVarAmp;
	public static WaterGerstner.PrecomputedShoreWaves Default;


	private static void .cctor() { }

}

