public class SelectedObject : ScriptableObject // TypeDefIndex: 7249
{
	public ERModularRoad roadScr;
	public ERCrossingPrefabs prefabScr;
	public List<int> markers;
	public int startEnd;
	public ERCrossingPrefabs prefab;


	public void Init(ERModularRoad rScr, ERCrossingPrefabs pScr, int marker) { }

	public static SelectedObject CreateInstance(ERModularRoad rScr, ERCrossingPrefabs pScr, int marker) { }

	public void .ctor() { }

}

