public class CoverPointVolume : MonoBehaviour, IServerComponent // TypeDefIndex: 12126
{
	public float DefaultCoverPointScore; 
	public float CoverPointRayLength; 
	public LayerMask CoverLayerMask; 
	public Transform BlockerGroup; 
	public Transform ManualCoverPointGroup; 
	[ServerVar] 
	public static float cover_point_sample_step_size; 
	[ServerVar] 
	public static float cover_point_sample_step_height; 
	public readonly List<CoverPoint> CoverPoints; 
	private readonly List<CoverPointBlockerVolume> _coverPointBlockers; 
	private Bounds bounds; 


	[ContextMenu] 
private void ClearCoverPoints() { }

public Bounds GetBounds() { }

private CoverPoint CalculateCoverPoint(NavMeshHit info) { }

internal CoverPointVolume.CoverType ProvidesCoverInDir(Ray ray, float maxDistance, out RaycastHit rayHit) { }

public bool Contains(Vector3 point) { }

public void .ctor() { }

private static void .cctor() { }

}

internal enum CoverPointVolume.CoverType // TypeDefIndex: 12127
{
	public int value__; 
public const CoverPointVolume.CoverType None = 0;
public const CoverPointVolume.CoverType Partial = 1;
public const CoverPointVolume.CoverType Full = 2;

}

