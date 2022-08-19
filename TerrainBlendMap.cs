public class TerrainBlendMap : TerrainMap<byte> // TypeDefIndex: 10394
{	// Fields
	public Texture2D BlendTexture; // 0x48

	// Methods

	// RVA: 0x1136770 Offset: 0x1135B70 VA: 0x181136770 Slot: 4
	public override void Setup() { }

	// RVA: 0x1135DD0 Offset: 0x11351D0 VA: 0x181135DD0
	public void GenerateTextures() { }

	// RVA: 0x11312D0 Offset: 0x11306D0 VA: 0x1811312D0
	public void ApplyTextures() { }

	// RVA: 0x11361C0 Offset: 0x11355C0 VA: 0x1811361C0
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x1135F70 Offset: 0x1135370 VA: 0x181135F70
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x11314D0 Offset: 0x11308D0 VA: 0x1811314D0
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1131B60 Offset: 0x1130F60 VA: 0x181131B60
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x1131F70 Offset: 0x1131370 VA: 0x181131F70
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1131AE0 Offset: 0x1130EE0 VA: 0x181131AE0
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x1136650 Offset: 0x1135A50 VA: 0x181136650
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x1136300 Offset: 0x1135700 VA: 0x181136300
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1136530 Offset: 0x1135930 VA: 0x181136530
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1136A50 Offset: 0x1135E50 VA: 0x181136A50
	public void .ctor() { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass2_0 // TypeDefIndex: 10395
{	// Fields
	public TerrainBlendMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FCE0 Offset: 0x114F0E0 VA: 0x18114FCE0
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainBlendMap.<>c__DisplayClass12_0 // TypeDefIndex: 10396
{	// Fields
	public float opacity; // 0x10
	public TerrainBlendMap <>4__this; // 0x18
	public float a; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FBA0 Offset: 0x114EFA0 VA: 0x18114FBA0
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

