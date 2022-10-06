public class MeshRendererData // TypeDefIndex: 10872
{
	public List<int> triangles; 
	public List<Vector3> vertices; 
	public List<Vector3> normals; 
	public List<Vector4> tangents; 
	public List<Color32> colors32; 
	public List<Vector2> uv; 
	public List<Vector2> uv2; 
	public List<Vector4> positions; 


	public void Alloc() { }

	public void Free() { }

	public void Clear() { }

	public void Apply(Mesh mesh) { }

	public void Combine(MeshRendererGroup meshGroup) { }

	public void Combine(MeshRendererGroup meshGroup, MeshRendererLookup rendererLookup) { }

	public void .ctor() { }

}

