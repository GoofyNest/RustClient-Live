public class InstancingContainer // TypeDefIndex: 11357
{	// Fields
	private int capacity; // 0x10
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; // 0x18

	// Methods

	// RVA: 0x812720 Offset: 0x811B20 VA: 0x180812720
	public void .ctor(int capacity = 128) { }

	// RVA: 0x812520 Offset: 0x811920 VA: 0x180812520
	public void Free() { }

	// RVA: 0x812450 Offset: 0x811850 VA: 0x180812450
	public void Clear() { }

	// RVA: 0x812570 Offset: 0x811970 VA: 0x180812570
	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x811F80 Offset: 0x811380 VA: 0x180811F80
	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	// RVA: 0x8121A0 Offset: 0x8115A0 VA: 0x1808121A0
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

