public struct MeshColliderInstance // TypeDefIndex: 9156
{	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18
	public Vector3 position; // 0x68
	public Quaternion rotation; // 0x74
	public Vector3 scale; // 0x84
	public MeshCache.Data data; // 0x90

	public Mesh mesh { get; set; }


	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

}

