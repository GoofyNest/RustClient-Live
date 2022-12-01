public class GenerateDungeonGrid : ProceduralComponent // TypeDefIndex: 12218
{
	public string TunnelFolder;
	public string StationFolder;
	public string TransitionFolder;
	public string LinkFolder;
	public InfrastructureType ConnectionType;
	public int CellSize;
	public float LinkHeight;
	public float LinkRadius;
	public float LinkTransition;
	private const int MaxDepth = 100000;

	public override bool RunOnCache { get; }


	public override bool get_RunOnCache() { }

	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateDungeonGrid.PathNode // TypeDefIndex: 12219
{
	public MonumentInfo monument;
	public PathFinder.Node node;


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathSegment // TypeDefIndex: 12220
{
	public PathFinder.Node start;
	public PathFinder.Node end;


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLink // TypeDefIndex: 12221
{
	public GenerateDungeonGrid.PathLinkSide downwards;
	public GenerateDungeonGrid.PathLinkSide upwards;


	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSide // TypeDefIndex: 12222
{
	public GenerateDungeonGrid.PathLinkSegment origin;
	public List<GenerateDungeonGrid.PathLinkSegment> segments;

	public GenerateDungeonGrid.PathLinkSegment prevSegment { get; }


	public GenerateDungeonGrid.PathLinkSegment get_prevSegment() { }

	public void .ctor() { }

}

private class GenerateDungeonGrid.PathLinkSegment // TypeDefIndex: 12223
{
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 scale;
	public Prefab<DungeonGridLink> prefab;
	public DungeonGridLink link;

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

private struct GenerateDungeonGrid.<>c__DisplayClass17_0 // TypeDefIndex: 12224
{
	public PathFinder pathFinder;
	public List<GenerateDungeonGrid.PathNode> secondaryNodeList;
	public List<GenerateDungeonGrid.PathNode> unconnectedNodeList;
	public DungeonGridConnectionHash[,] hashmap;

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_1 // TypeDefIndex: 12225
{
	public DungeonGridInfo entrance;

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_2 // TypeDefIndex: 12226
{
	public PathFinder.Node stationNode;
	public GenerateDungeonGrid <>4__this;


	public void .ctor() { }

	internal void <Process>g__AddNode|1(int x, int y, ref GenerateDungeonGrid.<>c

	internal bool <Process>

	internal bool <Process>

}

private struct GenerateDungeonGrid.<>c__DisplayClass17_3 // TypeDefIndex: 12227
{
	public bool isStartPoint;

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_4 // TypeDefIndex: 12228
{
	public GenerateDungeonGrid.PathSegment segment;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_5 // TypeDefIndex: 12229
{
	public GenerateDungeonGrid.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_6 // TypeDefIndex: 12230
{
	public GenerateDungeonGrid.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateDungeonGrid.<>c__DisplayClass17_7 // TypeDefIndex: 12231
{
	public GenerateDungeonGrid.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateDungeonGrid.<>c // TypeDefIndex: 12232
{
	public static readonly GenerateDungeonGrid.<>c <>9;
	public static Func<Prefab<DungeonGridLink>, int> <>9__17_0;
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_4;
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_5;
	public static Func<GenerateDungeonGrid.PathNode, PathFinder.Point> <>9__17_6;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <Process>

	internal PathFinder.Point <Process>

	internal PathFinder.Point <Process>

	internal PathFinder.Point <Process>

}

