public class CoverageQueries : MonoBehaviour // TypeDefIndex: 13283
{
	public bool debug;
	public float depthBias;
	private static List<CoverageQueries.Query> pool;
	private static List<CoverageQueries.Query> added;
	private static List<CoverageQueries.Query> reused;
	private static List<int> removed;
	private static List<int> changed;
	private static Queue<int> freed;
	private static CoverageQueries.BufferSet buffer;
	private Camera camera;
	private Material coverageMat;
	private static CoverageQueries instance;
	private static bool _debugShow;

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

public class CoverageQueries.BufferSet // TypeDefIndex: 13284
{
	public int width;
	public int height;
	public Texture2D inputTexture;
	public RenderTexture resultTexture;
	public Color[] inputData;
	public Color32[] resultData;
	private Material coverageMat;
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests;


	public void Attach(Material coverageMat) { }

	public void Dispose(bool data = True) { }

	public bool CheckResize(int count) { }

	public void UploadData() { }

	public void Dispatch(int count) { }

	public void IssueRead() { }

	public void GetResults() { }

	public void .ctor() { }

}

public enum CoverageQueries.RadiusSpace // TypeDefIndex: 13285
{
	public int value__;
	public const CoverageQueries.RadiusSpace ScreenNormalized = 0;
	public const CoverageQueries.RadiusSpace World = 1;

}

public class CoverageQueries.Query // TypeDefIndex: 13286
{
	public CoverageQueries.Query.Input input;
	public CoverageQueries.Query.Internal intern;
	public CoverageQueries.Query.Result result;

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

public struct CoverageQueries.Query.Input // TypeDefIndex: 13287
{
	public Vector3 position;
	public CoverageQueries.RadiusSpace radiusSpace;
	public float radius;
	public int sampleCount;
	public float smoothingSpeed;

}

public struct CoverageQueries.Query.Internal // TypeDefIndex: 13288
{
	public int id;


	public void Reset() { }

}

public struct CoverageQueries.Query.Result // TypeDefIndex: 13289
{
	public int passed;
	public float coverage;
	public float smoothCoverage;
	public float weightedCoverage;
	public float weightedSmoothCoverage;
	public bool originOccluded;
	public int frame;
	public float originVisibility;
	public float originSmoothVisibility;


	public void Reset() { }

}

