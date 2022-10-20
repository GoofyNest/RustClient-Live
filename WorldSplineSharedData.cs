public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 13163
{
	[SerializeField] 
	private List<WorldSplineData> dataList; 
	public static WorldSplineSharedData instance; 
	private static string[] worldSplineFolders; 


	[RuntimeInitializeOnLoadMethodAttribute] 
	private static void Init() { }

	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

