public class GenerateDungeonBase : ProceduralComponent // TypeDefIndex: 10455
{	// Fields
	public string EntranceFolder; // 0x28
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

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC8C8B0 Offset: 0xC8BCB0 VA: 0x180C8C8B0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC89840 Offset: 0xC88C40 VA: 0x180C89840
	private Quaternion[] GetRotationList(DungeonBaseSocketType type) { }

	// RVA: 0xC89860 Offset: 0xC88C60 VA: 0x180C89860
	private int GetSocketFloor(DungeonBaseSocketType type) { }

	// RVA: 0xC8ABB0 Offset: 0xC89FB0 VA: 0x180C8ABB0
	private bool IsFullyOccupied(List<GenerateDungeonBase.DungeonSegment> segments, GenerateDungeonBase.DungeonSegment segment) { }

	// RVA: 0xC8B0E0 Offset: 0xC8A4E0 VA: 0x180C8B0E0
	private bool NeighbourMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseTransition transition, Vector3 transitionPos, Quaternion transitionRot) { }

	// RVA: 0xC8D390 Offset: 0xC8C790 VA: 0x180C8D390
	private int SocketMatches(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC8AC60 Offset: 0xC8A060 VA: 0x180C8AC60
	private bool IsOccupied(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket socket, Vector3 socketPos, Quaternion socketRot) { }

	// RVA: 0xC89620 Offset: 0xC88A20 VA: 0x180C89620
	private int CountLocal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC89270 Offset: 0xC88670 VA: 0x180C89270
	private int CountGlobal(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link) { }

	// RVA: 0xC89870 Offset: 0xC88C70 VA: 0x180C89870
	private bool IsBlocked(List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseLink link, Vector3 linkPos, Quaternion linkRot) { }

	// RVA: 0xC8B6A0 Offset: 0xC8AAA0 VA: 0x180C8B6A0
	private void PlaceSegments(ref uint seed, int count, int budget, int floors, bool attachToFemale, bool attachToMale, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseLink>[] prefabs) { }

	// RVA: 0xC8BD50 Offset: 0xC8B150 VA: 0x180C8BD50
	private void PlaceTransitions(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, Prefab<DungeonBaseTransition>[] prefabs) { }

	// RVA: 0xC8C1C0 Offset: 0xC8B5C0 VA: 0x180C8C1C0
	private bool Place(ref uint seed, List<GenerateDungeonBase.DungeonSegment> segments, DungeonBaseSocket targetSocket, Vector3 targetPos, Quaternion targetRot, Prefab<DungeonBaseLink> prefab, Quaternion[] rotations, out DungeonBaseSocket linkSocket, out Vector3 linkPos, out Quaternion linkRot, out int linkScore) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void SetupAI() { }

	// RVA: 0xC8DB00 Offset: 0xC8CF00 VA: 0x180C8DB00
	public void .ctor() { }

	// RVA: 0xC8DA10 Offset: 0xC8CE10 VA: 0x180C8DA10
	private static void .cctor() { }

}

private class GenerateDungeonBase.DungeonSegment // TypeDefIndex: 10456
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Prefab prefab; // 0x30
	public DungeonBaseLink link; // 0x38
	public int score; // 0x40
	public int cost; // 0x44
	public int floor; // 0x48

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_0 // TypeDefIndex: 10457
{	// Fields
	public GenerateDungeonBase.DungeonSegment segmentStart; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA1BD0 Offset: 0xCA0FD0 VA: 0x180CA1BD0
	internal float <Process>b__0(GenerateDungeonBase.DungeonSegment x) { }

}

private sealed class GenerateDungeonBase.<>c__DisplayClass14_1 // TypeDefIndex: 10458
{	// Fields
	public GenerateDungeonBase.DungeonSegment segmentEnd; // 0x10
	public GenerateDungeonBase.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA1CB0 Offset: 0xCA10B0 VA: 0x180CA1CB0
	internal float <Process>b__1(GenerateDungeonBase.DungeonSegment x) { }

}

