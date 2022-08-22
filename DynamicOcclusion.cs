public class DynamicOcclusion : MonoBehaviour // TypeDefIndex: 11536
{	public LayerMask layerMask; // 0x18
	public float minOccluderArea; // 0x1C
	public int waitFrameCount; // 0x20
	public float minSurfaceRatio; // 0x24
	public float maxSurfaceDot; // 0x28
	public PlaneAlignment planeAlignment; // 0x2C
	public float planeOffset; // 0x30
	private VolumetricLightBeam m_Master; // 0x38
	private int m_FrameCountToWait; // 0x40
	private float m_RangeMultiplier; // 0x44
	private uint m_PrevNonSubHitDirectionId; // 0x48


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

private enum DynamicOcclusion.Direction // TypeDefIndex: 11537
{	public int value__; // 0x0
	public const DynamicOcclusion.Direction Up = 0;
	public const DynamicOcclusion.Direction Right = 1;
	public const DynamicOcclusion.Direction Down = 2;
	public const DynamicOcclusion.Direction Left = 3;

}

