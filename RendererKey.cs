public struct RendererKey : IEquatable<RendererKey> // TypeDefIndex: 11667
{
	public Material material;
	public ShadowCastingMode shadows;
	public int layer;


	public void .ctor(Material material, ShadowCastingMode shadows, int layer) { }

	public void .ctor(MeshRenderer renderer) { }

	public void .ctor(RendererBatch batch) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(RendererKey other) { }

}

