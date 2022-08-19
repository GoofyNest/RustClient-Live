public class WorldSerialization // TypeDefIndex: 7787
{	// Fields
	public const uint CurrentVersion = 9;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Checksum>k__BackingField; // 0x18
	public WorldData world; // 0x20

	// Properties
	public uint Version { get; set; }
	public string Checksum { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Checksum(string value) { }

	// RVA: 0x22FF9F0 Offset: 0x22FEDF0 VA: 0x1822FF9F0
	public void .ctor() { }

	// RVA: 0x22FEDE0 Offset: 0x22FE1E0 VA: 0x1822FEDE0
	public MapData GetMap(string name) { }

	// RVA: 0x22FEA40 Offset: 0x22FDE40 VA: 0x1822FEA40
	public void AddMap(string name, byte[] data) { }

	// RVA: 0x22FF0A0 Offset: 0x22FE4A0 VA: 0x1822FF0A0
	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	// RVA: 0x22FEB50 Offset: 0x22FDF50 VA: 0x1822FEB50
	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x22FEFE0 Offset: 0x22FE3E0 VA: 0x1822FEFE0
	public IEnumerable<PathData> GetPaths(string name) { }

	// RVA: 0x22FEEE0 Offset: 0x22FE2E0 VA: 0x1822FEEE0
	public PathData GetPath(string name) { }

	// RVA: 0x22FEAF0 Offset: 0x22FDEF0 VA: 0x1822FEAF0
	public void AddPath(PathData path) { }

	// RVA: 0x22FED30 Offset: 0x22FE130 VA: 0x1822FED30
	public void Clear() { }

	// RVA: 0x22FF700 Offset: 0x22FEB00 VA: 0x1822FF700
	public void Save(string fileName) { }

	// RVA: 0x22FF300 Offset: 0x22FE700 VA: 0x1822FF300
	public void Load(string fileName) { }

	// RVA: 0x22FECA0 Offset: 0x22FE0A0 VA: 0x1822FECA0
	public void CalculateChecksum() { }

	// RVA: 0x22FF160 Offset: 0x22FE560 VA: 0x1822FF160
	private string Hash() { }

	// RVA: 0x22FECD0 Offset: 0x22FE0D0 VA: 0x1822FECD0
	public int CalculateCount() { }

}

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7788
{	// Fields
	public string category; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9480 Offset: 0x8C8880 VA: 0x1808C9480
	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7789
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22FEA10 Offset: 0x22FDE10 VA: 0x1822FEA10
	internal bool <GetPaths>b__0(PathData p) { }

}

