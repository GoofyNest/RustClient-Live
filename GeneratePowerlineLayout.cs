public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 12226
{
	private const int MaxDepth = 100000;


	public override void Process(uint seed) { }

	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathNode // TypeDefIndex: 12227
{
	public MonumentInfo monument; 
	public PathFinder.Node node; 


	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathSegment // TypeDefIndex: 12228
{
	public PathFinder.Node start; 
	public PathFinder.Node end; 


	public void .ctor() { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_0 // TypeDefIndex: 12229
{
	public GeneratePowerlineLayout.PathSegment segment; 


	public void .ctor() { }

	internal bool <Process>

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 12230
{
	public GeneratePowerlineLayout.PathNode copy; 


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 12231
{
	public GeneratePowerlineLayout.PathNode copy; 


	public void .ctor() { }

	internal bool <Process>

	internal bool <Process>

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 12232
{
	public static readonly GeneratePowerlineLayout.<>c <>9; 
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; 
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal PathFinder.Point <Process>

	internal PathFinder.Point <Process>

}

