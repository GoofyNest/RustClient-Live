public class FoliageGridMeshData // TypeDefIndex: 11368
{	public List<FoliageGridMeshData.FoliageVertex> vertices; // 0x10
	public List<int> triangles; // 0x18
	public Bounds bounds; // 0x20


	public void Alloc() { }

	public void Free() { }

	public void Clear() { }

	public void Combine(MeshGroup meshGroup) { }

	public void Apply(Mesh mesh) { }

	public void .ctor() { }

}

public struct FoliageGridMeshData.FoliageVertex // TypeDefIndex: 11369
{	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv; // 0x2C
	public Vector4 uv2; // 0x34
	public static readonly VertexAttributeDescriptor[] VertexLayout; // 0x0


	private static void .cctor() { }

}

