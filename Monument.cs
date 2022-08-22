public class Monument : TerrainPlacement // TypeDefIndex: 10583
{	public float Radius; // 0x110
	public float Fade; // 0x114


	protected void OnDrawGizmosSelected() { }

	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	public void .ctor() { }

}

private sealed class Monument.<>c__DisplayClass3_0 // TypeDefIndex: 10584
{	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public bool useBlendMap; // 0x58
	public TextureData blenddata; // 0x60
	public Vector3 position; // 0x70
	public TextureData heightdata; // 0x80


	public void .ctor() { }

	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass4_0 // TypeDefIndex: 10585
{	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData splat0data; // 0x58
	public TextureData splat1data; // 0x68
	public bool should0; // 0x78
	public bool should1; // 0x79
	public bool should2; // 0x7A
	public bool should3; // 0x7B
	public bool should4; // 0x7C
	public bool should5; // 0x7D
	public bool should6; // 0x7E
	public bool should7; // 0x7F


	public void .ctor() { }

	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass5_0 // TypeDefIndex: 10586
{	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData alphadata; // 0x58


	public void .ctor() { }

	internal void <ApplyAlpha>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass6_0 // TypeDefIndex: 10587
{	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData biomedata; // 0x58
	public bool should0; // 0x68
	public bool should1; // 0x69
	public bool should2; // 0x6A
	public bool should3; // 0x6B


	public void .ctor() { }

	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Monument.<>c__DisplayClass7_0 // TypeDefIndex: 10588
{	public Matrix4x4 worldToLocal; // 0x10
	public Monument <>4__this; // 0x50
	public TextureData topologydata; // 0x58


	public void .ctor() { }

	internal void <ApplyTopology>b__0(int x, int z) { }

}

