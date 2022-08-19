public class TerrainTopologyMap : TerrainMap<int> // TypeDefIndex: 10417
{	// Fields
	public Texture2D TopologyTexture; // 0x48

	// Methods

	// RVA: 0x847420 Offset: 0x846820 VA: 0x180847420 Slot: 4
	public override void Setup() { }

	// RVA: 0x846710 Offset: 0x845B10 VA: 0x180846710
	public void GenerateTextures() { }

	// RVA: 0x8466E0 Offset: 0x845AE0 VA: 0x1808466E0
	public void ApplyTextures() { }

	// RVA: 0x846980 Offset: 0x845D80 VA: 0x180846980
	public bool GetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x846E70 Offset: 0x846270 VA: 0x180846E70
	public bool GetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x846DB0 Offset: 0x8461B0 VA: 0x180846DB0
	public bool GetTopology(int x, int z, int mask) { }

	// RVA: 0x846A40 Offset: 0x845E40 VA: 0x180846A40
	public int GetTopology(Vector3 worldPos) { }

	// RVA: 0x846E00 Offset: 0x846200 VA: 0x180846E00
	public int GetTopology(float normX, float normZ) { }

	// RVA: 0x8468B0 Offset: 0x845CB0 VA: 0x1808468B0
	public int GetTopologyFast(Vector2 uv) { }

	// RVA: 0x846940 Offset: 0x845D40 VA: 0x180846940
	public int GetTopology(int x, int z) { }

	// RVA: 0x847180 Offset: 0x846580 VA: 0x180847180
	public void SetTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x847230 Offset: 0x846630 VA: 0x180847230
	public void SetTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8472B0 Offset: 0x8466B0 VA: 0x1808472B0
	public void SetTopology(int x, int z, int mask) { }

	// RVA: 0x846630 Offset: 0x845A30 VA: 0x180846630
	public void AddTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x846340 Offset: 0x845740 VA: 0x180846340
	public void AddTopology(float normX, float normZ, int mask) { }

	// RVA: 0x8463C0 Offset: 0x8457C0 VA: 0x1808463C0
	public void AddTopology(int x, int z, int mask) { }

	// RVA: 0x846EF0 Offset: 0x8462F0 VA: 0x180846EF0
	public void RemoveTopology(Vector3 worldPos, int mask) { }

	// RVA: 0x847000 Offset: 0x846400 VA: 0x180847000
	public void RemoveTopology(float normX, float normZ, int mask) { }

	// RVA: 0x846FB0 Offset: 0x8463B0 VA: 0x180846FB0
	public void RemoveTopology(int x, int z, int mask) { }

	// RVA: 0x846C40 Offset: 0x846040 VA: 0x180846C40
	public int GetTopology(Vector3 worldPos, float radius) { }

	// RVA: 0x846AF0 Offset: 0x845EF0 VA: 0x180846AF0
	public int GetTopology(float normX, float normZ, float radius) { }

	// RVA: 0x8472F0 Offset: 0x8466F0 VA: 0x1808472F0
	public void SetTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x847080 Offset: 0x846480 VA: 0x180847080
	public void SetTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x846400 Offset: 0x845800 VA: 0x180846400
	public void AddTopology(Vector3 worldPos, int mask, float radius, float fade = 0) { }

	// RVA: 0x846530 Offset: 0x845930 VA: 0x180846530
	public void AddTopology(float normX, float normZ, int mask, float radius, float fade = 0) { }

	// RVA: 0x8476C0 Offset: 0x846AC0 VA: 0x1808476C0
	public void .ctor() { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass2_0 // TypeDefIndex: 10418
{	// Fields
	public Color32[] col; // 0x10
	public TerrainTopologyMap <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x854690 Offset: 0x853A90 VA: 0x180854690
	internal void <GenerateTextures>b__0(int z) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass23_0 // TypeDefIndex: 10419
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x853B70 Offset: 0x852F70 VA: 0x180853B70
	internal void <SetTopology>b__0(int x, int z, float lerp) { }

}

private sealed class TerrainTopologyMap.<>c__DisplayClass25_0 // TypeDefIndex: 10420
{	// Fields
	public TerrainTopologyMap <>4__this; // 0x10
	public int mask; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x853BD0 Offset: 0x852FD0 VA: 0x180853BD0
	internal void <AddTopology>b__0(int x, int z, float lerp) { }

}

