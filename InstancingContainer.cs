public class InstancingContainer // TypeDefIndex: 13109
{
	private int capacity; 
	private ListDictionary<InstancingKey, InstancingBuffer> buffers; 


	public void .ctor(int capacity = 128) { }

	public void Free() { }

	public void Clear() { }

	public InstancingBuffer Get(Mesh mesh, Material material, int submeshIndex = 0, int shaderPass = -1) { }

	public void Add(Mesh mesh, Material material, Matrix4x4 matrix, int submeshIndex = 0, int shaderPass = -1) { }

	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

}

