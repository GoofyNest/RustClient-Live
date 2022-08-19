public class InstancingBuffer // TypeDefIndex: 11358
{	// Fields
	private BufferList<Matrix4x4> matrices; // 0x10
	private Mesh mesh; // 0x18
	private Material material; // 0x20
	private int submeshIndex; // 0x28
	private int shaderPass; // 0x2C

	// Methods

	// RVA: 0x811EC0 Offset: 0x8112C0 VA: 0x180811EC0
	public void .ctor(InstancingKey key, int capacity) { }

	// RVA: 0x811E00 Offset: 0x811200 VA: 0x180811E00
	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	// RVA: 0x811BD0 Offset: 0x810FD0 VA: 0x180811BD0
	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	// RVA: 0x811DB0 Offset: 0x8111B0 VA: 0x180811DB0
	public void Clear() { }

	// RVA: 0x811B50 Offset: 0x810F50 VA: 0x180811B50
	public void Add(Matrix4x4 matrix) { }

}

