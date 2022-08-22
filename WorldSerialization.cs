public class WorldSerialization // TypeDefIndex: 7787
{	public const uint CurrentVersion = 9;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Checksum>k__BackingField; // 0x18
	public WorldData world; // 0x20

	public uint Version { get; set; }
	public string Checksum { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Checksum(string value) { }

	public void .ctor() { }

	public MapData GetMap(string name) { }

	public void AddMap(string name, byte[] data) { }

	public IEnumerable<PrefabData> GetPrefabs(string category) { }

	public void AddPrefab(string category, uint id, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public IEnumerable<PathData> GetPaths(string name) { }

	public PathData GetPath(string name) { }

	public void AddPath(PathData path) { }

	public void Clear() { }

	public void Save(string fileName) { }

	public void Load(string fileName) { }

	public void CalculateChecksum() { }

	private string Hash() { }

	public int CalculateCount() { }

}

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7788
{	public string category; // 0x10


	public void .ctor() { }

	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7789
{	public string name; // 0x10


	public void .ctor() { }

	internal bool <GetPaths>b__0(PathData p) { }

}

