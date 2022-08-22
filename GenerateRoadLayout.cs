public class GenerateRoadLayout : ProceduralComponent // TypeDefIndex: 10505
{	public InfrastructureType RoadType; // 0x28
	public const float RoadWidth = 10;
	public const float TrailWidth = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 8;
	public const float RandomScale = 0,75;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 100000;


	private PathList CreateSegment(int number, Vector3[] points) { }

	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateRoadLayout.PathNode // TypeDefIndex: 10506
{	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20


	public void .ctor() { }

}

private class GenerateRoadLayout.PathSegment // TypeDefIndex: 10507
{	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28


	public void .ctor() { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_0 // TypeDefIndex: 10508
{	public GenerateRoadLayout.PathSegment segment; // 0x10


	public void .ctor() { }

	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 10509
{	public GenerateRoadLayout.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 10510
{	public GenerateRoadLayout.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 10511
{	public GenerateRoadLayout.PathNode node; // 0x10


	public void .ctor() { }

	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 10512
{	public GenerateRoadLayout.PathNode target; // 0x10


	public void .ctor() { }

	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 10513
{	public static readonly GenerateRoadLayout.<>c <>9; // 0x0
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; // 0x8
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; // 0x10
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

