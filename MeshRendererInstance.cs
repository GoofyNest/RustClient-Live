public struct MeshRendererInstance // TypeDefIndex: 9165
{	// Fields
	public Renderer renderer; // 0x0
	public OBB bounds; // 0x8
	public Vector3 position; // 0x58
	public Quaternion rotation; // 0x64
	public Vector3 scale; // 0x74
	public MeshCache.Data data; // 0x80

	// Properties
	public Mesh mesh { get; set; }

	// Methods

	// RVA: 0xFAA10 Offset: 0xF9E10 VA: 0x1800FAA10
	public Mesh get_mesh() { }

	// RVA: 0xFAA30 Offset: 0xF9E30 VA: 0x1800FAA30
	public void set_mesh(Mesh value) { }

}

