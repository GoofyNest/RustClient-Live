public class PlaceMonuments : ProceduralComponent // TypeDefIndex: 12267
{
	public SpawnFilter Filter; 
	public string ResourceFolder; 
	public int TargetCount; 
	[FormerlySerializedAsAttribute] 
	public int MinDistanceSameType; 
	public int MinDistanceDifferentType; 
	[FormerlySerializedAsAttribute] 
	public int MinWorldSize; 
	[TooltipAttribute] 
	public PlaceMonuments.DistanceMode DistanceSameType; 
	[TooltipAttribute] 
	public PlaceMonuments.DistanceMode DistanceDifferentType; 
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private const int Attempts = 10000;
	private const int MaxDepth = 100000;


	public override void Process(uint seed) { }

	private PlaceMonuments.DistanceInfo GetDistanceInfo(List<PlaceMonuments.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale, Vector3 dungeonPos) { }

	public void .ctor() { }

}

private struct PlaceMonuments.SpawnInfo // TypeDefIndex: 12268
{
	public Prefab<MonumentInfo> prefab; 
	public Vector3 position; 
	public Quaternion rotation; 
	public Vector3 scale; 
	public bool dungeonEntrance; 
	public Vector3 dungeonEntrancePos; 

}

private struct PlaceMonuments.DistanceInfo // TypeDefIndex: 12269
{
	public float minDistanceSameType; 
	public float maxDistanceSameType; 
	public float minDistanceDifferentType; 
	public float maxDistanceDifferentType; 
	public float minDistanceDungeonEntrance; 
	public float maxDistanceDungeonEntrance; 

}

public enum PlaceMonuments.DistanceMode // TypeDefIndex: 12270
{
	public int value__; 
	public const PlaceMonuments.DistanceMode Any = 0;
	public const PlaceMonuments.DistanceMode Min = 1;
	public const PlaceMonuments.DistanceMode Max = 2;

}

private sealed class PlaceMonuments.<>c // TypeDefIndex: 12271
{
	public static readonly PlaceMonuments.<>c <>9; 
	public static Func<string, string> <>9__15_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>b__15_0(string folder) { }

}

