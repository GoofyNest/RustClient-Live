public struct RendererKey : IEquatable<RendererKey> // TypeDefIndex: 9921
{	// Fields
	public Material material; // 0x0
	public ShadowCastingMode shadows; // 0x8
	public int layer; // 0xC

	// Methods

	// RVA: 0xF9C90 Offset: 0xF9090 VA: 0x1800F9C90
	public void .ctor(Material material, ShadowCastingMode shadows, int layer) { }

	// RVA: 0xFA110 Offset: 0xF9510 VA: 0x1800FA110
	public void .ctor(MeshRenderer renderer) { }

	// RVA: 0xFA180 Offset: 0xF9580 VA: 0x1800FA180
	public void .ctor(RendererBatch batch) { }

	// RVA: 0xFA0A0 Offset: 0xF94A0 VA: 0x1800FA0A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF9FE0 Offset: 0xF93E0 VA: 0x1800F9FE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFA080 Offset: 0xF9480 VA: 0x1800FA080 Slot: 4
	public bool Equals(RendererKey other) { }

}

