public class GenerateRailRing : ProceduralComponent // TypeDefIndex: 10490
{	// Fields
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 250000;
	public int MinWorldSize; // 0x28

	// Methods

	// RVA: 0xC6CA80 Offset: 0xC6BE80 VA: 0x180C6CA80 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

private class GenerateRailRing.RingNode // TypeDefIndex: 10491
{	// Fields
	public int attempts; // 0x10
	public PathFinder.Point position; // 0x14
	public PathFinder.Point direction; // 0x1C
	public GenerateRailRing.RingNode next; // 0x28
	public GenerateRailRing.RingNode prev; // 0x30
	public PathFinder.Node path; // 0x38

	// Methods

	// RVA: 0xC869C0 Offset: 0xC85DC0 VA: 0x180C869C0
	public void .ctor(int pos_x, int pos_y, int dir_x, int dir_y, int stepcount) { }

}

