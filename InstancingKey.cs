public struct InstancingKey : IEquatable<InstancingKey> // TypeDefIndex: 13167
{
	public Mesh mesh;
	public int submeshIndex;
	public Material material;
	public int shaderPass;


	public void .ctor(Mesh mesh, int submeshIndex, Material material, int shaderPass) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(InstancingKey other) { }

}

