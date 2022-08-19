public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 10577
{	// Fields
	public float Opacity; // 0x98
	public float Radius; // 0x9C
	public float Fade; // 0xA0

	// Methods

	// RVA: 0x1147D30 Offset: 0x1147130 VA: 0x181147D30
	public void Apply(Vector3 pos, float scale) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	// RVA: 0x1147D90 Offset: 0x1147190 VA: 0x181147D90 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x1136D90 Offset: 0x1136190 VA: 0x181136D90
	protected void .ctor() { }

}

