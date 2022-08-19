public class TerrainBiomeMap : TerrainMap<byte> // TypeDefIndex: 10392
{	// Fields
	public Texture2D BiomeTexture; // 0x48
	internal int num; // 0x50

	// Methods

	// RVA: 0x1135A30 Offset: 0x1134E30 VA: 0x181135A30 Slot: 4
	public override void Setup() { }

	// RVA: 0x1133C50 Offset: 0x1133050 VA: 0x181133C50
	public void GenerateTextures() { }

	// RVA: 0x11312D0 Offset: 0x11306D0 VA: 0x1811312D0
	public void ApplyTextures() { }

	// RVA: 0x1134640 Offset: 0x1133A40 VA: 0x181134640
	public float GetBiomeMax(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1134520 Offset: 0x1133920 VA: 0x181134520
	public float GetBiomeMax(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1134430 Offset: 0x1133830 VA: 0x181134430
	public float GetBiomeMax(int x, int z, int mask = -1) { }

	// RVA: 0x1133EF0 Offset: 0x11332F0 VA: 0x181133EF0
	public int GetBiomeMaxIndex(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1134080 Offset: 0x1133480 VA: 0x181134080
	public int GetBiomeMaxIndex(float normX, float normZ, int mask = -1) { }

	// RVA: 0x1133DF0 Offset: 0x11331F0 VA: 0x181133DF0
	public int GetBiomeMaxIndex(int x, int z, int mask = -1) { }

	// RVA: 0x11341B0 Offset: 0x11335B0 VA: 0x1811341B0
	public int GetBiomeMaxType(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x11340E0 Offset: 0x11334E0 VA: 0x1811340E0
	public int GetBiomeMaxType(float normX, float normZ, int mask = -1) { }

	// RVA: 0x11343A0 Offset: 0x11337A0 VA: 0x1811343A0
	public int GetBiomeMaxType(int x, int z, int mask = -1) { }

	// RVA: 0x1134AA0 Offset: 0x1133EA0 VA: 0x181134AA0
	public float GetBiome(Vector3 worldPos, int mask) { }

	// RVA: 0x1134A40 Offset: 0x1133E40 VA: 0x181134A40
	public float GetBiome(float normX, float normZ, int mask) { }

	// RVA: 0x1134880 Offset: 0x1133C80 VA: 0x181134880
	public float GetBiome(int x, int z, int mask) { }

	// RVA: 0x1135340 Offset: 0x1134740 VA: 0x181135340
	public void SetBiome(Vector3 worldPos, int id) { }

	// RVA: 0x11350F0 Offset: 0x11344F0 VA: 0x1811350F0
	public void SetBiome(float normX, float normZ, int id) { }

	// RVA: 0x1135230 Offset: 0x1134630 VA: 0x181135230
	public void SetBiome(int x, int z, int id) { }

	// RVA: 0x1135740 Offset: 0x1134B40 VA: 0x181135740
	public void SetBiome(Vector3 worldPos, int id, float v) { }

	// RVA: 0x1135910 Offset: 0x1134D10 VA: 0x181135910
	public void SetBiome(float normX, float normZ, int id, float v) { }

	// RVA: 0x11359C0 Offset: 0x1134DC0 VA: 0x1811359C0
	public void SetBiome(int x, int z, int id, float v) { }

	// RVA: 0x1134C30 Offset: 0x1134030 VA: 0x181134C30
	public void SetBiomeRaw(int x, int z, Vector4 v, float opacity) { }

	// RVA: 0x1135590 Offset: 0x1134990 VA: 0x181135590
	private void SetBiome(int x, int z, int id, float old_val, float new_val) { }

	// RVA: 0x1135D90 Offset: 0x1135190 VA: 0x181135D90
	public void .ctor() { }

}

private sealed class TerrainBiomeMap.<>c__DisplayClass3_0 // TypeDefIndex: 10393
{	// Fields
	public TerrainBiomeMap <>4__this; // 0x10
	public Color32[] col; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x114FEA0 Offset: 0x114F2A0 VA: 0x18114FEA0
	internal void <GenerateTextures>b__0(int z) { }

}

