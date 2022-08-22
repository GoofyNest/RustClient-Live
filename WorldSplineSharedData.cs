public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11411
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8


	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x982E0 Offset: 0x976E0 VA: 0x1800982E0
	private static void Init() { }

	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

