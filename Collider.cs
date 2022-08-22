public class Collider : Component // TypeDefIndex: 3921
{	public bool enabled { get; set; }
	public Rigidbody attachedRigidbody { get; }
	public bool isTrigger { get; set; }
	public Bounds bounds { get; }
	[NativeMethodAttribute] // RVA: 0x8E690 Offset: 0x8DA90 VA: 0x18008E690
	public PhysicMaterial sharedMaterial { get; set; }
	public PhysicMaterial material { set; }


	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeMethodAttribute] // RVA: 0x8E520 Offset: 0x8D920 VA: 0x18008E520
	public Rigidbody get_attachedRigidbody() { }

	public bool get_isTrigger() { }

	public void set_isTrigger(bool value) { }

	public Vector3 ClosestPoint(Vector3 position) { }

	public Bounds get_bounds() { }

	public PhysicMaterial get_sharedMaterial() { }

	public void set_sharedMaterial(PhysicMaterial value) { }

	[NativeMethodAttribute] // RVA: 0x8E5D0 Offset: 0x8D9D0 VA: 0x18008E5D0
	public void set_material(PhysicMaterial value) { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[NativeNameAttribute] // RVA: 0x8E630 Offset: 0x8DA30 VA: 0x18008E630
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	public void .ctor() { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

