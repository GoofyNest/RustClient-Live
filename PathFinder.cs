public class PathFinder // TypeDefIndex: 11391
{	private int[,] costmap; // 0x10
	private int[,] visited; // 0x18
	private PathFinder.Point[] neighbors; // 0x20
	private bool directional; // 0x28
	public PathFinder.Point PushPoint; // 0x2C
	public int PushRadius; // 0x34
	public int PushDistance; // 0x38
	public int PushMultiplier; // 0x3C
	private static PathFinder.Point[] mooreNeighbors; // 0x0
	private static PathFinder.Point[] neumannNeighbors; // 0x8


	public void .ctor(int[,] costmap, bool diagonals = True, bool directional = True) { }

	public int GetResolution(int index) { }

	public PathFinder.Node FindPath(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	private PathFinder.Node FindPathReversed(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	public PathFinder.Node FindPathDirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	public PathFinder.Node FindPathUndirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	private PathFinder.Node FindPathReversed(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	public PathFinder.Node FindClosestWalkable(PathFinder.Point start, int depth = 2147483647) { }

	public bool IsWalkable(PathFinder.Point point) { }

	public bool IsWalkableWithNeighbours(PathFinder.Point point) { }

	public PathFinder.Node Reverse(PathFinder.Node start) { }

	public PathFinder.Node FindEnd(PathFinder.Node start) { }

	public int Cost(PathFinder.Point a) { }

	public int Cost(PathFinder.Point a, PathFinder.Node neighbour) { }

	public int Heuristic(PathFinder.Point a) { }

	public int Heuristic(PathFinder.Point a, PathFinder.Point b) { }

	public int Heuristic(PathFinder.Point a, List<PathFinder.Point> b) { }

	public float Distance(PathFinder.Point a, PathFinder.Point b) { }

	private static void .cctor() { }

}

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 11392
{	public int x; // 0x0
	public int y; // 0x4


	public void .ctor(int x, int y) { }

	public static PathFinder.Point op_Addition(PathFinder.Point a, PathFinder.Point b) { }

	public static PathFinder.Point op_Subtraction(PathFinder.Point a, PathFinder.Point b) { }

	public static PathFinder.Point op_Multiply(PathFinder.Point p, int i) { }

	public static PathFinder.Point op_Division(PathFinder.Point p, int i) { }

	public static bool op_Equality(PathFinder.Point a, PathFinder.Point b) { }

	public static bool op_Inequality(PathFinder.Point a, PathFinder.Point b) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(PathFinder.Point other) { }

}

public class PathFinder.Node : IMinHeapNode<PathFinder.Node>, ILinkedListNode<PathFinder.Node> // TypeDefIndex: 11393
{	public PathFinder.Point point; // 0x10
	public int cost; // 0x18
	public int heuristic; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PathFinder.Node <next>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PathFinder.Node <child>k__BackingField; // 0x28

	public PathFinder.Node next { get; set; }
	public PathFinder.Node child { get; set; }
	public int order { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PathFinder.Node get_next() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_next(PathFinder.Node value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_child(PathFinder.Node value) { }

	public int get_order() { }

	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

