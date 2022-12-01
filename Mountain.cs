public class Mountain : TerrainPlacement // TypeDefIndex: 12348
{
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

private sealed class Mountain.<>c__DisplayClass2_0 // TypeDefIndex: 12349
{
	public Matrix4x4 worldToLocal;
	public Mountain <>4__this;
	public Vector3 position;
	public TextureData heightdata;


	public void .ctor() { }

	internal void <ApplyHeight>

}

private sealed class Mountain.<>c__DisplayClass3_0 // TypeDefIndex: 12350
{
	public Matrix4x4 worldToLocal;
	public Mountain <>4__this;
	public Vector3 position;
	public TextureData heightdata;
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

private sealed class Mountain.<>c__DisplayClass5_0 // TypeDefIndex: 12351
{
	public Matrix4x4 worldToLocal;
	public Mountain <>4__this;
	public Vector3 position;
	public TextureData heightdata;
	public TextureData biomedata;
	public bool should0;
	public bool should1;
	public bool should2;
	public bool should3;


	public void .ctor() { }

	internal void <ApplyBiome>

}

private sealed class Mountain.<>c__DisplayClass6_0 // TypeDefIndex: 12352
{
	public Matrix4x4 worldToLocal;
	public Mountain <>4__this;
	public TextureData topologydata;


	public void .ctor() { }

	internal void <ApplyTopology>

}

