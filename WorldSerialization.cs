public class WorldSerialization // TypeDefIndex: 7760
{
	public const uint CurrentVersion = 9;
	[CompilerGeneratedAttribute] 
	private uint <Version>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Checksum>k__BackingField; 
	public WorldData world; 

	public uint Version { get; set; }
	public string Checksum { get; set; }


	[CompilerGeneratedAttribute] 
	public uint get_Version() { }

	[CompilerGeneratedAttribute] 
	private void set_Version(uint value) { }

	[CompilerGeneratedAttribute] 
	public string get_Checksum() { }

	[CompilerGeneratedAttribute] 
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

private sealed class WorldSerialization.<>c__DisplayClass13_0 // TypeDefIndex: 7761
{
	public string category; 


	public void .ctor() { }

	internal bool <GetPrefabs>b__0(PrefabData p) { }

}

private sealed class WorldSerialization.<>c__DisplayClass15_0 // TypeDefIndex: 7762
{
	public string name; 


	public void .ctor() { }

	internal bool <GetPaths>b__0(PathData p) { }

}

