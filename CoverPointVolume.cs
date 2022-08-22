public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12126
{	public float DefaultCoverPointScore; // 0x18
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


	[ContextMenu] // RVA: 0xDFD30 Offset: 0xDF130 VA: 0x1800DFD30
	private void ClearCoverPoints() { }

	public Bounds GetBounds() { }

	private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

	internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

	public bool Contains(Vector3 point) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12127
{	public int value__; // 0x0
	public const CoverPointVolume.CoverType None = 0;
	public const CoverPointVolume.CoverType Partial = 1;
	public const CoverPointVolume.CoverType Full = 2;

}

