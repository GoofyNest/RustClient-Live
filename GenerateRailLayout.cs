public class GenerateRailLayout : ProceduralComponent // TypeDefIndex: 10485
{	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private static Quaternion rot90; // 0x23F7
	private const int MaxDepth = 250000;


	private PathList CreateSegment(int number, Vector3[] points) { }

	public override void Process(uint seed) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private class GenerateRailLayout.PathNode // TypeDefIndex: 10486
{	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20


	public void .ctor() { }

}

private class GenerateRailLayout.PathSegment // TypeDefIndex: 10487
{	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28


	public void .ctor() { }

}

private sealed class GenerateRailLayout.<>c__DisplayClass13_0 // TypeDefIndex: 10488
{	public PathList rail; // 0x10


	public void .ctor() { }

	internal float <Process>b__0(int i) { }

}

