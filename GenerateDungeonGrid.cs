public class GenerateDungeonGrid : ProceduralComponent // TypeDefIndex: 10459
{	public string TunnelFolder; // 0x28
	public string StationFolder; // 0x30
	public string TransitionFolder; // 0x38
	public string LinkFolder; // 0x40
	public InfrastructureType ConnectionType; // 0x48
	public int CellSize; // 0x4C
	public float LinkHeight; // 0x50
	public float LinkRadius; // 0x54
	public float LinkTransition; // 0x58
	private const int MaxDepth = 100000;

	public override bool RunOnCache { get; }


	public override bool get_RunOnCache() { }

	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateDungeonGrid.PathNode // TypeDefIndex: 10460
{	public MonumentInfo monument; // 0x10
	public PathFinder.Node node; // 0x18


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathSegment // TypeDefIndex: 10461
{	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLink // TypeDefIndex: 10462
{	public GenerateDungeonGrid.PathLinkSide downwards; // 0x10
	public GenerateDungeonGrid.PathLinkSide upwards; // 0x18


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSide // TypeDefIndex: 10463
{	public GenerateDungeonGrid.PathLinkSegment origin; // 0x10
	public List<GenerateDungeonGrid.PathLinkSegment> segments; // 0x18

	public GenerateDungeonGrid.PathLinkSegment prevSegment { get; }


	public GenerateDungeonGrid.PathLinkSegment get_prevSegment() { }

	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSegment // TypeDefIndex: 10464
{	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C
	public Vector3 scale; // 0x2C
	public Prefab<DungeonGridLink> prefab; // 0x38
	public DungeonGridLink link; // 0x40

	public Transform downSocket { get; }
	public Transform upSocket { get; }
	public DungeonGridLinkType downType { get; }
	public DungeonGridLinkType upType { get; }


	public Transform get_downSocket() { }

	public Transform get_upSocket() { }

	public DungeonGridLinkType get_downType() { }

	public DungeonGridLinkType get_upType() { }

	public void .ctor() { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_0 // TypeDefIndex: 10465
{	public PathFinder pathFinder; // 0x0
	public List<GenerateDungeonGrid.PathNode> secondaryNodeList; // 0x8
	public List<GenerateDungeonGrid.PathNode> unconnectedNodeList; // 0x10
	public DungeonGridConnectionHash[,] hashmap; // 0x18

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_1 // TypeDefIndex: 10466
{	public DungeonGridInfo entrance; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_2 // TypeDefIndex: 10467
{	public PathFinder.Node stationNode; // 0x10
	public GenerateDungeonGrid <>4__this; // 0x18


	public void .ctor() { }

	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c__DisplayClass17_0 , ref GenerateDungeonGrid.<>c__DisplayClass17_1 , ref GenerateDungeonGrid.<>c__DisplayClass17_3 ) { }

	internal bool <Process>b__2(GenerateDungeonGrid.PathNode x) { }

	internal bool <Process>b__3(GenerateDungeonGrid.PathNode x) { }

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_3 // TypeDefIndex: 10468
{	public bool isStartPoint; // 0x0

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_4 // TypeDefIndex: 10469
{	public GenerateDungeonGrid.PathSegment segment; // 0x10


	public void .ctor() { }

	internal bool <Process>b__11(GenerateDungeonGrid.PathNode x) { }

	internal bool <Process>b__14(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 10470
{	public GenerateDungeonGrid.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__7(GenerateDungeonGrid.PathNode x) { }

	internal bool <Process>b__8(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 10471
{	public GenerateDungeonGrid.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__9(GenerateDungeonGrid.PathNode x) { }

	internal bool <Process>b__10(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 10472
{	public GenerateDungeonGrid.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__12(GenerateDungeonGrid.PathNode x) { }

	internal bool <Process>b__13(GenerateDungeonGrid.PathNode x) { }

}

private sealed class GenerateDungeonGrid.<>c // TypeDefIndex: 10473
{	public static readonly GenerateDungeonGrid.<>c <>9; // 0x0
	public static Func<Prefab<DungeonGridLink>, int> <>9__17_0; // 0x8
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_4; // 0x10
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_5; // 0x18
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_6; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Process>b__17_0(Prefab<DungeonGridLink> x) { }

	internal PathFinder.Point <Process>b__17_4(GenerateDungeonGrid.PathNode x) { }

	internal PathFinder.Point <Process>b__17_5(GenerateDungeonGrid.PathNode x) { }

	internal PathFinder.Point <Process>b__17_6(GenerateDungeonGrid.PathNode x) { }

}

