public class MeshColliderLookup // TypeDefIndex: 10900
{
	public MeshColliderLookup.LookupGroup src;
	public MeshColliderLookup.LookupGroup dst;


	public void Apply() { }

	public void Add(MeshColliderInstance instance) { }

	public MeshColliderLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 10901
{
	public List<MeshColliderLookup.LookupEntry> data;
	public List<int> indices;


	public void Clear() { }

	public void Add(MeshColliderInstance instance) { }

	public MeshColliderLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 10902
{
	public Transform transform;
	public Rigidbody rigidbody;
	public Collider collider;
	public OBB bounds;


	public void .ctor(MeshColliderInstance instance) { }

}

