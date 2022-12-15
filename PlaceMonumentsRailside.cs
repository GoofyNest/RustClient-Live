public class PlaceMonumentsRailside : ProceduralComponent // TypeDefIndex: 12314
{
	public SpawnFilter Filter;
	public string ResourceFolder;
	public int TargetCount;
	public int PositionOffset;
	public int TangentInterval;
	[FormerlySerializedAsAttribute]
	public int MinDistanceSameType;
	public int MinDistanceDifferentType;
	[FormerlySerializedAsAttribute]
	public int MinWorldSize;
	[TooltipAttribute]
	public PlaceMonumentsRailside.DistanceMode DistanceSameType;
	[TooltipAttribute]
	public PlaceMonumentsRailside.DistanceMode DistanceDifferentType;
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private static Quaternion rot90;


	public override void Process(uint seed) { }

	private PlaceMonumentsRailside.DistanceInfo GetDistanceInfo(List<PlaceMonumentsRailside.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct PlaceMonumentsRailside.SpawnInfo // TypeDefIndex: 12315
{
	public Prefab<MonumentInfo> prefab;
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 scale;

}

private class PlaceMonumentsRailside.SpawnInfoGroup // TypeDefIndex: 12316
{
	public bool processed;
	public Prefab<MonumentInfo> prefab;
	public List<PlaceMonumentsRailside.SpawnInfo> candidates;


	public void .ctor() { }

}

private struct PlaceMonumentsRailside.DistanceInfo // TypeDefIndex: 12317
{
	public float minDistanceSameType;
	public float maxDistanceSameType;
	public float minDistanceDifferentType;
	public float maxDistanceDifferentType;

}

public enum PlaceMonumentsRailside.DistanceMode // TypeDefIndex: 12318
{
	public int value__;
	public const PlaceMonumentsRailside.DistanceMode Any = 0;
	public const PlaceMonumentsRailside.DistanceMode Min = 1;
	public const PlaceMonumentsRailside.DistanceMode Max = 2;

}

private sealed class PlaceMonumentsRailside.<>c // TypeDefIndex: 12319
{
	public static readonly PlaceMonumentsRailside.<>c <>9;
	public static Func<string, string> <>9__17_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>

}

