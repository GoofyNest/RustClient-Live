public class CoverageQueries : MonoBehaviour // TypeDefIndex: 11475
{	// Fields
	public bool debug; // 0x18
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

	// Properties
	public static CoverageQueries Instance { get; }
	public static bool Supported { get; }
	public static bool DebugShow { get; set; }

	// Methods

	// RVA: 0x51A740 Offset: 0x519B40 VA: 0x18051A740
	public static CoverageQueries get_Instance() { }

	// RVA: 0x51A7A0 Offset: 0x519BA0 VA: 0x18051A7A0
	public static bool get_Supported() { }

	// RVA: 0x51A6E0 Offset: 0x519AE0 VA: 0x18051A6E0
	public static bool get_DebugShow() { }

	// RVA: 0x51A7B0 Offset: 0x519BB0 VA: 0x18051A7B0
	public static void set_DebugShow(bool value) { }

	// RVA: 0x518460 Offset: 0x517860 VA: 0x180518460
	private void Awake() { }

	// RVA: 0x518D40 Offset: 0x518140 VA: 0x180518D40
	private void OnEnable() { }

	// RVA: 0x518C50 Offset: 0x518050 VA: 0x180518C50
	private void OnDisable() { }

	// RVA: 0x51A430 Offset: 0x519830 VA: 0x18051A430
	private void Update() { }

	// RVA: 0x518ED0 Offset: 0x5182D0 VA: 0x180518ED0
	private void OnPostRender() { }

	// RVA: 0x519AD0 Offset: 0x518ED0 VA: 0x180519AD0
	private void UpdateCollection() { }

	// RVA: 0x518FF0 Offset: 0x5183F0 VA: 0x180518FF0
	private void PrepareAndDispatch() { }

	// RVA: 0x518B30 Offset: 0x517F30 VA: 0x180518B30
	private void IssueRead() { }

	// RVA: 0x5184F0 Offset: 0x5178F0 VA: 0x1805184F0
	private void FetchAndAnalyseResults() { }

	// RVA: 0x519870 Offset: 0x518C70 VA: 0x180519870
	public static void RegisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x519A10 Offset: 0x518E10 VA: 0x180519A10
	public static void UnregisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x51A370 Offset: 0x519770 VA: 0x18051A370
	public static void UpdateQuery(CoverageQueries.Query query) { }

	// RVA: 0x51A6D0 Offset: 0x519AD0 VA: 0x18051A6D0
	public void .ctor() { }

	// RVA: 0x51A450 Offset: 0x519850 VA: 0x18051A450
	private static void .cctor() { }

}

public class CoverageQueries.BufferSet // TypeDefIndex: 11476
{	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public Texture2D inputTexture; // 0x18
	public RenderTexture resultTexture; // 0x20
	public Color[] inputData; // 0x28
	public Color32[] resultData; // 0x30
	private Material coverageMat; // 0x38
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests; // 0x40

	// Methods

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void Attach(Material coverageMat) { }

	// RVA: 0x508DE0 Offset: 0x5081E0 VA: 0x180508DE0
	public void Dispose(bool data = True) { }

	// RVA: 0x5089E0 Offset: 0x507DE0 VA: 0x1805089E0
	public bool CheckResize(int count) { }

	// RVA: 0x509150 Offset: 0x508550 VA: 0x180509150
	public void UploadData() { }

	// RVA: 0x508CF0 Offset: 0x5080F0 VA: 0x180508CF0
	public void Dispatch(int count) { }

	// RVA: 0x5090C0 Offset: 0x5084C0 VA: 0x1805090C0
	public void IssueRead() { }

	// RVA: 0x508F70 Offset: 0x508370 VA: 0x180508F70
	public void GetResults() { }

	// RVA: 0x5091A0 Offset: 0x5085A0 VA: 0x1805091A0
	public void .ctor() { }

}

public enum CoverageQueries.RadiusSpace // TypeDefIndex: 11477
{	// Fields
	public int value__; // 0x0
	public const CoverageQueries.RadiusSpace ScreenNormalized = 0;
	public const CoverageQueries.RadiusSpace World = 1;

}

public class CoverageQueries.Query // TypeDefIndex: 11478
{	// Fields
	public CoverageQueries.Query.Input input; // 0x10
	public CoverageQueries.Query.Internal intern; // 0x2C
	public CoverageQueries.Query.Result result; // 0x30

	// Properties
	public bool IsRegistered { get; }

	// Methods

	// RVA: 0x524D80 Offset: 0x524180 VA: 0x180524D80
	public bool get_IsRegistered() { }

	// RVA: 0x524A10 Offset: 0x523E10 VA: 0x180524A10
	private void Reset() { }

	// RVA: 0x524CB0 Offset: 0x5240B0 VA: 0x180524CB0
	public void .ctor() { }

	// RVA: 0x524CF0 Offset: 0x5240F0 VA: 0x180524CF0
	public void .ctor(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15) { }

	// RVA: 0x5249B0 Offset: 0x523DB0 VA: 0x1805249B0
	public void Register() { }

	// RVA: 0x524C20 Offset: 0x524020 VA: 0x180524C20
	public void Update(Vector3 position, float radius) { }

	// RVA: 0x524B40 Offset: 0x523F40 VA: 0x180524B40
	public void UpdatePosition(Vector3 position) { }

	// RVA: 0x524BB0 Offset: 0x523FB0 VA: 0x180524BB0
	public void UpdateRadius(float radius) { }

	// RVA: 0x524A40 Offset: 0x523E40 VA: 0x180524A40
	public void Unregister() { }

}

public struct CoverageQueries.Query.Input // TypeDefIndex: 11479
{	// Fields
	public Vector3 position; // 0x0
	public CoverageQueries.RadiusSpace radiusSpace; // 0xC
	public float radius; // 0x10
	public int sampleCount; // 0x14
	public float smoothingSpeed; // 0x18

}

public struct CoverageQueries.Query.Internal // TypeDefIndex: 11480
{	// Fields
	public int id; // 0x0

	// Methods

	// RVA: 0xF28E0 Offset: 0xF1CE0 VA: 0x1800F28E0
	public void Reset() { }

}

public struct CoverageQueries.Query.Result // TypeDefIndex: 11481
{	// Fields
	public int passed; // 0x0
	public float coverage; // 0x4
	public float smoothCoverage; // 0x8
	public float weightedCoverage; // 0xC
	public float weightedSmoothCoverage; // 0x10
	public bool originOccluded; // 0x14
	public int frame; // 0x18
	public float originVisibility; // 0x1C
	public float originSmoothVisibility; // 0x20

	// Methods

	// RVA: 0xF28F0 Offset: 0xF1CF0 VA: 0x1800F28F0
	public void Reset() { }

}

