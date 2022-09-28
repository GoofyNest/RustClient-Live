public struct MeshRendererInstance // TypeDefIndex: 10838
{
	public Renderer renderer; 
	public OBB bounds; 
	public Vector3 position; 
	public Quaternion rotation; 
	public Vector3 scale; 
	public MeshCache.Data data; 

	public Mesh mesh { get; set; }


	public Mesh get_mesh() { }

	public void set_mesh(Mesh value) { }

}

