public class EnvironmentManager : SingletonComponent<EnvironmentManager> // TypeDefIndex: 11572
{

	public static EnvironmentType Get(OBB obb) { }

	public static EnvironmentType Get(Vector3 pos, ref List<EnvironmentVolume> list) { }

	public static EnvironmentType Get(Vector3 pos) { }

	public static bool Check(OBB obb, EnvironmentType type) { }

	public static bool Check(Vector3 pos, EnvironmentType type) { }

	public void .ctor() { }

}

