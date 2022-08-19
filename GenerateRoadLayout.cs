public class GenerateRoadLayout : ProceduralComponent // TypeDefIndex: 10505
{	// Fields
	public InfrastructureType RoadType; // 0x28
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

	// Methods

	// RVA: 0xC72600 Offset: 0xC71A00 VA: 0x180C72600
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC72760 Offset: 0xC71B60 VA: 0x180C72760 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

private class GenerateRoadLayout.PathNode // TypeDefIndex: 10506
{	// Fields
	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateRoadLayout.PathSegment // TypeDefIndex: 10507
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_0 // TypeDefIndex: 10508
{	// Fields
	public GenerateRoadLayout.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86C60 Offset: 0xC86060 VA: 0x180C86C60
	internal bool <Process>b__7(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86C60 Offset: 0xC86060 VA: 0x180C86C60
	internal bool <Process>b__10(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_1 // TypeDefIndex: 10509
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86CF0 Offset: 0xC860F0 VA: 0x180C86CF0
	internal bool <Process>b__3(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86D70 Offset: 0xC86170 VA: 0x180C86D70
	internal bool <Process>b__4(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_2 // TypeDefIndex: 10510
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86DF0 Offset: 0xC861F0 VA: 0x180C86DF0
	internal bool <Process>b__5(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86E70 Offset: 0xC86270 VA: 0x180C86E70
	internal bool <Process>b__6(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_3 // TypeDefIndex: 10511
{	// Fields
	public GenerateRoadLayout.PathNode node; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86EF0 Offset: 0xC862F0 VA: 0x180C86EF0
	internal bool <Process>b__8(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86F70 Offset: 0xC86370 VA: 0x180C86F70
	internal bool <Process>b__9(GenerateRoadLayout.PathNode x) { }

}

private sealed class GenerateRoadLayout.<>c__DisplayClass14_4 // TypeDefIndex: 10512
{	// Fields
	public GenerateRoadLayout.PathNode target; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86FF0 Offset: 0xC863F0 VA: 0x180C86FF0
	internal bool <Process>b__11(GenerateRoadLayout.PathSegment x) { }

}

private sealed class GenerateRoadLayout.<>c // TypeDefIndex: 10513
{	// Fields
	public static readonly GenerateRoadLayout.<>c <>9; // 0x0
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_0; // 0x8
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_1; // 0x10
	public static Func<GenerateRoadLayout.PathNode, PathFinder.Point> <>9__14_2; // 0x18

	// Methods

	// RVA: 0xC874E0 Offset: 0xC868E0 VA: 0x180C874E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86A50 Offset: 0xC85E50 VA: 0x180C86A50
	internal PathFinder.Point <Process>b__14_0(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86A50 Offset: 0xC85E50 VA: 0x180C86A50
	internal PathFinder.Point <Process>b__14_1(GenerateRoadLayout.PathNode x) { }

	// RVA: 0xC86A50 Offset: 0xC85E50 VA: 0x180C86A50
	internal PathFinder.Point <Process>b__14_2(GenerateRoadLayout.PathNode x) { }

}

