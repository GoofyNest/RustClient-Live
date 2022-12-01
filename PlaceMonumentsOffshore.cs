public class PlaceMonumentsOffshore : ProceduralComponent // TypeDefIndex: 12300
{
	public string ResourceFolder;
	public int TargetCount;
	public int MinDistanceFromTerrain;
	public int MaxDistanceFromTerrain;
	public int DistanceBetweenMonuments;
	[FormerlySerializedAsAttribute]
	public int MinWorldSize;
	private const int Candidates = 10;
	private const int Attempts = 10000;


	public override void Process(uint seed) { }

	private bool CheckRadius(List<PlaceMonumentsOffshore.SpawnInfo> spawns, Vector3 pos, float radius) { }

	public void .ctor() { }

}

private struct PlaceMonumentsOffshore.SpawnInfo // TypeDefIndex: 12301
{
	public Prefab prefab;
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 scale;

}

private sealed class PlaceMonumentsOffshore.<>c // TypeDefIndex: 12302
{
	public static readonly PlaceMonumentsOffshore.<>c <>9;
	public static Func<string, string> <>9__9_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>

}

