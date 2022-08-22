public class MeshColliderLookup // TypeDefIndex: 9157
{	public MeshColliderLookup.LookupGroup src; // 0x10
	public MeshColliderLookup.LookupGroup dst; // 0x18


	public void Apply() { }

	public void Add(MeshColliderInstance instance) { }

	public MeshColliderLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9158
{	public List<MeshColliderLookup.LookupEntry> data; // 0x10
	public List<int> indices; // 0x18


	public void Clear() { }

	public void Add(MeshColliderInstance instance) { }

	public MeshColliderLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 9159
{	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18


	public void .ctor(MeshColliderInstance instance) { }

}

