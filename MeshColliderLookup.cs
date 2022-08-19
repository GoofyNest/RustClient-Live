public class MeshColliderLookup // TypeDefIndex: 9157
{	// Fields
	public MeshColliderLookup.LookupGroup src; // 0x10
	public MeshColliderLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x95C360 Offset: 0x95B760 VA: 0x18095C360
	public void Apply() { }

	// RVA: 0x95C190 Offset: 0x95B590 VA: 0x18095C190
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x95C3F0 Offset: 0x95B7F0 VA: 0x18095C3F0
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x95C4E0 Offset: 0x95B8E0 VA: 0x18095C4E0
	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9158
{	// Fields
	public List<MeshColliderLookup.LookupEntry> data; // 0x10
	public List<int> indices; // 0x18

	// Methods

	// RVA: 0x953740 Offset: 0x952B40 VA: 0x180953740
	public void Clear() { }

	// RVA: 0x9534F0 Offset: 0x9528F0 VA: 0x1809534F0
	public void Add(MeshColliderInstance instance) { }

	// RVA: 0x953850 Offset: 0x952C50 VA: 0x180953850
	public MeshColliderLookup.LookupEntry Get(int index) { }

	// RVA: 0x9539A0 Offset: 0x952DA0 VA: 0x1809539A0
	public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 9159
{	// Fields
	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18

	// Methods

	// RVA: 0xFA750 Offset: 0xF9B50 VA: 0x1800FA750
	public void .ctor(MeshColliderInstance instance) { }

}

