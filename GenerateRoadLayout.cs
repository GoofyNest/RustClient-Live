public class GenerateRoadLayout : ProceduralComponent // TypeDefIndex: 12275
{
	public InfrastructureType RoadType;
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

private class GenerateRoadLayout.PathNode // TypeDefIndex: 12276
{
	public MonumentInfo monument;
	public TerrainPathConnect target;
	public PathFinder.Node node;


	public void .ctor() { }

}

private class GenerateRoadLayout.PathSegment // TypeDefIndex: 12277
{
	public PathFinder.Node start;
	public PathFinder.Node end;
	public TerrainPathConnect origin;
	public TerrainPathConnect target;


	public void .ctor() { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_0 // TypeDefIndex: 12278
{
	public GenerateRoadLayout.PathSegment segment;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 12279
{
	public GenerateRoadLayout.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 12280
{
	public GenerateRoadLayout.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 12281
{
	public GenerateRoadLayout.PathNode node;


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 12282
{
	public GenerateRoadLayout.PathNode target;


	public void .ctor() { }

	internal bool <Process>

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 12283
{
	public static readonly GenerateRoadLayout.<>c <>9;
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0;
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1;
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal PathFinder.Point <Process>

	internal PathFinder.Point <Process>

	internal PathFinder.Point <Process>

}

