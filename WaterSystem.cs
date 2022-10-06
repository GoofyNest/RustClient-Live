public class WaterSystem : MonoBehaviour // TypeDefIndex: 12343
{
	public WaterQuality Quality; 
	public bool ShowDebug; 
	public bool ShowGizmos; 
	public bool ProgressTime; 
	public GameObject FallbackPlane; 
	public WaterSystem.SimulationSettings Simulation; 
	public WaterSystem.RenderingSettings Rendering; 
	private WaterGerstner.PrecomputedWave[] precomputedWaves; 
	private WaterGerstner.PrecomputedShoreWaves precomputedShoreWaves; 
	private Vector4[] waveArray; 
	private Vector4[] shoreWaveArray; 
	private Vector4 global0; 
	private Vector4 global1; 
	[CompilerGeneratedAttribute] 
	private float <ShoreWavesRcpFadeDistance>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <TerrainRcpFadeDistance>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsInitialized>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static WaterCollision <Collision>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static WaterDynamics <Dynamics>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static WaterBody <Ocean>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static HashSet<WaterBody> <WaterBodies>k__BackingField; 
	private static float oceanLevel; 
	[CompilerGeneratedAttribute] 
	private static float <WaveTime>k__BackingField; 
	public static readonly int[] QualityToMaxVertices; 
	private WaterQuality prevQuality; 
	private ReflectionProbeEx reflectionProbe; 
	private float reflectionProbeUpdateTime; 
	private bool reflectionProbeReady; 
	private Texture2D defaultHeightSlopeMap; 
	private bool hasValidCausticsAnims; 
	private List<WaterRuntime> runtimeCleanup; 
	[CompilerGeneratedAttribute] 
	private static Dictionary<WaterCamera, WaterRuntime> <Runtimes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static HashSet<WaterDepthMask> <DepthMasks>k__BackingField; 
	private static WaterSystem instance; 
	private static Vector3[] emptyShoreMap; 
	private static short[] emptyWaterMap; 
	private static short[] emptyHeightMap; 
	private static WaterSystem.NativePathState nativePathState; 
	private static Vector3[] currentShoreMap; 
	private static GCHandle currentShoreMapHandle; 
	private static short[] currentWaterMap; 
	private static GCHandle currentWaterMapHandle; 
	private static short[] currentHeightMap; 
	private static GCHandle currentHeightMapHandle; 
	private static Vector4[] currentOpenWaves; 
	private static GCHandle currentOpenWavesHandle; 
	private static Vector4[] currentShoreWaves; 
	private static GCHandle currentShoreWavesHandle; 
	private float lastQualityChange; 

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

	[CompilerGeneratedAttribute] 
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] 
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] 
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] 
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] 
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] 
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] 
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] 
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] 
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] 
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] 
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] 
	public static HashSet<WaterBody> get_WaterBodies() { }

	public static float get_OceanLevel() { }

	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] 
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] 
	private static void set_WaveTime(float value) { }

	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] 
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] 
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] 
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] 
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

public class WaterSystem.SimulationSettings // TypeDefIndex: 12344
{
	public Vector3 Wind; 
	public int SolverResolution; 
	public float SolverSizeInWorld; 
	public float Gravity; 
	public float Amplitude; 
	public Texture2D PerlinNoise; 
	public WaterGerstner.WaveParams[] OpenSeaWaves; 
	public WaterGerstner.ShoreWaveParams ShoreWaves; 
	[RangeAttribute] 
	public float ShoreWavesFadeDistance; 
	[RangeAttribute] 
	public float TerrainFadeDistance; 
	[RangeAttribute] 
	public float OpenSeaCrestFoamThreshold; 
	[RangeAttribute] 
	public float ShoreCrestFoamThreshold; 
	[RangeAttribute] 
	public float ShoreCrestFoamFarThreshold; 
	[RangeAttribute] 
	public float ShoreCrestFoamFadeDistance; 


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 12345
{
	public float MaxDisplacementDistance; 
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; 
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; 
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; 


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 12346
{
	public float ProbeUpdateInterval; 
	public bool TimeSlicing; 


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SSR // TypeDefIndex: 12347
{
	public float FresnelCutoff; 
	public float ThicknessMin; 
	public float ThicknessMax; 
	public float ThicknessStartDist; 
	public float ThicknessEndDist; 


	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 12348
{
	public float FrameRate; 
	public Texture2D[] FramesShallow; 
	public Texture2D[] FramesDeep; 


	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 12349
{
	public int value__; 
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

