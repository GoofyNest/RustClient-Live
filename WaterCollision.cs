public class WaterCollision : MonoBehaviour // TypeDefIndex: 10599
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x18
	private HashSet<Collider> waterColliders; // 0x20

	// Methods

	// RVA: 0x7E40D0 Offset: 0x7E34D0 VA: 0x1807E40D0
	private void Awake() { }

	// RVA: 0x7E4160 Offset: 0x7E3560 VA: 0x1807E4160
	public void Clear() { }

	// RVA: 0x7E4830 Offset: 0x7E3C30 VA: 0x1807E4830
	public void Reset(Collider collider) { }

	// RVA: 0x7E43D0 Offset: 0x7E37D0 VA: 0x1807E43D0
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x7E4460 Offset: 0x7E3860 VA: 0x1807E4460
	public bool GetIgnore(Bounds bounds) { }

	// RVA: 0x7E44E0 Offset: 0x7E38E0 VA: 0x1807E44E0
	public bool GetIgnore(Vector3 start, Vector3 end, float radius) { }

	// RVA: 0x7E4590 Offset: 0x7E3990 VA: 0x1807E4590
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x7E4330 Offset: 0x7E3730 VA: 0x1807E4330
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x7E4950 Offset: 0x7E3D50 VA: 0x1807E4950
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x7E46A0 Offset: 0x7E3AA0 VA: 0x1807E46A0
	protected void LateUpdate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

