public class WaterSystem : MonoBehaviour // TypeDefIndex: 10626
{	// Fields
	public WaterQuality Quality; // 0x18
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

	// Properties
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

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public WaterGerstner.PrecomputedWave[] get_PrecomputedWaves() { }

	// RVA: 0xC270A0 Offset: 0xC264A0 VA: 0x180C270A0
	public WaterGerstner.PrecomputedShoreWaves get_PrecomputedShoreWaves() { }

	// RVA: 0xC26ED0 Offset: 0xC262D0 VA: 0x180C26ED0
	public Vector4 get_Global0() { }

	// RVA: 0xC26EE0 Offset: 0xC262E0 VA: 0x180C26EE0
	public Vector4 get_Global1() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x715950 Offset: 0x714D50 VA: 0x180715950
	public float get_ShoreWavesRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x715D40 Offset: 0x715140 VA: 0x180715D40
	private void set_ShoreWavesRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27180 Offset: 0xC26580 VA: 0x180C27180
	public float get_TerrainRcpFadeDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27620 Offset: 0xC26A20 VA: 0x180C27620
	private void set_TerrainRcpFadeDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27450 Offset: 0xC26850 VA: 0x180C27450
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26F70 Offset: 0xC26370 VA: 0x180C26F70
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26DB0 Offset: 0xC261B0 VA: 0x180C26DB0
	public static WaterCollision get_Collision() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27310 Offset: 0xC26710 VA: 0x180C27310
	private static void set_Collision(WaterCollision value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC273E0 Offset: 0xC267E0 VA: 0x180C273E0
	private static void set_Dynamics(WaterDynamics value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26E70 Offset: 0xC26270 VA: 0x180C26E70
	public static WaterDynamics get_Dynamics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27540 Offset: 0xC26940 VA: 0x180C27540
	private static void set_Ocean(WaterBody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26FE0 Offset: 0xC263E0 VA: 0x180C26FE0
	public static WaterBody get_Ocean() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27630 Offset: 0xC26A30 VA: 0x180C27630
	private static void set_WaterBodies(HashSet<WaterBody> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27190 Offset: 0xC26590 VA: 0x180C27190
	public static HashSet<WaterBody> get_WaterBodies() { }

	// RVA: 0xC26F80 Offset: 0xC26380 VA: 0x180C26F80
	public static float get_OceanLevel() { }

	// RVA: 0xC27460 Offset: 0xC26860 VA: 0x180C27460
	public static void set_OceanLevel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27250 Offset: 0xC26650 VA: 0x180C27250
	public static float get_WaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC276A0 Offset: 0xC26AA0 VA: 0x180C276A0
	private static void set_WaveTime(float value) { }

	// RVA: 0xC26EF0 Offset: 0xC262F0 VA: 0x180C26EF0
	public bool get_HasCaustics() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC275B0 Offset: 0xC269B0 VA: 0x180C275B0
	private static void set_Runtimes(Dictionary<WaterCamera, WaterRuntime> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC270C0 Offset: 0xC264C0 VA: 0x180C270C0
	public static Dictionary<WaterCamera, WaterRuntime> get_Runtimes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27370 Offset: 0xC26770 VA: 0x180C27370
	private static void set_DepthMasks(HashSet<WaterDepthMask> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26E10 Offset: 0xC26210 VA: 0x180C26E10
	public static HashSet<WaterDepthMask> get_DepthMasks() { }

	// RVA: 0xC26F10 Offset: 0xC26310 VA: 0x180C26F10
	public static WaterSystem get_Instance() { }

	// RVA: 0xC1F420 Offset: 0xC1E820 VA: 0x180C1F420
	private void CheckInstance() { }

	// RVA: 0xC1F3A0 Offset: 0xC1E7A0 VA: 0x180C1F3A0
	public void Awake() { }

	// RVA: 0xC222C0 Offset: 0xC216C0 VA: 0x180C222C0
	private static extern void SetBaseConstants_Native(int shoreMapSize, ref Vector3 shoreMap, int waterHeightMapSize, ref short waterHeightMap, Vector4 packedParams) { }

	// RVA: 0xC22DB0 Offset: 0xC221B0 VA: 0x180C22DB0
	private static extern void SetTerrainConstants_Native(int terrainHeightMapSize, ref short terrainHeightMap, Vector3 terrainPosition, Vector3 terrainSize) { }

	// RVA: 0xC22380 Offset: 0xC21780 VA: 0x180C22380
	private static extern void SetGerstnerConstants_Native(Vector4 globalParams0, Vector4 globalParams1, ref Vector4 openWaves, ref Vector4 shoreWaves) { }

	// RVA: 0xC24F30 Offset: 0xC24330 VA: 0x180C24F30
	private static extern void UpdateOceanLevel_Native(float oceanWaterLevel) { }

	// RVA: 0xC20BD0 Offset: 0xC1FFD0 VA: 0x180C20BD0
	private static extern float GetHeightArray_Native(int sampleCount, ref Vector2 pos, ref Vector2 posUV, ref Vector3 shore, ref float terrainHeight, ref float waterHeight) { }

	// RVA: 0xC214C0 Offset: 0xC208C0 VA: 0x180C214C0
	private static extern float GetHeight_Native(Vector3 pos) { }

	// RVA: 0xC1F3B0 Offset: 0xC1E7B0 VA: 0x180C1F3B0
	private static extern bool CPU_SupportsSSE41() { }

	// RVA: 0xC22440 Offset: 0xC21840 VA: 0x180C22440
	private static void SetNativeConstants(TerrainTexturing terrainTexturing, TerrainWaterMap terrainWaterMap, TerrainHeightMap terrainHeightMap, Vector4 globalParams0, Vector4 globalParams1, Vector4[] openWaves, Vector4[] shoreWaves) { }

	// RVA: -1 Offset: -1
	private static void PinObject<T>(T value, ref T currentValue, ref GCHandle currentValueHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3D40 Offset: 0x5F3140 VA: 0x1805F3D40
	|-WaterSystem.PinObject<short[]>
	|-WaterSystem.PinObject<object>
	|-WaterSystem.PinObject<Vector3[]>
	|-WaterSystem.PinObject<Vector4[]>
	*/

	// RVA: 0xC20F30 Offset: 0xC20330 VA: 0x180C20F30
	private static float GetHeight_Managed(Vector3 pos) { }

	// RVA: 0xC20520 Offset: 0xC1F920 VA: 0x180C20520
	public static void GetHeightArray_Managed(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC21550 Offset: 0xC20950 VA: 0x180C21550
	public static float GetHeight(Vector3 pos) { }

	// RVA: 0xC20C90 Offset: 0xC20090 VA: 0x180C20C90
	public static void GetHeightArray(Vector2[] pos, Vector2[] posUV, Vector3[] shore, float[] terrainHeight, float[] waterHeight) { }

	// RVA: 0xC21740 Offset: 0xC20B40 VA: 0x180C21740
	public static Vector3 GetNormal(Vector3 pos) { }

	// RVA: 0xC21C70 Offset: 0xC21070 VA: 0x180C21C70
	public static void RegisterBody(WaterBody body) { }

	// RVA: 0xC23600 Offset: 0xC22A00 VA: 0x180C23600
	public static void UnregisterBody(WaterBody body) { }

	// RVA: 0xC262F0 Offset: 0xC256F0 VA: 0x180C262F0
	private void UpdateWaves() { }

	// RVA: 0xC24FB0 Offset: 0xC243B0 VA: 0x180C24FB0
	private static void UpdateOceanLevel() { }

	// RVA: 0xC25BF0 Offset: 0xC24FF0 VA: 0x180C25BF0
	public void UpdateWaveData() { }

	// RVA: 0xC265B0 Offset: 0xC259B0 VA: 0x180C265B0
	private void Update() { }

	// RVA: 0xC23040 Offset: 0xC22440 VA: 0x180C23040
	private static void ShutdownRuntimes() { }

	// RVA: 0xC1FE30 Offset: 0xC1F230 VA: 0x180C1FE30
	public static void Clear() { }

	// RVA: 0xC21F90 Offset: 0xC21390 VA: 0x180C21F90
	public static void RegisterCamera(WaterCamera camera) { }

	// RVA: 0xC236C0 Offset: 0xC22AC0 VA: 0x180C236C0
	public static void UnregisterCamera(WaterCamera camera) { }

	// RVA: 0xC221A0 Offset: 0xC215A0 VA: 0x180C221A0
	public static void RegisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC23780 Offset: 0xC22B80 VA: 0x180C23780
	public static void UnregisterDepthMask(WaterDepthMask mask) { }

	// RVA: 0xC20110 Offset: 0xC1F510 VA: 0x180C20110
	private void CreateReflectionProbe() { }

	// RVA: 0xC20420 Offset: 0xC1F820 VA: 0x180C20420
	private void DestroyReflectionProbe() { }

	// RVA: 0xC1F810 Offset: 0xC1EC10 VA: 0x180C1F810
	private void CheckReflectionProbe() { }

	// RVA: 0xC1FFA0 Offset: 0xC1F3A0 VA: 0x180C1FFA0
	private void CreateDefaultHeightSlopeMap() { }

	// RVA: 0xC20360 Offset: 0xC1F760 VA: 0x180C20360
	private void DestroyDefaultHeightSlopeMap() { }

	// RVA: 0xC21A30 Offset: 0xC20E30 VA: 0x180C21A30
	private void OnEnable() { }

	// RVA: 0xC218B0 Offset: 0xC20CB0 VA: 0x180C218B0
	private void OnDisable() { }

	// RVA: 0xC23840 Offset: 0xC22C40 VA: 0x180C23840
	public void UpdateClient() { }

	// RVA: 0xC20320 Offset: 0xC1F720 VA: 0x180C20320
	private void DestroyComputeBuffer(ref ComputeBuffer buffer) { }

	// RVA: 0xC26190 Offset: 0xC25590 VA: 0x180C26190
	private void UpdateWavesClient() { }

	// RVA: 0xC25830 Offset: 0xC24C30 VA: 0x180C25830
	private void UpdateRuntimes() { }

	// RVA: 0xC24C30 Offset: 0xC24030 VA: 0x180C24C30
	public void UpdateMaterial(Material material) { }

	// RVA: 0xC1FC80 Offset: 0xC1F080 VA: 0x180C1FC80
	public void ClearUnderwaterScatterCoefficientOverride() { }

	// RVA: 0xC22E80 Offset: 0xC22280 VA: 0x180C22E80
	public void SetUnderwaterScatterCoefficientOverride(float scatterCoefficient) { }

	// RVA: 0xC25780 Offset: 0xC24B80 VA: 0x180C25780
	private void UpdateReflectionProbe() { }

	// RVA: 0xC22260 Offset: 0xC21660 VA: 0x180C22260
	public void ResetVisibility() { }

	// RVA: 0xC231E0 Offset: 0xC225E0 VA: 0x180C231E0
	public void ToggleVisibility(int mask) { }

	// RVA: 0xC23D40 Offset: 0xC23140 VA: 0x180C23D40
	private void UpdateGlobalShaderProperties() { }

	// RVA: 0xC25490 Offset: 0xC24890 VA: 0x180C25490
	private bool UpdateQuality() { }

	// RVA: 0xC204F0 Offset: 0xC1F8F0 VA: 0x180C204F0
	private void DisableFallbackPlane() { }

	// RVA: 0xC24B90 Offset: 0xC23F90 VA: 0x180C24B90
	private void UpdateKeywords() { }

	// RVA: 0xC26A40 Offset: 0xC25E40 VA: 0x180C26A40
	public void .ctor() { }

	// RVA: 0xC267E0 Offset: 0xC25BE0 VA: 0x180C267E0
	private static void .cctor() { }

}

public class WaterSystem.SimulationSettings // TypeDefIndex: 10627
{	// Fields
	public Vector3 Wind; // 0x10
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

	// Methods

	// RVA: 0x892E30 Offset: 0x892230 VA: 0x180892E30
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings // TypeDefIndex: 10628
{	// Fields
	public float MaxDisplacementDistance; // 0x10
	public WaterSystem.RenderingSettings.SkyProbe SkyReflections; // 0x18
	public WaterSystem.RenderingSettings.SSR ScreenSpaceReflections; // 0x20
	public WaterSystem.RenderingSettings.Caustics CausticsAnimation; // 0x28

	// Methods

	// RVA: 0xC0B610 Offset: 0xC0AA10 VA: 0x180C0B610
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SkyProbe // TypeDefIndex: 10629
{	// Fields
	public float ProbeUpdateInterval; // 0x10
	public bool TimeSlicing; // 0x14

	// Methods

	// RVA: 0xC0B6F0 Offset: 0xC0AAF0 VA: 0x180C0B6F0
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.SSR // TypeDefIndex: 10630
{	// Fields
	public float FresnelCutoff; // 0x10
	public float ThicknessMin; // 0x14
	public float ThicknessMax; // 0x18
	public float ThicknessStartDist; // 0x1C
	public float ThicknessEndDist; // 0x20

	// Methods

	// RVA: 0xC0B620 Offset: 0xC0AA20 VA: 0x180C0B620
	public void .ctor() { }

}

public class WaterSystem.RenderingSettings.Caustics // TypeDefIndex: 10631
{	// Fields
	public float FrameRate; // 0x10
	public Texture2D[] FramesShallow; // 0x18
	public Texture2D[] FramesDeep; // 0x20

	// Methods

	// RVA: 0xC0B100 Offset: 0xC0A500 VA: 0x180C0B100
	public void .ctor() { }

}

private enum WaterSystem.NativePathState // TypeDefIndex: 10632
{	// Fields
	public int value__; // 0x0
	public const WaterSystem.NativePathState Initializing = 0;
	public const WaterSystem.NativePathState Failed = 1;
	public const WaterSystem.NativePathState Ready = 2;

}

