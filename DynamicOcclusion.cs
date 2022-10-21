public class DynamicOcclusion : MonoBehaviour // TypeDefIndex: 13290
{
	public LayerMask layerMask; 
	public float minOccluderArea; 
	public int waitFrameCount; 
	public float minSurfaceRatio; 
	public float maxSurfaceDot; 
	public PlaneAlignment planeAlignment; 
	public float planeOffset; 
	private VolumetricLightBeam m_Master; 
	private int m_FrameCountToWait; 
	private float m_RangeMultiplier; 
	private uint m_PrevNonSubHitDirectionId; 


	private void OnValidate() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Start() { }

	private void LateUpdate() { }

	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	private Vector3 GetDirection(uint dirInt) { }

	private bool IsHitValid(RaycastHit hit) { }

	private void ProcessRaycasts() { }

	private void SetHit(RaycastHit hit) { }

	private void SetHitNull() { }

	private void SetClippingPlane(Plane planeWS) { }

	private void SetClippingPlaneOff() { }

	public void .ctor() { }

}

private enum DynamicOcclusion.Direction // TypeDefIndex: 13291
{
	public int value__; 
	public const DynamicOcclusion.Direction Up = 0;
	public const DynamicOcclusion.Direction Right = 1;
	public const DynamicOcclusion.Direction Down = 2;
	public const DynamicOcclusion.Direction Left = 3;

}

