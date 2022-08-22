public abstract class TerrainPlacement : PrefabAttribute // TypeDefIndex: 10594
{	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public Vector3 size; // 0x98
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public Vector3 extents; // 0xA4
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public Vector3 offset; // 0xB0
	public bool HeightMap; // 0xBC
	public bool AlphaMap; // 0xBD
	public bool WaterMap; // 0xBE
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainSplat.Enum SplatMask; // 0xC0
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainBiome.Enum BiomeMask; // 0xC4
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum TopologyMask; // 0xC8
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef heightmap; // 0xD0
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef splatmap0; // 0xD8
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef splatmap1; // 0xE0
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef alphamap; // 0xE8
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef biomemap; // 0xF0
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef topologymap; // 0xF8
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef watermap; // 0x100
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Texture2DRef blendmap; // 0x108


	public void Apply(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected bool ShouldHeight() { }

	protected bool ShouldSplat(int id = -1) { }

	protected bool ShouldAlpha() { }

	protected bool ShouldBiome(int id = -1) { }

	protected bool ShouldTopology(int id = -1) { }

	protected bool ShouldWater() { }

	protected abstract void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected abstract void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected abstract void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected abstract void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected abstract void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected abstract void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	protected override Type GetIndexedType() { }

	protected void .ctor() { }

}

