public class FoliageGridMeshData // TypeDefIndex: 13120
{
	public List<FoliageGridMeshData.FoliageVertex> vertices; 
	public List<int> triangles; 
	public Bounds bounds; 


	public void Alloc() { }

	public void Free() { }

	public void Clear() { }

	public void Combine(MeshGroup meshGroup) { }

	public void Apply(Mesh mesh) { }

	public void .ctor() { }

}

public struct FoliageGridMeshData.FoliageVertex // TypeDefIndex: 13121
{
	public Vector3 position; 
	public Vector3 normal; 
	public Vector4 tangent; 
	public Color32 color; 
	public Vector2 uv; 
	public Vector4 uv2; 
	public static readonly VertexAttributeDescriptor[] VertexLayout; 


	private static void .cctor() { }

}

