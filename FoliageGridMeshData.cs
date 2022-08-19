public class FoliageGridMeshData // TypeDefIndex: 11368
{	// Fields
	public List<FoliageGridMeshData.FoliageVertex> vertices; // 0x10
	public List<int> triangles; // 0x18
	public Bounds bounds; // 0x20

	// Methods

	// RVA: 0x6E9340 Offset: 0x6E8740 VA: 0x1806E9340
	public void Alloc() { }

	// RVA: 0x6E9C80 Offset: 0x6E9080 VA: 0x1806E9C80
	public void Free() { }

	// RVA: 0x6E9520 Offset: 0x6E8920 VA: 0x1806E9520
	public void Clear() { }

	// RVA: 0x6E9580 Offset: 0x6E8980 VA: 0x1806E9580
	public void Combine(MeshGroup meshGroup) { }

	// RVA: 0x6E9400 Offset: 0x6E8800 VA: 0x1806E9400
	public void Apply(Mesh mesh) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct FoliageGridMeshData.FoliageVertex // TypeDefIndex: 11369
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector2 uv; // 0x2C
	public Vector4 uv2; // 0x34
	public static readonly VertexAttributeDescriptor[] VertexLayout; // 0x0

	// Methods

	// RVA: 0x6ED170 Offset: 0x6EC570 VA: 0x1806ED170
	private static void .cctor() { }

}

