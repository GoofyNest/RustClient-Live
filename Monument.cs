public class Monument : TerrainPlacement // TypeDefIndex: 10594
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

private sealed class Monument.<>c__DisplayClass3_0 // TypeDefIndex: 10595
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public bool useBlendMap; 
	public TextureData blenddata; 
	public Vector3 position; 
	public TextureData heightdata; 


	public void .ctor() { }

	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass4_0 // TypeDefIndex: 10596
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

	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass5_0 // TypeDefIndex: 10597
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData alphadata; 


	public void .ctor() { }

	internal void <ApplyAlpha>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass6_0 // TypeDefIndex: 10598
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData biomedata; 
	public bool should0; 
	public bool should1; 
	public bool should2; 
	public bool should3; 


	public void .ctor() { }

	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass7_0 // TypeDefIndex: 10599
{
	public Matrix4x4 worldToLocal; 
	public Monument <>4__this; 
	public TextureData topologydata; 


	public void .ctor() { }

	internal void <ApplyTopology>b__0(int x, int z) { }

}

