public class GenerateRailRing : ProceduralComponent // TypeDefIndex: 10490
{	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 250000;
	public int MinWorldSize; // 0x28


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateRailRing.RingNode // TypeDefIndex: 10491
{	public int attempts; // 0x10
	public PathFinder.Point position; // 0x14
	public PathFinder.Point direction; // 0x1C
	public GenerateRailRing.RingNode next; // 0x28
	public GenerateRailRing.RingNode prev; // 0x30
	public PathFinder.Node path; // 0x38


	public void .ctor(int pos_x, int pos_y, int dir_x, int dir_y, int stepcount) { }

}

