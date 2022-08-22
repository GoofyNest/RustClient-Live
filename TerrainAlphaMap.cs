public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 10389
{	[FormerlySerializedAsAttribute] // RVA: 0xCDEE0 Offset: 0xCD2E0 VA: 0x1800CDEE0
	public Texture2D AlphaTexture; // 0x48


	public override void Setup() { }

	public void GenerateTextures() { }

	public void ApplyTextures() { }

	public float GetAlpha(Vector3 worldPos) { }

	public float GetAlpha(float normX, float normZ) { }

	public float GetAlpha(int x, int z) { }

	public void SetAlpha(Vector3 worldPos, float a) { }

	public void SetAlpha(float normX, float normZ, float a) { }

	public void SetAlpha(int x, int z, float a) { }

	public void SetAlpha(int x, int z, float a, float opacity) { }

	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 10390
{	public TerrainAlphaMap <>4__this; // 0x10
	public Color32[] col; // 0x18


	public void .ctor() { }

	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass12_0 // TypeDefIndex: 10391
{	public float opacity; // 0x10
	public TerrainAlphaMap <>4__this; // 0x18
	public float a; // 0x20


	public void .ctor() { }

	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

