public class PlaceMonumentsOffshore : ProceduralComponent // TypeDefIndex: 10541
{	public string ResourceFolder; // 0x28
	public int TargetCount; // 0x30
	public int MinDistanceFromTerrain; // 0x34
	public int MaxDistanceFromTerrain; // 0x38
	public int DistanceBetweenMonuments; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0xDA180 Offset: 0xD9580 VA: 0x1800DA180
	public int MinWorldSize; // 0x40
	private const int Candidates = 10;
	private const int Attempts = 10000;


	public override void Process(uint seed) { }

	private bool CheckRadius(List<PlaceMonumentsOffshore.SpawnInfo> spawns, Vector3 pos, float radius) { }

	public void .ctor() { }

}

private struct PlaceMonumentsOffshore.SpawnInfo // TypeDefIndex: 10542
{	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private sealed class PlaceMonumentsOffshore.<>c // TypeDefIndex: 10543
{	public static readonly PlaceMonumentsOffshore.<>c <>9; // 0x0
	public static Func<string, string> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>b__9_0(string folder) { }

}

