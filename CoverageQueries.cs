public class CoverageQueries : MonoBehaviour // TypeDefIndex: 11475
{	public bool debug; // 0x18
	public float depthBias; // 0x1C
	private static List<CoverageQueries.Query> pool; // 0x0
	private static List<CoverageQueries.Query> added; // 0x8
	private static List<CoverageQueries.Query> reused; // 0x10
	private static List<int> removed; // 0x18
	private static List<int> changed; // 0x20
	private static Queue<int> freed; // 0x28
	private static CoverageQueries.BufferSet buffer; // 0x30
	private Camera camera; // 0x20
	private Material coverageMat; // 0x28
	private static CoverageQueries instance; // 0x38
	private static bool _debugShow; // 0x40

	public static CoverageQueries Instance { get; }
	public static bool Supported { get; }
	public static bool DebugShow { get; set; }


	public static CoverageQueries get_Instance() { }

	public static bool get_Supported() { }

	public static bool get_DebugShow() { }

	public static void set_DebugShow(bool value) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void OnPostRender() { }

	private void UpdateCollection() { }

	private void PrepareAndDispatch() { }

	private void IssueRead() { }

	private void FetchAndAnalyseResults() { }

	public static void RegisterQuery(CoverageQueries.Query query) { }

	public static void UnregisterQuery(CoverageQueries.Query query) { }

	public static void UpdateQuery(CoverageQueries.Query query) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class CoverageQueries.BufferSet // TypeDefIndex: 11476
{	public int width; // 0x10
	public int height; // 0x14
	public Texture2D inputTexture; // 0x18
	public RenderTexture resultTexture; // 0x20
	public Color[] inputData; // 0x28
	public Color32[] resultData; // 0x30
	private Material coverageMat; // 0x38
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests; // 0x40


	public void Attach(Material coverageMat) { }

	public void Dispose(bool data = True) { }

	public bool CheckResize(int count) { }

	public void UploadData() { }

	public void Dispatch(int count) { }

	public void IssueRead() { }

	public void GetResults() { }

	public void .ctor() { }

}

public enum CoverageQueries.RadiusSpace // TypeDefIndex: 11477
{	public int value__; // 0x0
	public const CoverageQueries.RadiusSpace ScreenNormalized = 0;
	public const CoverageQueries.RadiusSpace World = 1;

}

public class CoverageQueries.Query // TypeDefIndex: 11478
{	public CoverageQueries.Query.Input input; // 0x10
	public CoverageQueries.Query.Internal intern; // 0x2C
	public CoverageQueries.Query.Result result; // 0x30

	public bool IsRegistered { get; }


	public bool get_IsRegistered() { }

	private void Reset() { }

	public void .ctor() { }

	public void .ctor(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15) { }

	public void Register() { }

	public void Update(Vector3 position, float radius) { }

	public void UpdatePosition(Vector3 position) { }

	public void UpdateRadius(float radius) { }

	public void Unregister() { }

}

public struct CoverageQueries.Query.Input // TypeDefIndex: 11479
{	public Vector3 position; // 0x0
	public CoverageQueries.RadiusSpace radiusSpace; // 0xC
	public float radius; // 0x10
	public int sampleCount; // 0x14
	public float smoothingSpeed; // 0x18

}

public struct CoverageQueries.Query.Internal // TypeDefIndex: 11480
{	public int id; // 0x0


	public void Reset() { }

}

public struct CoverageQueries.Query.Result // TypeDefIndex: 11481
{	public int passed; // 0x0
	public float coverage; // 0x4
	public float smoothCoverage; // 0x8
	public float weightedCoverage; // 0xC
	public float weightedSmoothCoverage; // 0x10
	public bool originOccluded; // 0x14
	public int frame; // 0x18
	public float originVisibility; // 0x1C
	public float originSmoothVisibility; // 0x20


	public void Reset() { }

}

