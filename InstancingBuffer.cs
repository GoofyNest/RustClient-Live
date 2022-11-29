public class InstancingBuffer // TypeDefIndex: 13151
{
	private BufferList<Matrix4x4> matrices; 
	private Mesh mesh; 
	private Material material; 
	private int submeshIndex; 
	private int shaderPass; 


	public void .ctor(InstancingKey key, int capacity) { }

	public void .ctor(Mesh mesh, Material material, int submeshIndex, int shaderPass, int capacity) { }

	public void Apply(CommandBuffer buf, bool instancing, MaterialPropertyBlock block) { }

	public void Clear() { }

	public void Add(Matrix4x4 matrix) { }

}

