public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12126
{	// Fields
	public float DefaultCoverPointScore; // 0x18
	public float CoverPointRayLength; // 0x1C
	public LayerMask CoverLayerMask; // 0x20
	public Transform BlockerGroup; // 0x28
	public Transform ManualCoverPointGroup; // 0x30
	[ServerVar] // RVA: 0xDFAF0 Offset: 0xDEEF0 VA: 0x1800DFAF0
	public static float cover_point_sample_step_size; // 0x0
	[ServerVar] // RVA: 0xDFCF0 Offset: 0xDF0F0 VA: 0x1800DFCF0
	public static float cover_point_sample_step_height; // 0x4
	public readonly List<CoverPoint> CoverPoints; // 0x38
	private readonly List<CoverPointBlockerVolume> _coverPointBlockers; // 0x40
	private Bounds bounds; // 0x48

	// Methods

	[ContextMenu] // RVA: 0xDFD30 Offset: 0xDF130 VA: 0x1800DFD30
	// RVA: 0x4B8570 Offset: 0x4B7970 VA: 0x1804B8570
	private void ClearCoverPoints() { }

	// RVA: 0x4B86C0 Offset: 0x4B7AC0 VA: 0x1804B86C0
	public Bounds GetBounds() { }

	// RVA: 0x4B8340 Offset: 0x4B7740 VA: 0x1804B8340
	private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

	// RVA: 0x4B8850 Offset: 0x4B7C50 VA: 0x1804B8850
	internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

	// RVA: 0x4B85D0 Offset: 0x4B79D0 VA: 0x1804B85D0
	public bool Contains(Vector3 point) { }

	// RVA: 0x4B8C70 Offset: 0x4B8070 VA: 0x1804B8C70
	public void .ctor() { }

	// RVA: 0x4B8C20 Offset: 0x4B8020 VA: 0x1804B8C20
	private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12127
{	// Fields
	public int value__; // 0x0
	public const CoverPointVolume.CoverType None = 0;
	public const CoverPointVolume.CoverType Partial = 1;
	public const CoverPointVolume.CoverType Full = 2;

}

