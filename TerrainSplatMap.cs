public class TerrainSplatMap : TerrainMap<byte> // TypeDefIndex: 10412
{	// Fields
	public Texture2D SplatTexture0; // 0x48
	public Texture2D SplatTexture1; // 0x50
	internal int num; // 0x58

	// Methods

	// RVA: 0x114F3F0 Offset: 0x114E7F0 VA: 0x18114F3F0 Slot: 4
	public override void Setup() { }

	// RVA: 0x114CDE0 Offset: 0x114C1E0 VA: 0x18114CDE0
	public void GenerateTextures() { }

	// RVA: 0x114CD90 Offset: 0x114C190 VA: 0x18114CD90
	public void ApplyTextures() { }

	// RVA: 0x114D6A0 Offset: 0x114CAA0 VA: 0x18114D6A0
	public float GetSplatMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x114D580 Offset: 0x114C980 VA: 0x18114D580
	public float GetSplatMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x114D8E0 Offset: 0x114CCE0 VA: 0x18114D8E0
	public float GetSplatMax(int x, int z, int mask = -1) { }

	// RVA: 0x114D200 Offset: 0x114C600 VA: 0x18114D200
	public int GetSplatMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x114D1A0 Offset: 0x114C5A0 VA: 0x18114D1A0
	public int GetSplatMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x114D0A0 Offset: 0x114C4A0 VA: 0x18114D0A0
	public int GetSplatMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x114D460 Offset: 0x114C860 VA: 0x18114D460
	public int GetSplatMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x114D390 Offset: 0x114C790 VA: 0x18114D390
	public int GetSplatMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x114D4F0 Offset: 0x114C8F0 VA: 0x18114D4F0
	public int GetSplatMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x114D9D0 Offset: 0x114CDD0 VA: 0x18114D9D0
	public float GetSplat(Vector3 worldPos, int mask) { }

	// RVA: 0x114DB30 Offset: 0x114CF30 VA: 0x18114DB30
	public float GetSplat(float normX, float normZ, int mask) { }

	// RVA: 0x114DCF0 Offset: 0x114D0F0 VA: 0x18114DCF0
	public float GetSplat(int x, int z, int mask) { }

	// RVA: 0x114F1A0 Offset: 0x114E5A0 VA: 0x18114F1A0
	public void SetSplat(Vector3 worldPos, int id) { }

	// RVA: 0x114EA80 Offset: 0x114DE80 VA: 0x18114EA80
	public void SetSplat(float normX, float normZ, int id) { }

	// RVA: 0x114E970 Offset: 0x114DD70 VA: 0x18114E970
	public void SetSplat(int x, int z, int id) { }

	// RVA: 0x114E7A0 Offset: 0x114DBA0 VA: 0x18114E7A0
	public void SetSplat(Vector3 worldPos, int id, float v) { }

	// RVA: 0x114EE10 Offset: 0x114E210 VA: 0x18114EE10
	public void SetSplat(float normX, float normZ, int id, float v) { }

	// RVA: 0x114E730 Offset: 0x114DB30 VA: 0x18114E730
	public void SetSplat(int x, int z, int id, float v) { }

	// RVA: 0x114DEB0 Offset: 0x114D2B0 VA: 0x18114DEB0
	public void SetSplatRaw(int x, int z, Vector4 v1, Vector4 v2, float opacity) { }

	// RVA: 0x114EBC0 Offset: 0x114DFC0 VA: 0x18114EBC0
	public void SetSplat(Vector3 worldPos, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x114EEC0 Offset: 0x114E2C0 VA: 0x18114EEC0
	public void SetSplat(float normX, float normZ, int id, float opacity, float radius, float fade = 0) { }

	// RVA: 0x114CA10 Offset: 0x114BE10 VA: 0x18114CA10
	public void AddSplat(Vector3 worldPos, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x114CC60 Offset: 0x114C060 VA: 0x18114CC60
	public void AddSplat(float normX, float normZ, int id, float delta, float radius, float fade = 0) { }

	// RVA: 0x114EFF0 Offset: 0x114E3F0 VA: 0x18114EFF0
	private void SetSplat(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x114FA20 Offset: 0x114EE20 VA: 0x18114FA20
	public void .ctor() { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_0 // TypeDefIndex: 10413
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854830 Offset: 0x853C30 VA: 0x180854830
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass4_1 // TypeDefIndex: 10414
{	// Fields
	public Color32[] cols; // 0x10
	public TerrainSplatMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854A40 Offset: 0x853E40 VA: 0x180854A40
	internal void <GenerateTextures>b__1(int z) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass26_0 // TypeDefIndex: 10415
{	// Fields
	public TerrainSplatMap <>4__this; // 0x10
	public int idx; // 0x18
	public float opacity; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x853C30 Offset: 0x853030 VA: 0x180853C30
	internal void <SetSplat>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainSplatMap.<>c__DisplayClass28_0 // TypeDefIndex: 10416
{	// Fields
	public TerrainSplatMap <>4__this; // 0x10
	public int idx; // 0x18
	public float delta; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854550 Offset: 0x853950 VA: 0x180854550
	internal void <AddSplat>b__0(int x, int z, float lerp) { }

}

