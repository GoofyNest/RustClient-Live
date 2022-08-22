public struct RendererKey : IEquatable<RendererKey> // TypeDefIndex: 9921
{	public Material material; // 0x0
	public ShadowCastingMode shadows; // 0x8
	public int layer; // 0xC


	public void .ctor(Material material, ShadowCastingMode shadows, int layer) { }

	public void .ctor(MeshRenderer renderer) { }

	public void .ctor(RendererBatch batch) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(RendererKey other) { }

}

