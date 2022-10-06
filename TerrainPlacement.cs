public abstract class TerrainPlacement : PrefabAttribute // TypeDefIndex: 12311
{
	[ReadOnlyAttribute] 
	public Vector3 size; 
	[ReadOnlyAttribute] 
	public Vector3 extents; 
	[ReadOnlyAttribute] 
	public Vector3 offset; 
	public bool HeightMap; 
	public bool AlphaMap; 
	public bool WaterMap; 
	[InspectorFlagsAttribute] 
	public TerrainSplat.Enum SplatMask; 
	[InspectorFlagsAttribute] 
	public TerrainBiome.Enum BiomeMask; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum TopologyMask; 
	[HideInInspector] 
	public Texture2DRef heightmap; 
	[HideInInspector] 
	public Texture2DRef splatmap0; 
	[HideInInspector] 
	public Texture2DRef splatmap1; 
	[HideInInspector] 
	public Texture2DRef alphamap; 
	[HideInInspector] 
	public Texture2DRef biomemap; 
	[HideInInspector] 
	public Texture2DRef topologymap; 
	[HideInInspector] 
	public Texture2DRef watermap; 
	[HideInInspector] 
	public Texture2DRef blendmap; 


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

