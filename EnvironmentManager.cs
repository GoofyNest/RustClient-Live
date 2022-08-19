public class EnvironmentManager : SingletonComponent<EnvironmentManager> // TypeDefIndex: 9860
{	// Methods

	// RVA: 0x8B9980 Offset: 0x8B8D80 VA: 0x1808B9980
	public static EnvironmentType Get(OBB obb) { }

	// RVA: 0x8B9700 Offset: 0x8B8B00 VA: 0x1808B9700
	public static EnvironmentType Get(Vector3 pos, ref List<EnvironmentVolume> list) { }

	// RVA: 0x8B9810 Offset: 0x8B8C10 VA: 0x1808B9810
	public static EnvironmentType Get(Vector3 pos) { }

	// RVA: 0x8B9560 Offset: 0x8B8960 VA: 0x1808B9560
	public static bool Check(OBB obb, EnvironmentType type) { }

	// RVA: 0x8B93F0 Offset: 0x8B87F0 VA: 0x1808B93F0
	public static bool Check(Vector3 pos, EnvironmentType type) { }

	// RVA: 0x8B9B20 Offset: 0x8B8F20 VA: 0x1808B9B20
	public void .ctor() { }

}

