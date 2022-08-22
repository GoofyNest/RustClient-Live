public class Mountain : TerrainPlacement // TypeDefIndex: 10589
{	public float Fade; // 0x110


	protected void OnDrawGizmosSelected() { }

	protected override void ApplyHeight(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplySplat(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyAlpha(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyBiome(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyTopology(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	protected override void ApplyWater(Matrix4x4 localToWorld, Matrix4x4 worldToLocal) { }

	public void .ctor() { }

}

private sealed class Mountain.<>c__DisplayClass2_0 // TypeDefIndex: 10590
{	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68


	public void .ctor() { }

	internal void <ApplyHeight>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass3_0 // TypeDefIndex: 10591
{	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData splat0data; // 0x78
	public TextureData splat1data; // 0x88
	public bool should0; // 0x98
	public bool should1; // 0x99
	public bool should2; // 0x9A
	public bool should3; // 0x9B
	public bool should4; // 0x9C
	public bool should5; // 0x9D
	public bool should6; // 0x9E
	public bool should7; // 0x9F


	public void .ctor() { }

	internal void <ApplySplat>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass5_0 // TypeDefIndex: 10592
{	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public Vector3 position; // 0x58
	public TextureData heightdata; // 0x68
	public TextureData biomedata; // 0x78
	public bool should0; // 0x88
	public bool should1; // 0x89
	public bool should2; // 0x8A
	public bool should3; // 0x8B


	public void .ctor() { }

	internal void <ApplyBiome>b__0(int x, int z) { }

}

private sealed class Mountain.<>c__DisplayClass6_0 // TypeDefIndex: 10593
{	public Matrix4x4 worldToLocal; // 0x10
	public Mountain <>4__this; // 0x50
	public TextureData topologydata; // 0x58


	public void .ctor() { }

	internal void <ApplyTopology>b__0(int x, int z) { }

}

