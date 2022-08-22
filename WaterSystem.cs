public class WaterSystem : MonoBehaviour // TypeDefIndex: 10626
{	public WaterQuality Quality; // 0x18
	public bool ShowDebug; // 0x1C
	public bool ShowGizmos; // 0x1D
	public bool ProgressTime; // 0x1E
	public GameObject FallbackPlane; // 0x20
	public WaterSystem.SimulationSettings Simulation; // 0x28
	public WaterSystem.RenderingSettings Rendering; // 0x30
	private WaterGerstner.PrecomputedWave[] precomputedWaves; // 0x38
	private WaterGerstner.PrecomputedShoreWaves precomputedShoreWaves; // 0x40
	private Vector4[] waveArray; // 0x68
	private Vector4[] shoreWaveArray; // 0x70
	private Vector4 global0; // 0x78
	private Vector4 global1; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <ShoreWavesRcpFadeDistance>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <TerrainRcpFadeDistance>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsInitialized>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static WaterCollision <Collision>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static WaterDynamics <Dynamics>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static WaterBody <Ocean>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static HashSet<WaterBody> <WaterBodies>k__BackingField; // 0x18
	private static float oceanLevel; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static float <WaveTime>k__BackingField; // 0x24
	public static readonly int[] QualityToMaxVertices; // 0x28
	private WaterQuality prevQuality; // 0xA4
	private ReflectionProbeEx reflectionProbe; // 0xA8
	private float reflectionProbeUpdateTime; // 0xB0
	private bool reflectionProbeReady; // 0xB4
	private Texture2D defaultHeightSlopeMap; // 0xB8
	private bool hasValidCausticsAnims; // 0xC0
	private List<WaterRuntime> runtimeCleanup; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Dictionary<WaterCamera, WaterRuntime> <Runtimes>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static HashSet<WaterDepthMask> <DepthMasks>k__BackingField; // 0x38
	private static WaterSystem instance; // 0x40
	private static Vector3[] emptyShoreMap; // 0x48
	private static short[] emptyWaterMap; // 0x50
	private static short[] emptyHeightMap; // 0x58
	private static WaterSystem.NativePathState nativePathState; // 0x60
	private static Vector3[] currentShoreMap; // 0x68
	private static GCHandle currentShoreMapHandle; // 0x70
	private static short[] currentWaterMap; // 0x78
	private static GCHandle currentWaterMapHandle; // 0x80
	private static short[] currentHeightMap; // 0x88
	private static GCHandle currentHeightMapHandle; // 0x90
	private static Vector4[] currentOpenWaves; // 0x98
	private static GCHandle currentOpenWavesHandle; // 0xA0
	private static Vector4[] currentShoreWaves; // 0xA8
	private static GCHandle currentShoreWavesHandle; // 0xB0
	private float lastQualityChange; // 0xD0

	public WaterGerstner.PrecomputedWave[] PrecomputedWaves { get; }
	public WaterGerstner.PrecomputedShoreWaves PrecomputedShoreWaves { get; }
	public Vector4 Global0 { get; }
	public Vector4 Global1 { get; }
	public float ShoreWavesRcpFadeDistance { get; set; }
	public float TerrainRcpFadeDistance { get; set; }
	public bool IsInitialized { get; set; }
	public static WaterCollision Collision { get; set; }
	public static WaterDynamics Dynamics { get; set; }
	public static WaterBody Ocean { get; set; }
	public static HashSet<WaterBody> WaterBodies { get; set; }
	public static float OceanLevel { get; set; }
	public static float WaveTime { get; set; }
	public bool HasCaustics { get; }
	public static Dictionary<WaterCamera, WaterRuntime> Runtimes { get; set; }
	public static HashSet<WaterDepthMask> DepthMasks { get; set; }
	public static WaterSystem Instance { get; }


	public WaterGerstner.PrecomputedWave[] get_PrecomputedWaves() { }

	public WaterGerstner.PrecomputedShoreWaves get_PrecomputedShoreWaves() { }

	public Vector4 get_Global0() { }

	public Vector4 get_Global1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static HashSet<WaterBody> get_WaterBodies() { }

	public static float get_OceanLevel() { }

	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_WaveTime(float value) { }

	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static HashSet<WaterDepthMask> get_DepthMasks() { }

	public static WaterSystem get_Instance() { }

	private void CheckInstance() { }

	public void Awake() { }

	private static extern void SetBaseConstants_Native(int shoreMapSize, ref Vector3 shoreMap, int waterHeightMapSize, ref short waterHeightMap, Vector4 packedParams) { }

	private static extern void SetTerrainConstants_Native(int terrainHeightMapSize, ref short terrainHeightMap, Vector3 terrainPosition, Vector3 terrainSize) { }

	private static extern void SetGerstnerConstants_Native(Vector4 globalParams0, Vector4 globalParams1, ref Vector4 openWaves, ref Vector4 shoreWaves) { }

	private static extern void UpdateOceanLevel_Native(float oceanWaterLevel) { }

	private static extern float GetHeightArray_Native(int sampleCount, ref Vector2 pos, ref Vector2 posUV, ref Vector3 shore, ref float terrainHeight, ref float waterHeight) { }

	private static extern float GetHeight_Native(Vector3 pos) { }

	private static extern bool CPU_SupportsSSE41() { }

	private static void SetNativeConstants(TerrainTexturing terrainTexturing, TerrainWaterMap terrainWaterMap, TerrainHeightMap terrainHeightMap, Vector4 globalParams0, Vector4 globalParams1, Vector4[] openWaves, Vector4[] shoreWaves) { }

	private static void PinObject<T>(T value, ref T currentValue, ref GCHandle currentValueHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3D40 Offset: 0x5F3140 VA: 0x1805F3D40
	|-WaterSystem.PinObject<short[]>
	|-WaterSystem.PinObject<object>
	|-WaterSystem.PinObject<Vector3[]>
	|-WaterSystem.PinObject<Vector4[]>
	*/

	private static float GetHeight_Managed(Vector3 pos) { }

	public static void GetHeightArray_Managed(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	public static float GetHeight(Vector3 pos) { }

	public static void GetHeightArray(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	public static Vector3 GetNormal(Vector3 pos) { }

	public static void RegisterBody(WaterBody body) { }

	public static void UnregisterBody(WaterBody body) { }

	private void UpdateWaves() { }

	private static void UpdateOceanLevel() { }

	public void UpdateWaveData() { }

	private void Update() { }

	private static void ShutdownRuntimes() { }

	public static void Clear() { }

	public static void RegisterCamera(WaterCamera camera) { }

	public static void UnregisterCamera(WaterCamera camera) { }

	public static void RegisterDepthMask(WaterDepthMask mask) { }

	public static void UnregisterDepthMask(WaterDepthMask mask) { }

	private void CreateReflectionProbe() { }

	private void DestroyReflectionProbe() { }

	private void CheckReflectionProbe() { }

	private void CreateDefaultHeightSlopeMap() { }

	private void DestroyDefaultHeightSlopeMap() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void UpdateClient() { }

	private void DestroyComputeBuffer(ref ComputeBuffer buffer) { }

	private void UpdateWavesClient() { }

	private void UpdateRuntimes() { }

	public void UpdateMaterial(Material material) { }

	public void ClearUnderwaterScatterCoefficientOverride() { }

	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	private void UpdateReflectionProbe() { }

	public void ResetVisibility() { }

	public void ToggleVisibility(int mask) { }

	private void UpdateGlobalShaderProperties() { }

	private bool UpdateQuality() { }

	private void DisableFallbackPlane() { }

	private void UpdateKeywords() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class WaterSystem.SimulationSettings // TypeDefIndex: 10627
{	public Vector3 Wind; // 0x10
	public int SolverResolution; // 0x1C
	public float SolverSizeInWorld; // 0x20
	public float Gravity; // 0x24
	public float Amplitude; // 0x28
	public Texture2D PerlinNoise; // 0x30
	public WaterGerstner.WaveParams[] OpenSeaWaves; // 0x38
	public WaterGerstner.ShoreWaveParams ShoreWaves; // 0x40
	[RangeAttribute] // RVA: 0xECB70 Offset: 0xEBF70 VA: 0x1800ECB70
	public float ShoreWavesFadeDistance; // 0x48
	[RangeAttribute] // RVA: 0xECB70 Offset: 0xEBF70 VA: 0x1800ECB70
	public float TerrainFadeDistance; // 0x4C
	[RangeAttribute] // RVA: 0xECCD0 Offset: 0xEC0D0 VA: 0x1800ECCD0
	public float OpenSeaCrestFoamThreshold; // 0x50
	[RangeAttribute] // RVA: 0xECCD0 Offset: 0xEC0D0 VA: 0x1800ECCD0
	public float ShoreCrestFoamThreshold; // 0x54
	[RangeAttribute] // RVA: 0xECCD0 Offset: 0xEC0D0 VA: 0x1800ECCD0
	public float ShoreCrestFoamFarThreshold; // 0x58
	[RangeAttribute] // RVA: 0xECB70 Offset: 0xEBF70 VA: 0x1800ECB70
	public float ShoreCrestFoamFadeDistance; // 0x5C


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 10628
{	public float MaxDisplacementDistance; // 0x10
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; // 0x18
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; // 0x20
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; // 0x28


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 10629
{	public float ProbeUpdateInterval; // 0x10
	public bool TimeSlicing; // 0x14


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SSR // TypeDefIndex: 10630
{	public float FresnelCutoff; // 0x10
	public float ThicknessMin; // 0x14
	public float ThicknessMax; // 0x18
	public float ThicknessStartDist; // 0x1C
	public float ThicknessEndDist; // 0x20


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 10631
{	public float FrameRate; // 0x10
	public Texture2D[] FramesShallow; // 0x18
	public Texture2D[] FramesDeep; // 0x20


	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 10632
{	public int value__; // 0x0
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

