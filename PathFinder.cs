public class PathFinder // TypeDefIndex: 11391
{	// Fields
	private int[,] costmap; // 0x10
	private int[,] visited; // 0x18
	private PathFinder.Point[] neighbors; // 0x20
	private bool directional; // 0x28
	public PathFinder.Point PushPoint; // 0x2C
	public int PushRadius; // 0x34
	public int PushDistance; // 0x38
	public int PushMultiplier; // 0x3C
	private static PathFinder.Point[] mooreNeighbors; // 0x0
	private static PathFinder.Point[] neumannNeighbors; // 0x8

	// Methods

	// RVA: 0x93D1F0 Offset: 0x93C5F0 VA: 0x18093D1F0
	public void .ctor(int[,] costmap, bool diagonals = True, bool directional = True) { }

	// RVA: 0x93CB90 Offset: 0x93BF90 VA: 0x18093CB90
	public int GetResolution(int index) { }

	// RVA: 0x93CB70 Offset: 0x93BF70 VA: 0x18093CB70
	public PathFinder.Node FindPath(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x93C690 Offset: 0x93BA90 VA: 0x18093C690
	private PathFinder.Node FindPathReversed(PathFinder.Point start, PathFinder.Point end, int depth = 2147483647) { }

	// RVA: 0x93C0F0 Offset: 0x93B4F0 VA: 0x18093C0F0
	public PathFinder.Node FindPathDirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x93CAD0 Offset: 0x93BED0 VA: 0x18093CAD0
	public PathFinder.Node FindPathUndirected(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x93C180 Offset: 0x93B580 VA: 0x18093C180
	private PathFinder.Node FindPathReversed(List<PathFinder.Point> startList, List<PathFinder.Point> endList, int depth = 2147483647) { }

	// RVA: 0x93BD40 Offset: 0x93B140 VA: 0x18093BD40
	public PathFinder.Node FindClosestWalkable(PathFinder.Point start, int depth = 2147483647) { }

	// RVA: 0x93CE70 Offset: 0x93C270 VA: 0x18093CE70
	public bool IsWalkable(PathFinder.Point point) { }

	// RVA: 0x93CD20 Offset: 0x93C120 VA: 0x18093CD20
	public bool IsWalkableWithNeighbours(PathFinder.Point point) { }

	// RVA: 0x93CEE0 Offset: 0x93C2E0 VA: 0x18093CEE0
	public PathFinder.Node Reverse(PathFinder.Node start) { }

	// RVA: 0x93C0D0 Offset: 0x93B4D0 VA: 0x18093C0D0
	public PathFinder.Node FindEnd(PathFinder.Node start) { }

	// RVA: 0x93BAF0 Offset: 0x93AEF0 VA: 0x18093BAF0
	public int Cost(PathFinder.Point a) { }

	// RVA: 0x93BC20 Offset: 0x93B020 VA: 0x18093BC20
	public int Cost(PathFinder.Point a, PathFinder.Node neighbour) { }

	// RVA: 0x93CBD0 Offset: 0x93BFD0 VA: 0x18093CBD0
	public int Heuristic(PathFinder.Point a) { }

	// RVA: 0x93CBB0 Offset: 0x93BFB0 VA: 0x18093CBB0
	public int Heuristic(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x93CC40 Offset: 0x93C040 VA: 0x18093CC40
	public int Heuristic(PathFinder.Point a, List<PathFinder.Point> b) { }

	// RVA: 0x93BCB0 Offset: 0x93B0B0 VA: 0x18093BCB0
	public float Distance(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x93CF40 Offset: 0x93C340 VA: 0x18093CF40
	private static void .cctor() { }

}

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 11392
{	// Fields
	public int x; // 0x0
	public int y; // 0x4

	// Methods

	// RVA: 0xF8460 Offset: 0xF7860 VA: 0x1800F8460
	public void .ctor(int x, int y) { }

	// RVA: 0x9519B0 Offset: 0x950DB0 VA: 0x1809519B0
	public static PathFinder.Point op_Addition(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x951A50 Offset: 0x950E50 VA: 0x180951A50
	public static PathFinder.Point op_Subtraction(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x951A30 Offset: 0x950E30 VA: 0x180951A30
	public static PathFinder.Point op_Multiply(PathFinder.Point p, int i) { }

	// RVA: 0x9519D0 Offset: 0x950DD0 VA: 0x1809519D0
	public static PathFinder.Point op_Division(PathFinder.Point p, int i) { }

	// RVA: 0x9519F0 Offset: 0x950DF0 VA: 0x1809519F0
	public static bool op_Equality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0x951A10 Offset: 0x950E10 VA: 0x180951A10
	public static bool op_Inequality(PathFinder.Point a, PathFinder.Point b) { }

	// RVA: 0xFA470 Offset: 0xF9870 VA: 0x1800FA470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFA3C0 Offset: 0xF97C0 VA: 0x1800FA3C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xFA450 Offset: 0xF9850 VA: 0x1800FA450 Slot: 4
	public bool Equals(PathFinder.Point other) { }

}

public class PathFinder.Node : IMinHeapNode<PathFinder.Node>, ILinkedListNode<PathFinder.Node> // TypeDefIndex: 11393
{	// Fields
	public PathFinder.Point point; // 0x10
	public int cost; // 0x18
	public int heuristic; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PathFinder.Node <next>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PathFinder.Node <child>k__BackingField; // 0x28

	// Properties
	public PathFinder.Node next { get; set; }
	public PathFinder.Node child { get; set; }
	public int order { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 7
	public PathFinder.Node get_next() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 8
	public void set_next(PathFinder.Node value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 4
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240 Slot: 5
	public void set_child(PathFinder.Node value) { }

	// RVA: 0x7992A0 Offset: 0x7986A0 VA: 0x1807992A0 Slot: 6
	public int get_order() { }

	// RVA: 0x936B00 Offset: 0x935F00 VA: 0x180936B00
	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

