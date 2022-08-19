public class WaterCullingVolume : MonoBehaviour // TypeDefIndex: 10600
{	// Fields
	public bool isDynamic; // 0x18
	private Bounds worldBounds; // 0x1C
	private Vector4[] worldToLocal; // 0x38
	private bool isVisible; // 0x40
	private float distanceToCamera; // 0x44
	private static HashSet<WaterCullingVolume> volumes; // 0x0

	// Properties
	public Bounds WorldBounds { get; }
	public Vector4[] WorldToLocal { get; }
	public bool IsVisible { get; }
	public float DistanceToCamera { get; }
	public static HashSet<WaterCullingVolume> Volumes { get; }

	// Methods

	// RVA: 0x7E5460 Offset: 0x7E4860 VA: 0x1807E5460
	public Bounds get_WorldBounds() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Vector4[] get_WorldToLocal() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_IsVisible() { }

	// RVA: 0x7E53E0 Offset: 0x7E47E0 VA: 0x1807E53E0
	public float get_DistanceToCamera() { }

	// RVA: 0x7E5400 Offset: 0x7E4800 VA: 0x1807E5400
	public static HashSet<WaterCullingVolume> get_Volumes() { }

	// RVA: 0x7E4E80 Offset: 0x7E4280 VA: 0x1807E4E80
	private void UpdateTransformInfo() { }

	// RVA: 0x7E4E00 Offset: 0x7E4200 VA: 0x1807E4E00
	private void OnEnable() { }

	// RVA: 0x7E4D30 Offset: 0x7E4130 VA: 0x1807E4D30
	private void OnDisable() { }

	// RVA: 0x7E52E0 Offset: 0x7E46E0 VA: 0x1807E52E0
	private void Update() { }

	// RVA: 0x7E51B0 Offset: 0x7E45B0 VA: 0x1807E51B0
	public bool UpdateVisibility(Plane[] frustumPlanes, Vector3 cameraWorldPos) { }

	// RVA: 0x7E4DF0 Offset: 0x7E41F0 VA: 0x1807E4DF0
	protected void OnDrawGizmos() { }

	// RVA: 0x7E4DE0 Offset: 0x7E41E0 VA: 0x1807E4DE0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x7E4BB0 Offset: 0x7E3FB0 VA: 0x1807E4BB0
	private void DrawGizmos(float alpha) { }

	// RVA: 0x7E5380 Offset: 0x7E4780 VA: 0x1807E5380
	public void .ctor() { }

	// RVA: 0x7E5320 Offset: 0x7E4720 VA: 0x1807E5320
	private static void .cctor() { }

}

