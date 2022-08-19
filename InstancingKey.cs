public struct InstancingKey : IEquatable<InstancingKey> // TypeDefIndex: 11359
{	// Fields
	public Mesh mesh; // 0x0
	public int submeshIndex; // 0x8
	public Material material; // 0x10
	public int shaderPass; // 0x18

	// Methods

	// RVA: 0xF8BF0 Offset: 0xF7FF0 VA: 0x1800F8BF0
	public void .ctor(Mesh mesh, int submeshIndex, Material material, int shaderPass) { }

	// RVA: 0xF8AF0 Offset: 0xF7EF0 VA: 0x1800F8AF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF8A20 Offset: 0xF7E20 VA: 0x1800F8A20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF8AC0 Offset: 0xF7EC0 VA: 0x1800F8AC0 Slot: 4
	public bool Equals(InstancingKey other) { }

}

