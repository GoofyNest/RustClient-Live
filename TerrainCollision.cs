public class TerrainCollision : TerrainExtension // TypeDefIndex: 10384
{	// Fields
	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x30
	private TerrainCollider terrainCollider; // 0x38

	// Methods

	// RVA: 0x1137E80 Offset: 0x1137280 VA: 0x181137E80 Slot: 4
	public override void Setup() { }

	// RVA: 0x1137660 Offset: 0x1136A60 VA: 0x181137660
	public void Clear() { }

	// RVA: 0x1137B60 Offset: 0x1136F60 VA: 0x181137B60
	public void Reset(Collider collider) { }

	// RVA: 0x11378F0 Offset: 0x1136CF0 VA: 0x1811378F0
	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	// RVA: 0x11377D0 Offset: 0x1136BD0 VA: 0x1811377D0
	public bool GetIgnore(RaycastHit hit) { }

	// RVA: 0x1137980 Offset: 0x1136D80 VA: 0x181137980
	public bool GetIgnore(Collider collider) { }

	// RVA: 0x1137C30 Offset: 0x1137030 VA: 0x181137C30
	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	// RVA: 0x1137A50 Offset: 0x1136E50 VA: 0x181137A50
	protected void LateUpdate() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

