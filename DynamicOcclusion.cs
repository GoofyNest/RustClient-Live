public class DynamicOcclusion : MonoBehaviour // TypeDefIndex: 11536
{	// Fields
	public LayerMask layerMask; // 0x18
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

	// Methods

	// RVA: 0x1119390 Offset: 0x1118790 VA: 0x181119390
	private void OnValidate() { }

	// RVA: 0x11192F0 Offset: 0x11186F0 VA: 0x1811192F0
	private void OnEnable() { }

	// RVA: 0x11192D0 Offset: 0x11186D0 VA: 0x1811192D0
	private void OnDisable() { }

	// RVA: 0x1119E30 Offset: 0x1119230 VA: 0x181119E30
	private void Start() { }

	// RVA: 0x11192A0 Offset: 0x11186A0 VA: 0x1811192A0
	private void LateUpdate() { }

	// RVA: 0x1119010 Offset: 0x1118410 VA: 0x181119010
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	// RVA: 0x1118B50 Offset: 0x1117F50 VA: 0x181118B50
	private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x1118E10 Offset: 0x1118210 VA: 0x181118E10
	private Vector3 GetDirection(uint dirInt) { }

	// RVA: 0x1119140 Offset: 0x1118540 VA: 0x181119140
	private bool IsHitValid(RaycastHit hit) { }

	// RVA: 0x1119410 Offset: 0x1118810 VA: 0x181119410
	private void ProcessRaycasts() { }

	// RVA: 0x1119CB0 Offset: 0x11190B0 VA: 0x181119CB0
	private void SetHit(RaycastHit hit) { }

	// RVA: 0x11192D0 Offset: 0x11186D0 VA: 0x1811192D0
	private void SetHitNull() { }

	// RVA: 0x1119B70 Offset: 0x1118F70 VA: 0x181119B70
	private void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x11192D0 Offset: 0x11186D0 VA: 0x1811192D0
	private void SetClippingPlaneOff() { }

	// RVA: 0x1119F10 Offset: 0x1119310 VA: 0x181119F10
	public void .ctor() { }

}

private enum DynamicOcclusion.Direction // TypeDefIndex: 11537
{	// Fields
	public int value__; // 0x0
	public const DynamicOcclusion.Direction Up = 0;
	public const DynamicOcclusion.Direction Right = 1;
	public const DynamicOcclusion.Direction Down = 2;
	public const DynamicOcclusion.Direction Left = 3;

}

