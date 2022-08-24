public class MeshColliderLookup // TypeDefIndex: 9157
{
	public MeshColliderLookup.LookupGroup src; 
	public MeshColliderLookup.LookupGroup dst; 


public void Apply() { }

public void Add(MeshColliderInstance instance) { }

public MeshColliderLookup.LookupEntry Get(int index) { }

public void .ctor() { }

}

public class MeshColliderLookup.LookupGroup // TypeDefIndex: 9158
{
	public List<MeshColliderLookup.LookupEntry> data; 
	public List<int> indices; 


public void Clear() { }

public void Add(MeshColliderInstance instance) { }

public MeshColliderLookup.LookupEntry Get(int index) { }

public void .ctor() { }

}

public struct MeshColliderLookup.LookupEntry // TypeDefIndex: 9159
{
	public Transform transform; 
	public Rigidbody rigidbody; 
	public Collider collider; 
	public OBB bounds; 


public void .ctor(MeshColliderInstance instance) { }

}

