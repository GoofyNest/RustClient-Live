public abstract class TerrainPlacement : PrefabAttribute // TypeDefIndex: 10594
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
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

	// Methods

	// RVA: 0x114BDD0 Offset: 0x114B1D0 VA: 0x18114BDD0
	public void Apply(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	// RVA: 0x114C320 Offset: 0x114B720 VA: 0x18114C320
	protected bool ShouldHeight() { }

	// RVA: 0x114C380 Offset: 0x114B780 VA: 0x18114C380
	protected bool ShouldSplat(int id = -1) { }

	// RVA: 0x114C250 Offset: 0x114B650 VA: 0x18114C250
	protected bool ShouldAlpha() { }

	// RVA: 0x114C2B0 Offset: 0x114B6B0 VA: 0x18114C2B0
	protected bool ShouldBiome(int id = -1) { }

	// RVA: 0x114C410 Offset: 0x114B810 VA: 0x18114C410
	protected bool ShouldTopology(int id = -1) { }

	// RVA: 0x114C480 Offset: 0x114B880 VA: 0x18114C480
	protected bool ShouldWater() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal);

	// RVA: 0x114C1F0 Offset: 0x114B5F0 VA: 0x18114C1F0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x114C4E0 Offset: 0x114B8E0 VA: 0x18114C4E0
	protected void .ctor() { }

}

