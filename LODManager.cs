public class LODManager : SingletonComponent<LODManager> // TypeDefIndex: 9935
{	// Fields
	public float MaxMilliseconds; // 0x18
	private ListHashSet<ILOD> members; // 0x20
	private Stopwatch watch; // 0x28
	private int offset; // 0x30

	// Methods

	// RVA: 0x6BB8A0 Offset: 0x6BACA0 VA: 0x1806BB8A0
	protected void LateUpdate() { }

	// RVA: 0x6BB7A0 Offset: 0x6BABA0 VA: 0x1806BB7A0
	public static void Add(ILOD component, Transform transform) { }

	// RVA: 0x6BB9F0 Offset: 0x6BADF0 VA: 0x1806BB9F0
	public static void Remove(ILOD component, Transform transform) { }

	// RVA: 0x6BBB20 Offset: 0x6BAF20 VA: 0x1806BBB20
	public void .ctor() { }

}

