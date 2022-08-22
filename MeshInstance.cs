public struct MeshInstance // TypeDefIndex: 9162
{	public Vector3 position; // 0x0
	public Quaternion rotation; // 0xC
	public Vector3 scale; // 0x1C
	public MeshCache.Data data; // 0x28

	public Mesh mesh { get; set; }


	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

}

