public static class RenderInfo // TypeDefIndex: 12020
{	// Methods

	// RVA: 0x796540 Offset: 0x795940 VA: 0x180796540
	public static void GenerateReport() { }

}

public struct RenderInfo.RendererInstance // TypeDefIndex: 12021
{	// Fields
	public bool IsVisible; // 0x0
	public bool CastShadows; // 0x1
	public bool Enabled; // 0x2
	public bool RecieveShadows; // 0x3
	public float Size; // 0x4
	public float Distance; // 0x8
	public int BoneCount; // 0xC
	public int MaterialCount; // 0x10
	public int VertexCount; // 0x14
	public int TriangleCount; // 0x18
	public int SubMeshCount; // 0x1C
	public int BlendShapeCount; // 0x20
	public string RenderType; // 0x28
	public string MeshName; // 0x30
	public string ObjectName; // 0x38
	public string EntityName; // 0x40
	public uint EntityId; // 0x48
	public bool UpdateWhenOffscreen; // 0x4C
	public int ParticleCount; // 0x50

	// Methods

	// RVA: 0x7967C0 Offset: 0x795BC0 VA: 0x1807967C0
	public static RenderInfo.RendererInstance From(Renderer renderer) { }

	// RVA: 0xF5410 Offset: 0xF4810 VA: 0x1800F5410
	public void ReadMesh(Mesh mesh) { }

}

