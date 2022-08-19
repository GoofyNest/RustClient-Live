public class Collider : Component // TypeDefIndex: 3921
{	// Properties
	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x8E690 Offset: 0x8DA90 VA: 0x18008E690
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { set; }

	// Methods

	// RVA: 0x2291F30 Offset: 0x2291330 VA: 0x182291F30
	public bool get_enabled() { }

	// RVA: 0x2291FF0 Offset: 0x22913F0 VA: 0x182291FF0
	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E520 Offset: 0x8D920 VA: 0x18008E520
	// RVA: 0x2291E40 Offset: 0x2291240 VA: 0x182291E40
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x2291F70 Offset: 0x2291370 VA: 0x182291F70
	public bool get_isTrigger() { }

	// RVA: 0x2292040 Offset: 0x2291440 VA: 0x182292040
	public void set_isTrigger(bool value) { }

	// RVA: 0x2291B40 Offset: 0x2290F40 VA: 0x182291B40
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x2291ED0 Offset: 0x22912D0 VA: 0x182291ED0
	public Bounds get_bounds() { }

	// RVA: 0x2291FB0 Offset: 0x22913B0 VA: 0x182291FB0
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x22920E0 Offset: 0x22914E0 VA: 0x1822920E0
	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E5D0 Offset: 0x8D9D0 VA: 0x18008E5D0
	// RVA: 0x2292090 Offset: 0x2291490 VA: 0x182292090
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x2291CF0 Offset: 0x22910F0 VA: 0x182291CF0
	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x2291D70 Offset: 0x2291170 VA: 0x182291D70
	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E630 Offset: 0x8DA30 VA: 0x18008E630
	// RVA: 0x2291C10 Offset: 0x2291010 VA: 0x182291C10
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x22919F0 Offset: 0x2290DF0 VA: 0x1822919F0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	public void .ctor() { }

	// RVA: 0x2291AE0 Offset: 0x2290EE0 VA: 0x182291AE0
	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x2291E80 Offset: 0x2291280 VA: 0x182291E80
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2291C80 Offset: 0x2291080 VA: 0x182291C80
	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x2291BA0 Offset: 0x2290FA0 VA: 0x182291BA0
	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

