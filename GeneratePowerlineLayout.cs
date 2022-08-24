public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 10475
{
	private const int MaxDepth = 100000;


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathNode // TypeDefIndex: 10476
{
	public MonumentInfo monument; 
	public PathFinder.Node node; 


	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathSegment // TypeDefIndex: 10477
{
	public PathFinder.Node start; 
	public PathFinder.Node end; 


	public void .ctor() { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_0 // TypeDefIndex: 10478
{
	public GeneratePowerlineLayout.PathSegment segment; 


	public void .ctor() { }

	internal bool <Process>b__4(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 10479
{
	public GeneratePowerlineLayout.PathNode copy; 


	public void .ctor() { }

	internal bool <Process>b__2(GeneratePowerlineLayout.PathNode x) { }

	internal bool <Process>b__3(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 10480
{
	public GeneratePowerlineLayout.PathNode copy; 


	public void .ctor() { }

	internal bool <Process>b__5(GeneratePowerlineLayout.PathNode x) { }

	internal bool <Process>b__6(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 10481
{
	public static readonly GeneratePowerlineLayout.<>c <>9; 
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; 
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal PathFinder.Point <Process>b__3_0(GeneratePowerlineLayout.PathNode x) { }

	internal PathFinder.Point <Process>b__3_1(GeneratePowerlineLayout.PathNode x) { }

}

