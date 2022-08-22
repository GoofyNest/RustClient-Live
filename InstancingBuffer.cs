public class InstancingBuffer // TypeDefIndex: 11358
{	private BufferList<Matrix4x4> matrices; // 0x10
	private Mesh mesh; // 0x18
	private Material material; // 0x20
	private int submeshIndex; // 0x28
	private int shaderPass; // 0x2C


	public void .ctor(InstancingKey key, int capacity) { }

	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	public void Clear() { }

	public void Add(Matrix4x4 matrix) { }

}

