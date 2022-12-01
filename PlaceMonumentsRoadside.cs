public class PlaceMonumentsRoadside : ProceduralComponent // TypeDefIndex: 12309
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
	public PlaceMonumentsRoadside.DistanceMode DistanceSameType;
	[TooltipAttribute]
	public PlaceMonumentsRoadside.DistanceMode DistanceDifferentType;
	public PlaceMonumentsRoadside.RoadMode RoadType;
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private static Quaternion rot90;


	public override void Process(uint seed) { }

	private PlaceMonumentsRoadside.DistanceInfo GetDistanceInfo(List<PlaceMonumentsRoadside.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct PlaceMonumentsRoadside.SpawnInfo // TypeDefIndex: 12310
{
	public Prefab<MonumentInfo> prefab;
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 scale;

}

private class PlaceMonumentsRoadside.SpawnInfoGroup // TypeDefIndex: 12311
{
	public bool processed;
	public Prefab<MonumentInfo> prefab;
	public List<PlaceMonumentsRoadside.SpawnInfo> candidates;


	public void .ctor() { }

}

private struct PlaceMonumentsRoadside.DistanceInfo // TypeDefIndex: 12312
{
	public float minDistanceSameType;
	public float maxDistanceSameType;
	public float minDistanceDifferentType;
	public float maxDistanceDifferentType;

}

public enum PlaceMonumentsRoadside.DistanceMode // TypeDefIndex: 12313
{
	public int value__;
	public const PlaceMonumentsRoadside.DistanceMode Any = 0;
	public const PlaceMonumentsRoadside.DistanceMode Min = 1;
	public const PlaceMonumentsRoadside.DistanceMode Max = 2;

}

public enum PlaceMonumentsRoadside.RoadMode // TypeDefIndex: 12314
{
	public int value__;
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrRingRoad = 0;
	public const PlaceMonumentsRoadside.RoadMode SideRoad = 1;
	public const PlaceMonumentsRoadside.RoadMode RingRoad = 2;
	public const PlaceMonumentsRoadside.RoadMode SideRoadOrDesireTrail = 3;
	public const PlaceMonumentsRoadside.RoadMode DesireTrail = 4;

}

private sealed class PlaceMonumentsRoadside.<>c // TypeDefIndex: 12315
{
	public static readonly PlaceMonumentsRoadside.<>c <>9;
	public static Func<string, string> <>9__17_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Process>

}

