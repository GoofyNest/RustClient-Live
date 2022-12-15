public class GenerateDungeonBase : ProceduralComponent // TypeDefIndex: 12224
{
	public string EntranceFolder;
	public string LinkFolder;
	public string EndFolder;
	public string TransitionFolder;
	public InfrastructureType ConnectionType;
	private static Vector3 VolumeExtrudePositive;
	private static Vector3 VolumeExtrudeNegative;
	private const int MaxCount = 2147483647;
	private const int MaxDepth = 3;
	private const int MaxFloor = 2;
	private List<GenerateDungeonBase.DungeonSegment> segmentsTotal;
	private Quaternion[] horizontalRotations;
	private Quaternion[] pillarRotations;
	private Quaternion[] verticalRotations;

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

private class GenerateDungeonBase.DungeonSegment // TypeDefIndex: 12225
{
	public Vector3 position;
	public Quaternion rotation;
	public Prefab prefab;
	public DungeonBaseLink link;
	public int score;
	public int cost;
	public int floor;


	public void .ctor() { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_0 // TypeDefIndex: 12226
{
	public GenerateDungeonBase.DungeonSegment segmentStart;


	public void .ctor() { }

	internal float <Process>

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_1 // TypeDefIndex: 12227
{
	public GenerateDungeonBase.DungeonSegment segmentEnd;
	public GenerateDungeonBase.<>c


	public void .ctor() { }

	internal float <Process>

}

private sealed class GenerateDungeonBase.<>c // TypeDefIndex: 12228
{
	public static readonly GenerateDungeonBase.<>c <>9;
	public static Func<GenerateDungeonBase.DungeonSegment, bool> <>9__14_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Process>

}

