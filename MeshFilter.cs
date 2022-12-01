public sealed class MeshFilter : Component // TypeDefIndex: 3410
{
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { get; set; }


	[RequiredByNativeCodeAttribute]
	private void DontStripMeshFilter() { }

	public Mesh get_sharedMesh() { }

	public void set_sharedMesh(Mesh value) { }

	[NativeNameAttribute]
	public Mesh get_mesh() { }

	[NativeNameAttribute]
	public void set_mesh(Mesh value) { }

}

