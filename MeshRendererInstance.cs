public struct MeshRendererInstance // TypeDefIndex: 9165
{	public Renderer renderer; // 0x0
	public OBB bounds; // 0x8
	public Vector3 position; // 0x58
	public Quaternion rotation; // 0x64
	public Vector3 scale; // 0x74
	public MeshCache.Data data; // 0x80

	public Mesh mesh { get; set; }


	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

}

