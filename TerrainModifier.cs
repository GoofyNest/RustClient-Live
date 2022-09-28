public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 12256
{
	public float Opacity; 
	public float Radius; 
	public float Fade; 


	public void Apply(Vector3 pos, float scale) { }

	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	protected override Type GetIndexedType() { }

	protected void .ctor() { }

}

