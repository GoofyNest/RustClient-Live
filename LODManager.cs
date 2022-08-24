public class LODManager : SingletonComponent<LODManager> // TypeDefIndex: 9935
{
	public float MaxMilliseconds; 
	private ListHashSet<ILOD> members; 
	private Stopwatch watch; 
	private int offset; 


	protected void LateUpdate() { }

	public static void Add(ILOD component, Transform transform) { }

	public static void Remove(ILOD component, Transform transform) { }

	public void .ctor() { }

}

