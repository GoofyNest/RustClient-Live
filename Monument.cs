public class Monument : TerrainPlacement // TypeDefIndex: 12334
{
	public float Radius; 
	public float Fade; 


	protected void OnDrawGizmosSelected() { }

	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	public void .ctor() { }

}

private sealed class Monument.<>c__DisplayClass3_0 // TypeDefIndex: 12335
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public bool useBlendMap; 
	public TextureData blenddata; 
	public Vector3 position; 
	public TextureData heightdata; 


	public void .ctor() { }

	internal void <ApplyHeight>

}

private sealed class Monument.<>c__DisplayClass4_0 // TypeDefIndex: 12336
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData splat0data; 
	public TextureData splat1data; 
	public bool should0; 
	public bool should1; 
	public bool should2; 
	public bool should3; 
	public bool should4; 
	public bool should5; 
	public bool should6; 
	public bool should7; 


	public void .ctor() { }

	internal void <ApplySplat>

}

private sealed class Monument.<>c__DisplayClass5_0 // TypeDefIndex: 12337
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData alphadata; 


	public void .ctor() { }

	internal void <ApplyAlpha>

}

private sealed class Monument.<>c__DisplayClass6_0 // TypeDefIndex: 12338
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData biomedata; 
	public bool should0; 
	public bool should1; 
	public bool should2; 
	public bool should3; 


	public void .ctor() { }

	internal void <ApplyBiome>

}

private sealed class Monument.<>c__DisplayClass7_0 // TypeDefIndex: 12339
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData topologydata; 


	public void .ctor() { }

	internal void <ApplyTopology>

}

