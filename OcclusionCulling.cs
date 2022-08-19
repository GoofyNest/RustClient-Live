public class OcclusionCulling : MonoBehaviour // TypeDefIndex: 11509
{	// Fields
	public OcclusionCulling.DebugSettings debugSettings; // 0x18
	private Material debugMipMat; // 0x20
	private const float debugDrawDuration = 0,0334;
	private Material downscaleMat; // 0x28
	private Material blitCopyMat; // 0x30
	private int hiZLevelCount; // 0x38
	private int hiZWidth; // 0x3C
	private int hiZHeight; // 0x40
	private RenderTexture depthTexture; // 0x48
	private RenderTexture hiZTexture; // 0x50
	private RenderTexture[] hiZLevels; // 0x58
	private const int GridCellsPerAxis = 2097152;
	private const int GridHalfCellsPerAxis = 1048576;
	private const int GridMinHalfCellsPerAxis = -1048575;
	private const int GridMaxHalfCellsPerAxis = 1048575;
	private const float GridCellSize = 100;
	private const float GridHalfCellSize = 50;
	private const float GridRcpCellSize = 0,01;
	private const int GridPoolCapacity = 16384;
	private const int GridPoolGranularity = 4096;
	private static OcclusionCulling.HashedPool<OcclusionCulling.Cell> grid; // 0x0
	private static Queue<OcclusionCulling.Cell> gridChanged; // 0x8
	public ComputeShader computeShader; // 0x60
	public bool usePixelShaderFallback; // 0x68
	public bool useAsyncReadAPI; // 0x69
	private Camera camera; // 0x70
	private const int ComputeThreadsPerGroup = 64;
	private const int InputBufferStride = 16;
	private const int ResultBufferStride = 4;
	private const int OccludeeMaxSlotsPerPool = 1048576;
	private const int OccludeePoolGranularity = 2048;
	private const int StateBufferGranularity = 2048;
	private const int GridBufferGranularity = 256;
	private static Queue<OccludeeState> statePool; // 0x10
	private static OcclusionCulling.SimpleList<OccludeeState> staticOccludees; // 0x18
	private static OcclusionCulling.SimpleList<OccludeeState.State> staticStates; // 0x20
	private static OcclusionCulling.SimpleList<int> staticVisibilityChanged; // 0x28
	private static OcclusionCulling.SimpleList<OccludeeState> dynamicOccludees; // 0x30
	private static OcclusionCulling.SimpleList<OccludeeState.State> dynamicStates; // 0x38
	private static OcclusionCulling.SimpleList<int> dynamicVisibilityChanged; // 0x40
	private static List<int> staticChanged; // 0x48
	private static Queue<int> staticRecycled; // 0x50
	private static List<int> dynamicChanged; // 0x58
	private static Queue<int> dynamicRecycled; // 0x60
	private static OcclusionCulling.BufferSet staticSet; // 0x68
	private static OcclusionCulling.BufferSet dynamicSet; // 0x70
	private static OcclusionCulling.BufferSet gridSet; // 0x78
	private Vector4[] frustumPlanes; // 0x78
	private string[] frustumPropNames; // 0x80
	private float[] matrixToFloatTemp; // 0x88
	private Material fallbackMat; // 0x90
	private Material depthCopyMat; // 0x98
	private Matrix4x4 viewMatrix; // 0xA0
	private Matrix4x4 projMatrix; // 0xE0
	private Matrix4x4 viewProjMatrix; // 0x120
	private Matrix4x4 prevViewProjMatrix; // 0x160
	private Matrix4x4 invViewProjMatrix; // 0x1A0
	private bool useNativePath; // 0x1E0
	private static OcclusionCulling instance; // 0x80
	private static GraphicsDeviceType[] supportedDeviceTypes; // 0x88
	private static bool _enabled; // 0x90
	private static bool _safeMode; // 0x91
	private static OcclusionCulling.DebugFilter _debugShow; // 0x94

	// Properties
	public bool HiZReady { get; }
	public static OcclusionCulling Instance { get; }
	public static bool Supported { get; }
	public static bool Enabled { get; set; }
	public static bool SafeMode { get; set; }
	public static OcclusionCulling.DebugFilter DebugShow { get; set; }

	// Methods

	// RVA: 0x4B9B40 Offset: 0x4B8F40 VA: 0x1804B9B40
	public static bool DebugFilterIsDynamic(int filter) { }

	// RVA: 0xA3FFD0 Offset: 0xA3F3D0 VA: 0x180A3FFD0
	public static bool DebugFilterIsStatic(int filter) { }

	// RVA: 0xA3FFC0 Offset: 0xA3F3C0 VA: 0x180A3FFC0
	public static bool DebugFilterIsGrid(int filter) { }

	// RVA: 0xA3FFE0 Offset: 0xA3F3E0 VA: 0x180A3FFE0
	private void DebugInitialize() { }

	// RVA: 0xA40080 Offset: 0xA3F480 VA: 0x180A40080
	private void DebugShutdown() { }

	// RVA: 0xA40130 Offset: 0xA3F530 VA: 0x180A40130
	private void DebugUpdate() { }

	// RVA: 0xA3F070 Offset: 0xA3E470 VA: 0x180A3F070
	private void DebugDraw() { }

	// RVA: 0xA41EE0 Offset: 0xA412E0 VA: 0x180A41EE0
	public static void NormalizePlane(ref Vector4 plane) { }

	// RVA: 0xA40390 Offset: 0xA3F790 VA: 0x180A40390
	public static void ExtractFrustum(Matrix4x4 viewProjMatrix, ref Vector4[] planes) { }

	// RVA: 0xA47600 Offset: 0xA46A00 VA: 0x180A47600
	public bool get_HiZReady() { }

	// RVA: 0xA3E670 Offset: 0xA3DA70 VA: 0x180A3E670
	public void CheckResizeHiZMap() { }

	// RVA: 0xA41940 Offset: 0xA40D40 VA: 0x180A41940
	private void InitializeHiZMap() { }

	// RVA: 0xA40C50 Offset: 0xA40050 VA: 0x180A40C50
	private void FinalizeHiZMap() { }

	// RVA: 0xA41680 Offset: 0xA40A80 VA: 0x180A41680
	private void InitializeHiZMap(int width, int height) { }

	// RVA: 0xA401D0 Offset: 0xA3F5D0 VA: 0x180A401D0
	private void DestroyHiZMap() { }

	// RVA: 0xA3EA30 Offset: 0xA3DE30 VA: 0x180A3EA30
	private RenderTexture CreateDepthTexture(string name, int width, int height, bool mips = False) { }

	// RVA: 0xA3E950 Offset: 0xA3DD50 VA: 0x180A3E950
	private RenderTexture CreateDepthTextureMip(string name, int width, int height, int mip) { }

	// RVA: 0xA41510 Offset: 0xA40910 VA: 0x180A41510
	public void GrabDepthTexture() { }

	// RVA: 0xA40FA0 Offset: 0xA403A0 VA: 0x180A40FA0
	public void GenerateHiZMipChain() { }

	// RVA: 0xA3EB20 Offset: 0xA3DF20 VA: 0x180A3EB20
	private void DebugDrawGizmos() { }

	// RVA: 0xA47520 Offset: 0xA46920 VA: 0x180A47520
	private static int floor(float x) { }

	// RVA: 0xA44C60 Offset: 0xA44060 VA: 0x180A44C60
	public static OcclusionCulling.Cell RegisterToGrid(OccludeeState occludee) { }

	// RVA: 0xA46C70 Offset: 0xA46070 VA: 0x180A46C70
	public static void UpdateInGrid(OccludeeState occludee) { }

	// RVA: 0xA45BB0 Offset: 0xA44FB0 VA: 0x180A45BB0
	public static void UnregisterFromGrid(OccludeeState occludee) { }

	// RVA: 0xA46870 Offset: 0xA45C70 VA: 0x180A46870
	public void UpdateGridBuffers() { }

	// RVA: 0xA47680 Offset: 0xA46A80 VA: 0x180A47680
	public static OcclusionCulling get_Instance() { }

	// RVA: 0xA47740 Offset: 0xA46B40 VA: 0x180A47740
	public static bool get_Supported() { }

	// RVA: 0xA475A0 Offset: 0xA469A0 VA: 0x180A475A0
	public static bool get_Enabled() { }

	// RVA: 0xA47820 Offset: 0xA46C20 VA: 0x180A47820
	public static void set_Enabled(bool value) { }

	// RVA: 0xA476E0 Offset: 0xA46AE0 VA: 0x180A476E0
	public static bool get_SafeMode() { }

	// RVA: 0xA47920 Offset: 0xA46D20 VA: 0x180A47920
	public static void set_SafeMode(bool value) { }

	// RVA: 0xA47540 Offset: 0xA46940 VA: 0x180A47540
	public static OcclusionCulling.DebugFilter get_DebugShow() { }

	// RVA: 0xA477C0 Offset: 0xA46BC0 VA: 0x180A477C0
	public static void set_DebugShow(OcclusionCulling.DebugFilter value) { }

	// RVA: 0xA415C0 Offset: 0xA409C0 VA: 0x180A415C0
	private static void GrowStatePool() { }

	// RVA: 0xA3D240 Offset: 0xA3C640 VA: 0x180A3D240
	private static OccludeeState Allocate() { }

	// RVA: 0xA45290 Offset: 0xA44690 VA: 0x180A45290
	private static void Release(OccludeeState state) { }

	// RVA: 0xA3E530 Offset: 0xA3D930 VA: 0x180A3E530
	private void Awake() { }

	// RVA: 0xA42290 Offset: 0xA41690 VA: 0x180A42290
	private void OnEnable() { }

	// RVA: 0xA459F0 Offset: 0xA44DF0 VA: 0x180A459F0
	private bool SupportsNativePath() { }

	// RVA: 0xA41FC0 Offset: 0xA413C0 VA: 0x180A41FC0
	private void OnDisable() { }

	// RVA: 0xA41C00 Offset: 0xA41000 VA: 0x180A41C00
	public static void MakeAllVisible() { }

	// RVA: 0xA46E20 Offset: 0xA46220 VA: 0x180A46E20
	private void Update() { }

	// RVA: -1 Offset: -1
	public static void RecursiveAddOccludees<T>(Transform transform, float minTimeVisible = 0,1, bool isStatic = True, bool stickyGizmos = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9530 Offset: 0xCF8930 VA: 0x180CF9530
	|-OcclusionCulling.RecursiveAddOccludees<object>
	*/

	// RVA: 0xA40D80 Offset: 0xA40180 VA: 0x180A40D80
	private static int FindFreeSlot(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled) { }

	// RVA: 0xA41440 Offset: 0xA40840 VA: 0x180A41440
	public static OccludeeState GetStateById(int id) { }

	// RVA: 0xA444F0 Offset: 0xA438F0 VA: 0x180A444F0
	public static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0xA446C0 Offset: 0xA43AC0 VA: 0x180A446C0
	private static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged, OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled, List<int> changed, OcclusionCulling.BufferSet set, OcclusionCulling.SimpleList<int> visibilityChanged) { }

	// RVA: 0xA45EA0 Offset: 0xA452A0 VA: 0x180A45EA0
	public static void UnregisterOccludee(int id) { }

	// RVA: 0xA45F80 Offset: 0xA45380 VA: 0x180A45F80
	private static void UnregisterOccludee(int slot, OcclusionCulling.SimpleList<OccludeeState> occludees, Queue<int> recycled, List<int> changed) { }

	// RVA: 0xA46720 Offset: 0xA45B20 VA: 0x180A46720
	public static void UpdateDynamicOccludee(int id, Vector3 center, float radius) { }

	// RVA: 0xA46180 Offset: 0xA45580 VA: 0x180A46180
	private void UpdateBuffers(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, List<int> changed, bool isStatic) { }

	// RVA: 0xA463D0 Offset: 0xA457D0 VA: 0x180A463D0
	private void UpdateCameraMatrices(bool starting = False) { }

	// RVA: 0xA42A90 Offset: 0xA41E90 VA: 0x180A42A90
	private void OnPreCull() { }

	// RVA: 0xA42930 Offset: 0xA41D30 VA: 0x180A42930
	private void OnPostRender() { }

	// RVA: 0xA41E20 Offset: 0xA41220 VA: 0x180A41E20
	private float[] MatrixToFloatArray(Matrix4x4 m) { }

	// RVA: 0xA42DF0 Offset: 0xA421F0 VA: 0x180A42DF0
	private void PrepareAndDispatch() { }

	// RVA: 0xA41A40 Offset: 0xA40E40 VA: 0x180A41A40
	private void IssueRead() { }

	// RVA: 0xA45310 Offset: 0xA44710 VA: 0x180A45310
	public void ResetTiming(OcclusionCulling.SmartList bucket) { }

	// RVA: 0xA453A0 Offset: 0xA447A0 VA: 0x180A453A0
	public void ResetTiming() { }

	// RVA: 0xA40F00 Offset: 0xA40300 VA: 0x180A40F00
	private static bool FrustumCull(Vector4[] planes, Vector4 testSphere) { }

	// RVA: 0xA441B0 Offset: 0xA435B0 VA: 0x180A441B0
	private static int ProcessOccludees_Safe(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SmartList bucket, Color32[] results, OcclusionCulling.SimpleList<int> changed, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0xA43D30 Offset: 0xA43130 VA: 0x180A43D30
	private static int ProcessOccludees_Fast(OccludeeState.State[] states, int[] bucket, int bucketCount, Color32[] results, int resultCount, int[] changed, ref int changedCount, Vector4[] frustumPlanes, float time, uint frame) { }

	// RVA: 0xA440B0 Offset: 0xA434B0 VA: 0x180A440B0
	private static extern int ProcessOccludees_Native(ref OccludeeState.State states, ref int bucket, int bucketCount, ref Color32 results, int resultCount, ref int changed, ref int changedCount, ref Vector4 frustumPlanes, float time, uint frame) { }

	// RVA: 0xA3E060 Offset: 0xA3D460 VA: 0x180A3E060
	private void ApplyVisibility_Safe(float time, uint frame) { }

	// RVA: 0xA3D3D0 Offset: 0xA3C7D0 VA: 0x180A3D3D0
	private void ApplyVisibility_Fast(float time, uint frame) { }

	// RVA: 0xA3D960 Offset: 0xA3CD60 VA: 0x180A3D960
	private void ApplyVisibility_Native(float time, uint frame) { }

	// RVA: 0xA43B30 Offset: 0xA42F30 VA: 0x180A43B30
	private void ProcessCallbacks(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SimpleList<int> changed) { }

	// RVA: 0xA454B0 Offset: 0xA448B0 VA: 0x180A454B0
	public void RetrieveAndApplyVisibility() { }

	// RVA: 0xA47430 Offset: 0xA46830 VA: 0x180A47430
	public void .ctor() { }

	// RVA: 0xA46F90 Offset: 0xA46390 VA: 0x180A46F90
	private static void .cctor() { }

}

public class OcclusionCulling.BufferSet // TypeDefIndex: 11510
{	// Fields
	public ComputeBuffer inputBuffer; // 0x10
	public ComputeBuffer resultBuffer; // 0x18
	public int width; // 0x20
	public int height; // 0x24
	public int capacity; // 0x28
	public int count; // 0x2C
	public Texture2D inputTexture; // 0x30
	public RenderTexture resultTexture; // 0x38
	public Texture2D resultReadTexture; // 0x40
	public Color[] inputData; // 0x48
	public Color32[] resultData; // 0x50
	private OcclusionCulling culling; // 0x58
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests; // 0x60
	public IntPtr readbackInst; // 0x68

	// Properties
	public bool Ready { get; }

	// Methods

	// RVA: 0xA34260 Offset: 0xA33660 VA: 0x180A34260
	public bool get_Ready() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	public void Attach(OcclusionCulling culling) { }

	// RVA: 0xA33A90 Offset: 0xA32E90 VA: 0x180A33A90
	public void Dispose(bool data = True) { }

	// RVA: 0xA333C0 Offset: 0xA327C0 VA: 0x180A333C0
	public bool CheckResize(int count, int granularity) { }

	// RVA: 0xA34140 Offset: 0xA33540 VA: 0x180A34140
	public void UploadData() { }

	// RVA: 0xA333B0 Offset: 0xA327B0 VA: 0x180A333B0
	private int AlignDispatchSize(int dispatchSize) { }

	// RVA: 0xA338C0 Offset: 0xA32CC0 VA: 0x180A338C0
	public void Dispatch(int count) { }

	// RVA: 0xA33FF0 Offset: 0xA333F0 VA: 0x180A33FF0
	public void IssueRead() { }

	// RVA: 0xA33D00 Offset: 0xA33100 VA: 0x180A33D00
	public void GetResults() { }

	// RVA: 0xA341B0 Offset: 0xA335B0 VA: 0x180A341B0
	public void .ctor() { }

}

public enum OcclusionCulling.DebugFilter // TypeDefIndex: 11511
{	// Fields
	public int value__; // 0x0
	public const OcclusionCulling.DebugFilter Off = 0;
	public const OcclusionCulling.DebugFilter Dynamic = 1;
	public const OcclusionCulling.DebugFilter Static = 2;
	public const OcclusionCulling.DebugFilter Grid = 3;
	public const OcclusionCulling.DebugFilter All = 4;

}

public enum OcclusionCulling.DebugMask // TypeDefIndex: 11512
{	// Fields
	public int value__; // 0x0
	public const OcclusionCulling.DebugMask Off = 0;
	public const OcclusionCulling.DebugMask Dynamic = 1;
	public const OcclusionCulling.DebugMask Static = 2;
	public const OcclusionCulling.DebugMask Grid = 4;
	public const OcclusionCulling.DebugMask All = 7;

}

public class OcclusionCulling.DebugSettings // TypeDefIndex: 11513
{	// Fields
	public bool log; // 0x10
	public bool showAllVisible; // 0x11
	public bool showMipChain; // 0x12
	public bool showMain; // 0x13
	public int showMainLod; // 0x14
	public bool showFallback; // 0x18
	public bool showStats; // 0x19
	public bool showScreenBounds; // 0x1A
	public OcclusionCulling.DebugMask showMask; // 0x1C
	public LayerMask layerFilter; // 0x20

	// Methods

	// RVA: 0xA344E0 Offset: 0xA338E0 VA: 0x180A344E0
	public void .ctor() { }

}

public class OcclusionCulling.HashedPoolValue // TypeDefIndex: 11514
{	// Fields
	public ulong hashedPoolKey; // 0x10
	public int hashedPoolIndex; // 0x18

	// Methods

	// RVA: 0xA344C0 Offset: 0xA338C0 VA: 0x180A344C0
	public void .ctor() { }

}

public class OcclusionCulling.HashedPool<ValueType> // TypeDefIndex: 11515
{	// Fields
	private int granularity; // 0x0
	private Dictionary<ulong, ValueType> dict; // 0x0
	private List<ValueType> pool; // 0x0
	private List<ValueType> list; // 0x0
	private Queue<ValueType> recycled; // 0x0

	// Properties
	public int Size { get; }
	public int Count { get; }
	public ValueType Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50F60 Offset: 0xD50360 VA: 0x180D50F60
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Size
	|-OcclusionCulling.HashedPool<object>.get_Size
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50F00 Offset: 0xD50300 VA: 0x180D50F00
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Count
	|-OcclusionCulling.HashedPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ValueType get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50F30 Offset: 0xD50330 VA: 0x180D50F30
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Item
	|-OcclusionCulling.HashedPool<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int i, ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50F90 Offset: 0xD50390 VA: 0x180D50F90
	|-OcclusionCulling.HashedPool<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int granularity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50D60 Offset: 0xD50160 VA: 0x180D50D60
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>..ctor
	|-OcclusionCulling.HashedPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50BB0 Offset: 0xD4FFB0 VA: 0x180D50BB0
	|-OcclusionCulling.HashedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public ValueType Add(ulong key, int capacityGranularity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD509C0 Offset: 0xD4FDC0 VA: 0x180D509C0
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Add
	|-OcclusionCulling.HashedPool<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50C80 Offset: 0xD50080 VA: 0x180D50C80
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Remove
	|-OcclusionCulling.HashedPool<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(ulong key, out ValueType value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50D30 Offset: 0xD50130 VA: 0x180D50D30
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.TryGetValue
	|-OcclusionCulling.HashedPool<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(ulong key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD50C50 Offset: 0xD50050 VA: 0x180D50C50
	|-OcclusionCulling.HashedPool<object>.ContainsKey
	*/

}

public class OcclusionCulling.SimpleList<T> // TypeDefIndex: 11516
{	// Fields
	private const int defaultCapacity = 16;
	private static readonly T[] emptyArray; // 0x0
	public T[] array; // 0x0
	public int count; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; set; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Count
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Count
	|-OcclusionCulling.SimpleList<int>.get_Count
	|-OcclusionCulling.SimpleList<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Capacity
	|-OcclusionCulling.SimpleList<int>.get_Capacity
	|-OcclusionCulling.SimpleList<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D560 Offset: 0xD5C960 VA: 0x180D5D560
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Capacity
	|-OcclusionCulling.SimpleList<int>.set_Capacity
	|-OcclusionCulling.SimpleList<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D430 Offset: 0xD5C830 VA: 0x180D5D430
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Item
	|
	|-RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Item
	|-OcclusionCulling.SimpleList<object>.get_Item
	|
	|-RVA: 0xD5D520 Offset: 0xD5C920 VA: 0x180D5D520
	|-OcclusionCulling.SimpleList<int>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D760 Offset: 0xD5CB60 VA: 0x180D5D760
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Item
	|
	|-RVA: 0xD5D6D0 Offset: 0xD5CAD0 VA: 0x180D5D6D0
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Item
	|-OcclusionCulling.SimpleList<object>.set_Item
	|
	|-RVA: 0xD5D720 Offset: 0xD5CB20 VA: 0x180D5D720
	|-OcclusionCulling.SimpleList<int>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D210 Offset: 0xD5C610 VA: 0x180D5D210
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D300 Offset: 0xD5C700 VA: 0x180D5D300
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<OccludeeState>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5CB70 Offset: 0xD5BF70 VA: 0x180D5CB70
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Add
	|
	|-RVA: 0xD5C920 Offset: 0xD5BD20 VA: 0x180D5C920
	|-OcclusionCulling.SimpleList<OccludeeState>.Add
	|-OcclusionCulling.SimpleList<object>.Add
	|
	|-RVA: 0xD5C9B0 Offset: 0xD5BDB0 VA: 0x180D5C9B0
	|-OcclusionCulling.SimpleList<int>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5CC10 Offset: 0xD5C010 VA: 0x180D5CC10
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Clear
	|-OcclusionCulling.SimpleList<int>.Clear
	|-OcclusionCulling.SimpleList<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5CDA0 Offset: 0xD5C1A0 VA: 0x180D5CDA0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Contains
	|
	|-RVA: 0xD5D000 Offset: 0xD5C400 VA: 0x180D5D000
	|-OcclusionCulling.SimpleList<int>.Contains
	|
	|-RVA: 0xD5CC40 Offset: 0xD5C040 VA: 0x180D5CC40
	|-OcclusionCulling.SimpleList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D0D0 Offset: 0xD5C4D0 VA: 0x180D5D0D0
	|-OcclusionCulling.SimpleList<OccludeeState.State>.CopyTo
	|-OcclusionCulling.SimpleList<int>.CopyTo
	|-OcclusionCulling.SimpleList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D100 Offset: 0xD5C500 VA: 0x180D5D100
	|-OcclusionCulling.SimpleList<OccludeeState.State>.EnsureCapacity
	|-OcclusionCulling.SimpleList<int>.EnsureCapacity
	|-OcclusionCulling.SimpleList<object>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5D160 Offset: 0xD5C560 VA: 0x180D5D160
	|-OcclusionCulling.SimpleList<OccludeeState.State>..cctor
	|-OcclusionCulling.SimpleList<int>..cctor
	|-OcclusionCulling.SimpleList<object>..cctor
	*/

}

public class OcclusionCulling.SmartListValue // TypeDefIndex: 11517
{	// Fields
	public int hashedListIndex; // 0x10

	// Methods

	// RVA: 0xA3B1C0 Offset: 0xA3A5C0 VA: 0x180A3B1C0
	public void .ctor() { }

}

public class OcclusionCulling.SmartList // TypeDefIndex: 11518
{	// Fields
	private const int defaultCapacity = 16;
	private static readonly OccludeeState[] emptyList; // 0x0
	private static readonly int[] emptySlots; // 0x8
	private OccludeeState[] list; // 0x10
	private int[] slots; // 0x18
	private Queue<int> recycled; // 0x20
	private int count; // 0x28

	// Properties
	public OccludeeState[] List { get; }
	public int[] Slots { get; }
	public int Size { get; }
	public int Count { get; }
	public OccludeeState Item { get; set; }
	public int Capacity { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public OccludeeState[] get_List() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public int[] get_Slots() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_Size() { }

	// RVA: 0xA4F9B0 Offset: 0xA4EDB0 VA: 0x180A4F9B0
	public int get_Count() { }

	// RVA: 0xA4F9F0 Offset: 0xA4EDF0 VA: 0x180A4F9F0
	public OccludeeState get_Item(int i) { }

	// RVA: 0xA4FB70 Offset: 0xA4EF70 VA: 0x180A4FB70
	public void set_Item(int i, OccludeeState value) { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990
	public int get_Capacity() { }

	// RVA: 0xA4FA30 Offset: 0xA4EE30 VA: 0x180A4FA30
	public void set_Capacity(int value) { }

	// RVA: 0xA4F8E0 Offset: 0xA4ECE0 VA: 0x180A4F8E0
	public void .ctor(int capacity) { }

	// RVA: 0xA4F2C0 Offset: 0xA4E6C0 VA: 0x180A4F2C0
	public void Add(OccludeeState value, int capacityGranularity = 16) { }

	// RVA: 0xA4F780 Offset: 0xA4EB80 VA: 0x180A4F780
	public void Remove(OccludeeState value) { }

	// RVA: 0xA4F5C0 Offset: 0xA4E9C0 VA: 0x180A4F5C0
	public bool Contains(OccludeeState value) { }

	// RVA: 0xA4F610 Offset: 0xA4EA10 VA: 0x180A4F610
	public void EnsureCapacity(int min) { }

	// RVA: 0xA4F860 Offset: 0xA4EC60 VA: 0x180A4F860
	private static void .cctor() { }

}

public class OcclusionCulling.Cell : OcclusionCulling.HashedPoolValue // TypeDefIndex: 11519
{	// Fields
	public int x; // 0x20
	public int y; // 0x24
	public int z; // 0x28
	public Bounds bounds; // 0x2C
	public Vector4 sphereBounds; // 0x44
	public bool isVisible; // 0x54
	public OcclusionCulling.SmartList staticBucket; // 0x58
	public OcclusionCulling.SmartList dynamicBucket; // 0x60

	// Methods

	// RVA: 0xA34420 Offset: 0xA33820 VA: 0x180A34420
	public void Reset() { }

	// RVA: 0xA34280 Offset: 0xA33680 VA: 0x180A34280
	public OcclusionCulling.Cell Initialize(int x, int y, int z, Bounds bounds) { }

	// RVA: 0xA344C0 Offset: 0xA338C0 VA: 0x180A344C0
	public void .ctor() { }

}

public struct OcclusionCulling.Sphere // TypeDefIndex: 11520
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC

	// Methods

	// RVA: 0xFBB80 Offset: 0xFAF80 VA: 0x1800FBB80
	public bool IsValid() { }

	// RVA: 0xFBB90 Offset: 0xFAF90 VA: 0x1800FBB90
	public void .ctor(Vector3 position, float radius) { }

}

public sealed class OcclusionCulling.OnVisibilityChanged : MulticastDelegate // TypeDefIndex: 11521
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA496F0 Offset: 0xA48AF0 VA: 0x180A496F0 Slot: 12
	public virtual void Invoke(bool visible) { }

	// RVA: 0xA49670 Offset: 0xA48A70 VA: 0x180A49670 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

