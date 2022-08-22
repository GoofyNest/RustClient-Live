public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 10577
{	public float Opacity; // 0x98
	public float Radius; // 0x9C
	public float Fade; // 0xA0


	public void Apply(Vector3 pos, float scale) { }

	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	protected override Type GetIndexedType() { }

	protected void .ctor() { }

}

