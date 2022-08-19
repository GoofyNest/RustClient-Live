public class WorldSplineSharedData : ScriptableObject // TypeDefIndex: 11411
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<WorldSplineData> dataList; // 0x18
	public static WorldSplineSharedData instance; // 0x0
	private static string[] worldSplineFolders; // 0x8

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x982E0 Offset: 0x976E0 VA: 0x1800982E0
	// RVA: 0x1A90680 Offset: 0x1A8FA80 VA: 0x181A90680
	private static void Init() { }

	// RVA: 0x1A90700 Offset: 0x1A8FB00 VA: 0x181A90700
	public static bool TryGetDataFor(WorldSpline worldSpline, out WorldSplineData data) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

	// RVA: 0x1A908C0 Offset: 0x1A8FCC0 VA: 0x181A908C0
	private static void .cctor() { }

}

