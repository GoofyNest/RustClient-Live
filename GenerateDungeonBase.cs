public class GenerateDungeonBase : ProceduralComponent // TypeDefIndex: 10455
{	public string EntranceFolder; // 0x28
	public string LinkFolder; // 0x30
	public string EndFolder; // 0x38
	public string TransitionFolder; // 0x40
	public InfrastructureType ConnectionType; // 0x48
	private static Vector3 VolumeExtrudePositive; // 0x0
	private static Vector3 VolumeExtrudeNegative; // 0xC
	private const int MaxCount = 2147483647;
	private const int MaxDepth = 3;
	private const int MaxFloor = 2;
	private List<GenerateDungeonBase.DungeonSegment> segmentsTotal; // 0x50
	private Quaternion[] horizontalRotations; // 0x58
	private Quaternion[] pillarRotations; // 0x60
	private Quaternion[] verticalRotations; // 0x68

	public override bool RunOnCache { get; }


	public override bool get_RunOnCache() { }

	public override void Process(uint seed) { }

	private Quaternion[] GetRotationList(DungeonBaseSocketType type) { }

	private int GetSocketFloor(DungeonBaseSocketType type) { }

	private bool IsFullyOccupied(List<GenerateDungeonBase.DungeonSegment> segments, GenerateDungeonBase.DungeonSegment segment) { }

	private bool NeighbourMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseTransition transition, Vector3 transitionPos, Quaternion transitionRot) { }

	private int SocketMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	private bool IsOccupied(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket socket, Vector3 socketPos, Quaternion socketRot) { }

	private int CountLocal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	private int CountGlobal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	private bool IsBlocked(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	private void PlaceSegments(ref uint seed, int count, int budget, int floors, bool attachToFemale, bool attachToMale, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseLink>[] prefabs) { }

	private void PlaceTransitions(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseTransition>[] prefabs) { }

	private bool Place(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket targetSocket, Vector3 targetPos, Quaternion targetRot, Prefab<DungeonBaseLink> prefab, Quaternion[] rotations, out DungeonBaseSocket linkSocket, out Vector3 linkPos, out Quaternion linkRot, out int linkScore) { }

	public static void SetupAI() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class GenerateDungeonBase.DungeonSegment // TypeDefIndex: 10456
{	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Prefab prefab; // 0x30
	public DungeonBaseLink link; // 0x38
	public int score; // 0x40
	public int cost; // 0x44
	public int floor; // 0x48


	public void .ctor() { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_0 // TypeDefIndex: 10457
{	public GenerateDungeonBase.DungeonSegment segmentStart; // 0x10


	public void .ctor() { }

	internal float <Process>b__0(GenerateDungeonBase.DungeonSegment x) { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_1 // TypeDefIndex: 10458
{	public GenerateDungeonBase.DungeonSegment segmentEnd; // 0x10
	public GenerateDungeonBase.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal float <Process>b__1(GenerateDungeonBase.DungeonSegment x) { }

}

