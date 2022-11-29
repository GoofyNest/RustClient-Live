public class PathFinder // TypeDefIndex: 13183
{
	private int[,] costmap; 
	private int[,] visited; 
	private PathFinder.Point[] neighbors; 
	private bool directional; 
	public PathFinder.Point PushPoint; 
	public int PushRadius; 
	public int PushDistance; 
	public int PushMultiplier; 
	private static PathFinder.Point[] mooreNeighbors; 
	private static PathFinder.Point[] neumannNeighbors; 


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

public struct PathFinder.Point : IEquatable<PathFinder.Point> // TypeDefIndex: 13184
{
	public int x; 
	public int y; 


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

public class PathFinder.Node : IMinHeapNode<PathFinder.Node>, ILinkedListNode<PathFinder.Node> // TypeDefIndex: 13185
{
	public PathFinder.Point point; 
	public int cost; 
	public int heuristic; 
	[CompilerGeneratedAttribute] 
	private PathFinder.Node <next>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PathFinder.Node <child>k__BackingField; 

	public PathFinder.Node next { get; set; }
	public PathFinder.Node child { get; set; }
	public int order { get; }


	[CompilerGeneratedAttribute] 
	public PathFinder.Node get_next() { }

	[CompilerGeneratedAttribute] 
	public void set_next(PathFinder.Node value) { }

	[CompilerGeneratedAttribute] 
	public PathFinder.Node get_child() { }

	[CompilerGeneratedAttribute] 
	public void set_child(PathFinder.Node value) { }

	public int get_order() { }

	public void .ctor(PathFinder.Point point, int cost, int heuristic, PathFinder.Node next) { }

}

