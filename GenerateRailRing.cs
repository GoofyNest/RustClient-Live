public class GenerateRailRing : ProceduralComponent // TypeDefIndex: 10501
{
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private const int MaxDepth = 250000;
	public int MinWorldSize; 


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GenerateRailRing.RingNode // TypeDefIndex: 10502
{
	public int attempts; 
	public PathFinder.Point position; 
	public PathFinder.Point direction; 
	public GenerateRailRing.RingNode next; 
	public GenerateRailRing.RingNode prev; 
	public PathFinder.Node path; 


	public void .ctor(int pos_x, int pos_y, int dir_x, int dir_y, int stepcount) { }

}

