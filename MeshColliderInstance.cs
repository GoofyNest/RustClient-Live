public struct MeshColliderInstance // TypeDefIndex: 9156
{	// Fields
	public Transform transform; // 0x0
	public Rigidbody rigidbody; // 0x8
	public Collider collider; // 0x10
	public OBB bounds; // 0x18
	public Vector3 position; // 0x68
	public Quaternion rotation; // 0x74
	public Vector3 scale; // 0x84
	public MeshCache.Data data; // 0x90

	// Properties
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xFA8B0 Offset: 0xF9CB0 VA: 0x1800FA8B0
	public Mesh get_mesh() { }

	// RVA: 0xFA8D0 Offset: 0xF9CD0 VA: 0x1800FA8D0
	public void set_mesh(Mesh value) { }

}

