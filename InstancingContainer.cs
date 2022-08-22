public class InstancingContainer // TypeDefIndex: 11357
{	private int capacity; // 0x10
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; // 0x18


	public void .ctor(int capacity = 128) { }

	public void Free() { }

	public void Clear() { }

	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

