public struct InstancingKey : IEquatable<InstancingKey> // TypeDefIndex: 11359
{	public Mesh mesh; // 0x0
	public int submeshIndex; // 0x8
	public Material material; // 0x10
	public int shaderPass; // 0x18


	public void .ctor(Mesh mesh, int submeshIndex, Material material, int shaderPass) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(InstancingKey other) { }

}

