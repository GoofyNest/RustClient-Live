public class PlaceMonuments : ProceduralComponent // TypeDefIndex: 10536
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int TargetCount; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0xDA100 Offset: 0xD9500 VA: 0x1800DA100
	public int MinDistanceSameType; // 0x3C
	public int MinDistanceDifferentType; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xDA180 Offset: 0xD9580 VA: 0x1800DA180
	public int MinWorldSize; // 0x44
	[TooltipAttribute] // RVA: 0xDA380 Offset: 0xD9780 VA: 0x1800DA380
	public PlaceMonuments.DistanceMode DistanceSameType; // 0x48
	[TooltipAttribute] // RVA: 0xDA500 Offset: 0xD9900 VA: 0x1800DA500
	public PlaceMonuments.DistanceMode DistanceDifferentType; // 0x4C
	private const int GroupCandidates = 8;
	private const int IndividualCandidates = 8;
	private const int Attempts = 10000;
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0x8DBA50 Offset: 0x8DAE50 VA: 0x1808DBA50 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x8DAE40 Offset: 0x8DA240 VA: 0x1808DAE40
	private PlaceMonuments.DistanceInfo GetDistanceInfo(List<PlaceMonuments.SpawnInfo> spawns, Prefab<MonumentInfo> prefab, Vector3 monumentPos, Quaternion monumentRot, Vector3 monumentScale, Vector3 dungeonPos) { }

	// RVA: 0x8DD1C0 Offset: 0x8DC5C0 VA: 0x1808DD1C0
	public void .ctor() { }

}

private struct PlaceMonuments.SpawnInfo // TypeDefIndex: 10537
{	// Fields
	public Prefab<MonumentInfo> prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24
	public bool dungeonEntrance; // 0x30
	public Vector3 dungeonEntrancePos; // 0x34

}

private struct PlaceMonuments.DistanceInfo // TypeDefIndex: 10538
{	// Fields
	public float minDistanceSameType; // 0x0
	public float maxDistanceSameType; // 0x4
	public float minDistanceDifferentType; // 0x8
	public float maxDistanceDifferentType; // 0xC
	public float minDistanceDungeonEntrance; // 0x10
	public float maxDistanceDungeonEntrance; // 0x14

}

public enum PlaceMonuments.DistanceMode // TypeDefIndex: 10539
{	// Fields
	public int value__; // 0x0
	public const PlaceMonuments.DistanceMode Any = 0;
	public const PlaceMonuments.DistanceMode Min = 1;
	public const PlaceMonuments.DistanceMode Max = 2;

}

private sealed class PlaceMonuments.<>c // TypeDefIndex: 10540
{	// Fields
	public static readonly PlaceMonuments.<>c <>9; // 0x0
	public static Func<string, string> <>9__15_0; // 0x8

	// Methods

	// RVA: 0x8E4E40 Offset: 0x8E4240 VA: 0x1808E4E40
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8E4A50 Offset: 0x8E3E50 VA: 0x1808E4A50
	internal string <Process>b__15_0(string folder) { }

}

