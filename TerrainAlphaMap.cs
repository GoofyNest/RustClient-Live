public class TerrainAlphaMap : TerrainMap<byte> // TypeDefIndex: 10389
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCDEE0 Offset: 0xCD2E0 VA: 0x1800CDEE0
	public Texture2D AlphaTexture; // 0x48

	// Methods

	// RVA: 0x1132020 Offset: 0x1131420 VA: 0x181132020 Slot: 4
	public override void Setup() { }

	// RVA: 0x1131330 Offset: 0x1130730 VA: 0x181131330
	public void GenerateTextures() { }

	// RVA: 0x11312D0 Offset: 0x11306D0 VA: 0x1811312D0
	public void ApplyTextures() { }

	// RVA: 0x1131520 Offset: 0x1130920 VA: 0x181131520
	public float GetAlpha(Vector3 worldPos) { }

	// RVA: 0x1131660 Offset: 0x1130A60 VA: 0x181131660
	public float GetAlpha(float normX, float normZ) { }

	// RVA: 0x11314D0 Offset: 0x11308D0 VA: 0x1811314D0
	public float GetAlpha(int x, int z) { }

	// RVA: 0x1131B60 Offset: 0x1130F60 VA: 0x181131B60
	public void SetAlpha(Vector3 worldPos, float a) { }

	// RVA: 0x1131F70 Offset: 0x1131370 VA: 0x181131F70
	public void SetAlpha(float normX, float normZ, float a) { }

	// RVA: 0x1131AE0 Offset: 0x1130EE0 VA: 0x181131AE0
	public void SetAlpha(int x, int z, float a) { }

	// RVA: 0x1131E50 Offset: 0x1131250 VA: 0x181131E50
	public void SetAlpha(int x, int z, float a, float opacity) { }

	// RVA: 0x11318B0 Offset: 0x1130CB0 VA: 0x1811318B0
	public void SetAlpha(Vector3 worldPos, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1131D30 Offset: 0x1131130 VA: 0x181131D30
	public void SetAlpha(float normX, float normZ, float a, float opacity, float radius, float fade = 0) { }

	// RVA: 0x1132300 Offset: 0x1131700 VA: 0x181132300
	public void .ctor() { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass2_0 // TypeDefIndex: 10390
{	// Fields
	public TerrainAlphaMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FCE0 Offset: 0x114F0E0 VA: 0x18114FCE0
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainAlphaMap.<>c__DisplayClass12_0 // TypeDefIndex: 10391
{	// Fields
	public float opacity; // 0x10
	public TerrainAlphaMap <>4__this; // 0x18
	public float a; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FA60 Offset: 0x114EE60 VA: 0x18114FA60
	internal void <SetAlpha>b__0(int x, int z, float lerp) { }

}

