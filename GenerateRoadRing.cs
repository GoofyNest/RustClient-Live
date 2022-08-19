public class GenerateRoadRing : ProceduralComponent // TypeDefIndex: 10515
{	// Fields
	public const float Width = 12;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 8;
	public const float RandomScale = 0,75;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 250000;
	public int MinWorldSize; // 0x28

	// Methods

	// RVA: 0xC749B0 Offset: 0xC73DB0 VA: 0x180C749B0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

private class GenerateRoadRing.RingNode // TypeDefIndex: 10516
{	// Fields
	public int attempts; // 0x10
	public PathFinder.Point position; // 0x14
	public PathFinder.Point direction; // 0x1C
	public GenerateRoadRing.RingNode next; // 0x28
	public GenerateRoadRing.RingNode prev; // 0x30
	public PathFinder.Node path; // 0x38

	// Methods

	// RVA: 0xC869C0 Offset: 0xC85DC0 VA: 0x180C869C0
	public void .ctor(int pos_x, int pos_y, int dir_x, int dir_y, int stepcount) { }

}
