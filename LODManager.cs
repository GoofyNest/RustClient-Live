public class LODManager : SingletonComponent<LODManager> // TypeDefIndex: 9935
{	public float MaxMilliseconds; // 0x18
	private ListHashSet<ILOD> members; // 0x20
	private Stopwatch watch; // 0x28
	private int offset; // 0x30


	protected void LateUpdate() { }

	public static void Add(ILOD component, Transform transform) { }

	public static void Remove(ILOD component, Transform transform) { }

	public void .ctor() { }

}

