public class OcclusionCulling : MonoBehaviour // TypeDefIndex: 11509
{	public OcclusionCulling.DebugSettings debugSettings; // 0x18
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

	public bool HiZReady { get; }
	public static OcclusionCulling Instance { get; }
	public static bool Supported { get; }
	public static bool Enabled { get; set; }
	public static bool SafeMode { get; set; }
	public static OcclusionCulling.DebugFilter DebugShow { get; set; }


	public static bool DebugFilterIsDynamic(int filter) { }

	public static bool DebugFilterIsStatic(int filter) { }

	public static bool DebugFilterIsGrid(int filter) { }

	private void DebugInitialize() { }

	private void DebugShutdown() { }

	private void DebugUpdate() { }

	private void DebugDraw() { }

	public static void NormalizePlane(ref Vector4 plane) { }

	public static void ExtractFrustum(Matrix4x4 viewProjMatrix, ref Vector4[] planes) { }

	public bool get_HiZReady() { }

	public void CheckResizeHiZMap() { }

	private void InitializeHiZMap() { }

	private void FinalizeHiZMap() { }

	private void InitializeHiZMap(int width, int height) { }

	private void DestroyHiZMap() { }

	private RenderTexture CreateDepthTexture(string name, int width, int height, bool mips = False) { }

	private RenderTexture CreateDepthTextureMip(string name, int width, int height, int mip) { }

	public void GrabDepthTexture() { }

	public void GenerateHiZMipChain() { }

	private void DebugDrawGizmos() { }

	private static int floor(float x) { }

	public static OcclusionCulling.Cell RegisterToGrid(OccludeeState occludee) { }

	public static void UpdateInGrid(OccludeeState occludee) { }

	public static void UnregisterFromGrid(OccludeeState occludee) { }

	public void UpdateGridBuffers() { }

	public static OcclusionCulling get_Instance() { }

	public static bool get_Supported() { }

	public static bool get_Enabled() { }

	public static void set_Enabled(bool value) { }

	public static bool get_SafeMode() { }

	public static void set_SafeMode(bool value) { }

	public static OcclusionCulling.DebugFilter get_DebugShow() { }

	public static void set_DebugShow(OcclusionCulling.DebugFilter value) { }

	private static void GrowStatePool() { }

	private static OccludeeState Allocate() { }

	private static void Release(OccludeeState state) { }

	private void Awake() { }

	private void OnEnable() { }

	private bool SupportsNativePath() { }

	private void OnDisable() { }

	public static void MakeAllVisible() { }

	private void Update() { }

	public static void RecursiveAddOccludees<T>(Transform transform, float minTimeVisible = 0,1, bool isStatic = True, bool stickyGizmos = False) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.RecursiveAddOccludees<object>
	*/

	private static int FindFreeSlot(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled) { }

	public static OccludeeState GetStateById(int id) { }

	public static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	private static int RegisterOccludee(Vector3 center, float radius, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged, OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, Queue<int> recycled, List<int> changed, OcclusionCulling.BufferSet set, OcclusionCulling.SimpleList<int> visibilityChanged) { }

	public static void UnregisterOccludee(int id) { }

	private static void UnregisterOccludee(int slot, OcclusionCulling.SimpleList<OccludeeState> occludees, Queue<int> recycled, List<int> changed) { }

	public static void UpdateDynamicOccludee(int id, Vector3 center, float radius) { }

	private void UpdateBuffers(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, List<int> changed, bool isStatic) { }

	private void UpdateCameraMatrices(bool starting = False) { }

	private void OnPreCull() { }

	private void OnPostRender() { }

	private float[] MatrixToFloatArray(Matrix4x4 m) { }

	private void PrepareAndDispatch() { }

	private void IssueRead() { }

	public void ResetTiming(OcclusionCulling.SmartList bucket) { }

	public void ResetTiming() { }

	private static bool FrustumCull(Vector4[] planes, Vector4 testSphere) { }

	private static int ProcessOccludees_Safe(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SmartList bucket, Color32[] results, OcclusionCulling.SimpleList<int> changed, Vector4[] frustumPlanes, float time, uint frame) { }

	private static int ProcessOccludees_Fast(OccludeeState.State[] states, int[] bucket, int bucketCount, Color32[] results, int resultCount, int[] changed, ref int changedCount, Vector4[] frustumPlanes, float time, uint frame) { }

	private static extern int ProcessOccludees_Native(ref OccludeeState.State states, ref int bucket, int bucketCount, ref Color32 results, int resultCount, ref int changed, ref int changedCount, ref Vector4 frustumPlanes, float time, uint frame) { }

	private void ApplyVisibility_Safe(float time, uint frame) { }

	private void ApplyVisibility_Fast(float time, uint frame) { }

	private void ApplyVisibility_Native(float time, uint frame) { }

	private void ProcessCallbacks(OcclusionCulling.SimpleList<OccludeeState> occludees, OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.SimpleList<int> changed) { }

	public void RetrieveAndApplyVisibility() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class OcclusionCulling.BufferSet // TypeDefIndex: 11510
{	public ComputeBuffer inputBuffer; // 0x10
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

	public bool Ready { get; }


	public bool get_Ready() { }

	public void Attach(OcclusionCulling culling) { }

	public void Dispose(bool data = True) { }

	public bool CheckResize(int count, int granularity) { }

	public void UploadData() { }

	private int AlignDispatchSize(int dispatchSize) { }

	public void Dispatch(int count) { }

	public void IssueRead() { }

	public void GetResults() { }

	public void .ctor() { }

}

public enum OcclusionCulling.DebugFilter // TypeDefIndex: 11511
{	public int value__; // 0x0
	public const OcclusionCulling.DebugFilter Off = 0;
	public const OcclusionCulling.DebugFilter Dynamic = 1;
	public const OcclusionCulling.DebugFilter Static = 2;
	public const OcclusionCulling.DebugFilter Grid = 3;
	public const OcclusionCulling.DebugFilter All = 4;

}

public enum OcclusionCulling.DebugMask // TypeDefIndex: 11512
{	public int value__; // 0x0
	public const OcclusionCulling.DebugMask Off = 0;
	public const OcclusionCulling.DebugMask Dynamic = 1;
	public const OcclusionCulling.DebugMask Static = 2;
	public const OcclusionCulling.DebugMask Grid = 4;
	public const OcclusionCulling.DebugMask All = 7;

}

public class OcclusionCulling.DebugSettings // TypeDefIndex: 11513
{	public bool log; // 0x10
	public bool showAllVisible; // 0x11
	public bool showMipChain; // 0x12
	public bool showMain; // 0x13
	public int showMainLod; // 0x14
	public bool showFallback; // 0x18
	public bool showStats; // 0x19
	public bool showScreenBounds; // 0x1A
	public OcclusionCulling.DebugMask showMask; // 0x1C
	public LayerMask layerFilter; // 0x20


	public void .ctor() { }

}

public class OcclusionCulling.HashedPoolValue // TypeDefIndex: 11514
{	public ulong hashedPoolKey; // 0x10
	public int hashedPoolIndex; // 0x18


	public void .ctor() { }

}

public class OcclusionCulling.HashedPool<ValueType> // TypeDefIndex: 11515
{	private int granularity; // 0x0
	private Dictionary<ulong, ValueType> dict; // 0x0
	private List<ValueType> pool; // 0x0
	private List<ValueType> list; // 0x0
	private Queue<ValueType> recycled; // 0x0

	public int Size { get; }
	public int Count { get; }
	public ValueType Item { get; set; }


	public int get_Size() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Size
	|-OcclusionCulling.HashedPool<object>.get_Size
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Count
	|-OcclusionCulling.HashedPool<object>.get_Count
	*/

	public ValueType get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.get_Item
	|-OcclusionCulling.HashedPool<object>.get_Item
	*/

	public void set_Item(int i, ValueType value) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<object>.set_Item
	*/

	public void .ctor(int capacity, int granularity) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>..ctor
	|-OcclusionCulling.HashedPool<object>..ctor
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<object>.Clear
	*/

	public ValueType Add(ulong key, int capacityGranularity = 16) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Add
	|-OcclusionCulling.HashedPool<object>.Add
	*/

	public void Remove(ValueType value) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.Remove
	|-OcclusionCulling.HashedPool<object>.Remove
	*/

	public bool TryGetValue(ulong key, out ValueType value) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<OcclusionCulling.Cell>.TryGetValue
	|-OcclusionCulling.HashedPool<object>.TryGetValue
	*/

	public bool ContainsKey(ulong key) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.HashedPool<object>.ContainsKey
	*/

}

public class OcclusionCulling.SimpleList<T> // TypeDefIndex: 11516
{	private const int defaultCapacity = 16;
	private static readonly T[] emptyArray; // 0x0
	public T[] array; // 0x0
	public int count; // 0x0

	public int Count { get; }
	public int Capacity { get; set; }
	public T Item { get; set; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Count
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Count
	|-OcclusionCulling.SimpleList<int>.get_Count
	|-OcclusionCulling.SimpleList<object>.get_Count
	*/

	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Capacity
	|-OcclusionCulling.SimpleList<int>.get_Capacity
	|-OcclusionCulling.SimpleList<object>.get_Capacity
	*/

	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Capacity
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Capacity
	|-OcclusionCulling.SimpleList<int>.set_Capacity
	|-OcclusionCulling.SimpleList<object>.set_Capacity
	*/

	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.get_Item
	|
	|-OcclusionCulling.SimpleList<OccludeeState>.get_Item
	|-OcclusionCulling.SimpleList<object>.get_Item
	|
	|-OcclusionCulling.SimpleList<int>.get_Item
	*/

	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.set_Item
	|
	|-OcclusionCulling.SimpleList<OccludeeState>.set_Item
	|-OcclusionCulling.SimpleList<object>.set_Item
	|
	|-OcclusionCulling.SimpleList<int>.set_Item
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>..ctor
	|-OcclusionCulling.SimpleList<OccludeeState>..ctor
	|-OcclusionCulling.SimpleList<int>..ctor
	|-OcclusionCulling.SimpleList<object>..ctor
	*/

	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Add
	|
	|-OcclusionCulling.SimpleList<OccludeeState>.Add
	|-OcclusionCulling.SimpleList<object>.Add
	|
	|-OcclusionCulling.SimpleList<int>.Add
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Clear
	|-OcclusionCulling.SimpleList<int>.Clear
	|-OcclusionCulling.SimpleList<object>.Clear
	*/

	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.Contains
	|
	|-OcclusionCulling.SimpleList<int>.Contains
	|
	|-OcclusionCulling.SimpleList<object>.Contains
	*/

	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.CopyTo
	|-OcclusionCulling.SimpleList<int>.CopyTo
	|-OcclusionCulling.SimpleList<object>.CopyTo
	*/

	public void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>.EnsureCapacity
	|-OcclusionCulling.SimpleList<int>.EnsureCapacity
	|-OcclusionCulling.SimpleList<object>.EnsureCapacity
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-OcclusionCulling.SimpleList<OccludeeState.State>..cctor
	|-OcclusionCulling.SimpleList<int>..cctor
	|-OcclusionCulling.SimpleList<object>..cctor
	*/

}

public class OcclusionCulling.SmartListValue // TypeDefIndex: 11517
{	public int hashedListIndex; // 0x10


	public void .ctor() { }

}

public class OcclusionCulling.SmartList // TypeDefIndex: 11518
{	private const int defaultCapacity = 16;
	private static readonly OccludeeState[] emptyList; // 0x0
	private static readonly int[] emptySlots; // 0x8
	private OccludeeState[] list; // 0x10
	private int[] slots; // 0x18
	private Queue<int> recycled; // 0x20
	private int count; // 0x28

	public OccludeeState[] List { get; }
	public int[] Slots { get; }
	public int Size { get; }
	public int Count { get; }
	public OccludeeState Item { get; set; }
	public int Capacity { get; set; }


	public OccludeeState[] get_List() { }

	public int[] get_Slots() { }

	public int get_Size() { }

	public int get_Count() { }

	public OccludeeState get_Item(int i) { }

	public void set_Item(int i, OccludeeState value) { }

	public int get_Capacity() { }

	public void set_Capacity(int value) { }

	public void .ctor(int capacity) { }

	public void Add(OccludeeState value, int capacityGranularity = 16) { }

	public void Remove(OccludeeState value) { }

	public bool Contains(OccludeeState value) { }

	public void EnsureCapacity(int min) { }

	private static void .cctor() { }

}

public class OcclusionCulling.Cell : OcclusionCulling.HashedPoolValue // TypeDefIndex: 11519
{	public int x; // 0x20
	public int y; // 0x24
	public int z; // 0x28
	public Bounds bounds; // 0x2C
	public Vector4 sphereBounds; // 0x44
	public bool isVisible; // 0x54
	public OcclusionCulling.SmartList staticBucket; // 0x58
	public OcclusionCulling.SmartList dynamicBucket; // 0x60


	public void Reset() { }

	public OcclusionCulling.Cell Initialize(int x, int y, int z, Bounds bounds) { }

	public void .ctor() { }

}

public struct OcclusionCulling.Sphere // TypeDefIndex: 11520
{	public Vector3 position; // 0x0
	public float radius; // 0xC


	public bool IsValid() { }

	public void .ctor(Vector3 position, float radius) { }

}

public sealed class OcclusionCulling.OnVisibilityChanged : MulticastDelegate // TypeDefIndex: 11521
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(bool visible) { }

	public virtual IAsyncResult BeginInvoke(bool visible, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

