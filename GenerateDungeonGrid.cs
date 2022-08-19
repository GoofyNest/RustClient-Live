public class GenerateDungeonGrid : ProceduralComponent // TypeDefIndex: 10459
{	// Fields
	public string TunnelFolder; // 0x28
	public string StationFolder; // 0x30
	public string TransitionFolder; // 0x38
	public string LinkFolder; // 0x40
	public InfrastructureType ConnectionType; // 0x48
	public int CellSize; // 0x4C
	public float LinkHeight; // 0x50
	public float LinkRadius; // 0x54
	public float LinkTransition; // 0x58
	private const int MaxDepth = 100000;

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC8DFB0 Offset: 0xC8D3B0 VA: 0x180C8DFB0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0xC94600 Offset: 0xC93A00 VA: 0x180C94600
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathNode // TypeDefIndex: 10460
{	// Fields
	public MonumentInfo monument; // 0x10
	public PathFinder.Node node; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathSegment // TypeDefIndex: 10461
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLink // TypeDefIndex: 10462
{	// Fields
	public GenerateDungeonGrid.PathLinkSide downwards; // 0x10
	public GenerateDungeonGrid.PathLinkSide upwards; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSide // TypeDefIndex: 10463
{	// Fields
	public GenerateDungeonGrid.PathLinkSegment origin; // 0x10
	public List<GenerateDungeonGrid.PathLinkSegment> segments; // 0x18

	// Properties
	public GenerateDungeonGrid.PathLinkSegment prevSegment { get; }

	// Methods

	// RVA: 0xC9A170 Offset: 0xC99570 VA: 0x180C9A170
	public GenerateDungeonGrid.PathLinkSegment get_prevSegment() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSegment // TypeDefIndex: 10464
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Vector3 scale; // 0x2C
	public Prefab<DungeonGridLink> prefab; // 0x38
	public DungeonGridLink link; // 0x40

	// Properties
	public Transform downSocket { get; }
	public Transform upSocket { get; }
	public DungeonGridLinkType downType { get; }
	public DungeonGridLinkType upType { get; }

	// Methods

	// RVA: 0xC9A0F0 Offset: 0xC994F0 VA: 0x180C9A0F0
	public Transform get_downSocket() { }

	// RVA: 0xC9A130 Offset: 0xC99530 VA: 0x180C9A130
	public Transform get_upSocket() { }

	// RVA: 0xC9A110 Offset: 0xC99510 VA: 0x180C9A110
	public DungeonGridLinkType get_downType() { }

	// RVA: 0xC9A150 Offset: 0xC99550 VA: 0x180C9A150
	public DungeonGridLinkType get_upType() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_0 // TypeDefIndex: 10465
{	// Fields
	public PathFinder pathFinder; // 0x0
	public List<GenerateDungeonGrid.PathNode> secondaryNodeList; // 0x8
	public List<GenerateDungeonGrid.PathNode> unconnectedNodeList; // 0x10
	public DungeonGridConnectionHash[,] hashmap; // 0x18

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_1 // TypeDefIndex: 10466
{	// Fields
	public DungeonGridInfo entrance; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_2 // TypeDefIndex: 10467
{	// Fields
	public PathFinder.Node stationNode; // 0x10
	public GenerateDungeonGrid <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA1EA0 Offset: 0xCA12A0 VA: 0x180CA1EA0
	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c__DisplayClass17_0 , ref GenerateDungeonGrid.<>c__DisplayClass17_1 , ref GenerateDungeonGrid.<>c__DisplayClass17_3 ) { }

	// RVA: 0xCA1E60 Offset: 0xCA1260 VA: 0x180CA1E60
	internal bool <Process>b__2(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA1E60 Offset: 0xCA1260 VA: 0x180CA1E60
	internal bool <Process>b__3(GenerateDungeonGrid.PathNode x) { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_3 // TypeDefIndex: 10468
{	// Fields
	public bool isStartPoint; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_4 // TypeDefIndex: 10469
{	// Fields
	public GenerateDungeonGrid.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA22D0 Offset: 0xCA16D0 VA: 0x180CA22D0
	internal bool <Process>b__11(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA22D0 Offset: 0xCA16D0 VA: 0x180CA22D0
	internal bool <Process>b__14(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 10470
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA2360 Offset: 0xCA1760 VA: 0x180CA2360
	internal bool <Process>b__7(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA23E0 Offset: 0xCA17E0 VA: 0x180CA23E0
	internal bool <Process>b__8(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 10471
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA24E0 Offset: 0xCA18E0 VA: 0x180CA24E0
	internal bool <Process>b__9(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA2460 Offset: 0xCA1860 VA: 0x180CA2460
	internal bool <Process>b__10(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 10472
{	// Fields
	public GenerateDungeonGrid.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA2560 Offset: 0xCA1960 VA: 0x180CA2560
	internal bool <Process>b__12(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA25E0 Offset: 0xCA19E0 VA: 0x180CA25E0
	internal bool <Process>b__13(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c // TypeDefIndex: 10473
{	// Fields
	public static readonly GenerateDungeonGrid.<>c <>9; // 0x0
	public static Func<Prefab<DungeonGridLink>, int> <>9__17_0; // 0x8
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_4; // 0x10
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_5; // 0x18
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_6; // 0x20

	// Methods

	// RVA: 0xCA2DD0 Offset: 0xCA21D0 VA: 0x180CA2DD0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA1A30 Offset: 0xCA0E30 VA: 0x180CA1A30
	internal int <Process>b__17_0(Prefab<DungeonGridLink> x) { }

	// RVA: 0xCA1A50 Offset: 0xCA0E50 VA: 0x180CA1A50
	internal PathFinder.Point <Process>b__17_4(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA1A50 Offset: 0xCA0E50 VA: 0x180CA1A50
	internal PathFinder.Point <Process>b__17_5(GenerateDungeonGrid.PathNode x) { }

	// RVA: 0xCA1A50 Offset: 0xCA0E50 VA: 0x180CA1A50
	internal PathFinder.Point <Process>b__17_6(GenerateDungeonGrid.PathNode x) { }

}

