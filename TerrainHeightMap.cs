public class TerrainHeightMap : TerrainMap<short> // TypeDefIndex: 10399
{	// Fields
	public Texture2D HeightTexture; // 0x48
	public Texture2D NormalTexture; // 0x50
	private float normY; // 0x58

	// Methods

	// RVA: 0x113FED0 Offset: 0x113F2D0 VA: 0x18113FED0 Slot: 4
	public override void Setup() { }

	// RVA: 0x113C220 Offset: 0x113B620 VA: 0x18113C220
	public void ApplyToTerrain() { }

	// RVA: 0x113C3F0 Offset: 0x113B7F0 VA: 0x18113C3F0
	public void GenerateTextures(bool heightTexture = True, bool normalTexture = True) { }

	// RVA: 0x113C1A0 Offset: 0x113B5A0 VA: 0x18113C1A0
	public void ApplyTextures() { }

	// RVA: 0x113CD10 Offset: 0x113C110 VA: 0x18113CD10
	public float GetHeight(Vector3 worldPos) { }

	// RVA: 0x113CFB0 Offset: 0x113C3B0 VA: 0x18113CFB0
	public float GetHeight(float normX, float normZ) { }

	// RVA: 0x113CAF0 Offset: 0x113BEF0 VA: 0x18113CAF0
	public float GetHeightFast(Vector2 uv) { }

	// RVA: 0x113CED0 Offset: 0x113C2D0 VA: 0x18113CED0
	public float GetHeight(int x, int z) { }

	// RVA: 0x113C730 Offset: 0x113BB30 VA: 0x18113C730
	public float GetHeight01(Vector3 worldPos) { }

	// RVA: 0x113C870 Offset: 0x113BC70 VA: 0x18113C870
	public float GetHeight01(float normX, float normZ) { }

	// RVA: 0x113E400 Offset: 0x113D800 VA: 0x18113E400
	public float GetTriangulatedHeight01(float normX, float normZ) { }

	// RVA: 0x848170 Offset: 0x847570 VA: 0x180848170
	public float GetHeight01(int x, int z) { }

	// RVA: 0x848170 Offset: 0x847570 VA: 0x180848170
	private float GetSrcHeight01(int x, int z) { }

	// RVA: 0x113C6E0 Offset: 0x113BAE0 VA: 0x18113C6E0
	private float GetDstHeight01(int x, int z) { }

	// RVA: 0x113DBB0 Offset: 0x113CFB0 VA: 0x18113DBB0
	public Vector3 GetNormal(Vector3 worldPos) { }

	// RVA: 0x113D660 Offset: 0x113CA60 VA: 0x18113D660
	public Vector3 GetNormal(float normX, float normZ) { }

	// RVA: 0x113D920 Offset: 0x113CD20 VA: 0x18113D920
	public Vector3 GetNormal(int x, int z) { }

	// RVA: 0x113D060 Offset: 0x113C460 VA: 0x18113D060
	private Vector3 GetNormalSobel(int x, int z) { }

	// RVA: 0x113E200 Offset: 0x113D600 VA: 0x18113E200
	public float GetSlope(Vector3 worldPos) { }

	// RVA: 0x113E120 Offset: 0x113D520 VA: 0x18113E120
	public float GetSlope(float normX, float normZ) { }

	// RVA: 0x113E040 Offset: 0x113D440 VA: 0x18113E040
	public float GetSlope(int x, int z) { }

	// RVA: 0x113DE30 Offset: 0x113D230 VA: 0x18113DE30
	public float GetSlope01(Vector3 worldPos) { }

	// RVA: 0x113DE10 Offset: 0x113D210 VA: 0x18113DE10
	public float GetSlope01(float normX, float normZ) { }

	// RVA: 0x113DD30 Offset: 0x113D130 VA: 0x18113DD30
	public float GetSlope01(int x, int z) { }

	// RVA: 0x113F540 Offset: 0x113E940 VA: 0x18113F540
	public void SetHeight(Vector3 worldPos, float height) { }

	// RVA: 0x113FB90 Offset: 0x113EF90 VA: 0x18113FB90
	public void SetHeight(float normX, float normZ, float height) { }

	// RVA: 0x849660 Offset: 0x848A60 VA: 0x180849660
	public void SetHeight(int x, int z, float height) { }

	// RVA: 0x113F9E0 Offset: 0x113EDE0 VA: 0x18113F9E0
	public void SetHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x113FD60 Offset: 0x113F160 VA: 0x18113FD60
	public void SetHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x113FDB0 Offset: 0x113F1B0 VA: 0x18113FDB0
	public void SetHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x113C000 Offset: 0x113B400 VA: 0x18113C000
	public void AddHeight(Vector3 worldPos, float delta) { }

	// RVA: 0x113BE80 Offset: 0x113B280 VA: 0x18113BE80
	public void AddHeight(float normX, float normZ, float delta) { }

	// RVA: 0x113BD70 Offset: 0x113B170 VA: 0x18113BD70
	public void AddHeight(int x, int z, float delta) { }

	// RVA: 0x113EAB0 Offset: 0x113DEB0 VA: 0x18113EAB0
	public void LowerHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x113EC60 Offset: 0x113E060 VA: 0x18113EC60
	public void LowerHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x113E930 Offset: 0x113DD30 VA: 0x18113E930
	public void LowerHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x113F210 Offset: 0x113E610 VA: 0x18113F210
	public void RaiseHeight(Vector3 worldPos, float height, float opacity) { }

	// RVA: 0x113EEF0 Offset: 0x113E2F0 VA: 0x18113EEF0
	public void RaiseHeight(float normX, float normZ, float height, float opacity) { }

	// RVA: 0x113F3C0 Offset: 0x113E7C0 VA: 0x18113F3C0
	public void RaiseHeight(int x, int z, float height, float opacity) { }

	// RVA: 0x113F710 Offset: 0x113EB10 VA: 0x18113F710
	public void SetHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113FC40 Offset: 0x113F040 VA: 0x18113FC40
	public void SetHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113E660 Offset: 0x113DA60 VA: 0x18113E660
	public void LowerHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113ECB0 Offset: 0x113E0B0 VA: 0x18113ECB0
	public void LowerHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113EF40 Offset: 0x113E340 VA: 0x18113EF40
	public void RaiseHeight(Vector3 worldPos, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113EDD0 Offset: 0x113E1D0 VA: 0x18113EDD0
	public void RaiseHeight(float normX, float normZ, float height, float opacity, float radius, float fade = 0) { }

	// RVA: 0x113BB50 Offset: 0x113AF50 VA: 0x18113BB50
	public void AddHeight(Vector3 worldPos, float delta, float radius, float fade = 0) { }

	// RVA: 0x113BEE0 Offset: 0x113B2E0 VA: 0x18113BEE0
	public void AddHeight(float normX, float normZ, float delta, float radius, float fade = 0) { }

	// RVA: 0x11401E0 Offset: 0x113F5E0 VA: 0x1811401E0
	public void .ctor() { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass4_0 // TypeDefIndex: 10400
{	// Fields
	public float[,] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150170 Offset: 0x114F570 VA: 0x181150170
	internal void <ApplyToTerrain>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_0 // TypeDefIndex: 10401
{	// Fields
	public Color32[] heights; // 0x10
	public TerrainHeightMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854760 Offset: 0x853B60 VA: 0x180854760
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass5_1 // TypeDefIndex: 10402
{	// Fields
	public int normalres; // 0x10
	public Color32[] normals; // 0x18
	public TerrainHeightMap <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11503A0 Offset: 0x114F7A0 VA: 0x1811503A0
	internal void <GenerateTextures>b__1(int z) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass43_0 // TypeDefIndex: 10403
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150040 Offset: 0x114F440 VA: 0x181150040
	internal void <SetHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass45_0 // TypeDefIndex: 10404
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150090 Offset: 0x114F490 VA: 0x181150090
	internal void <LowerHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass47_0 // TypeDefIndex: 10405
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float height; // 0x18
	public float opacity; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11500E0 Offset: 0x114F4E0 VA: 0x1811500E0
	internal void <RaiseHeight>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainHeightMap.<>c__DisplayClass49_0 // TypeDefIndex: 10406
{	// Fields
	public TerrainHeightMap <>4__this; // 0x10
	public float delta; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150130 Offset: 0x114F530 VA: 0x181150130
	internal void <AddHeight>b__0(int x, int z, float lerp) { }

}

