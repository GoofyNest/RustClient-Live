public class VirtualScroll : MonoBehaviour // TypeDefIndex: 12025
{
	public int ItemHeight; 
	public int ItemSpacing; 
	public RectOffset Padding; 
	[TooltipAttribute] 
	public GameObject DataSourceObject; 
	public GameObject SourceObject; 
	public ScrollRect ScrollRect; 
	public RectTransform OverrideContentRoot; 
	private VirtualScroll.IDataSource dataSource; 
	private Dictionary<int, GameObject> ActivePool; 
	private Stack<GameObject> InactivePool; 

	private int BlockHeight { get; }


	public void Awake() { }

	public void OnDestroy() { }

	private void OnScrollChanged(Vector2 pos) { }

	public void SetDataSource(VirtualScroll.IDataSource source, bool forceRebuild = False) { }

	private int get_BlockHeight() { }

	public void FullRebuild() { }

	public void DataChanged() { }

	public void Rebuild() { }

	private void RecycleOutOfRange(int startVisible, float endVisible) { }

	private void Recycle(int key) { }

	private void BuildItem(int i) { }

	private GameObject GetItem() { }

	public void .ctor() { }

}

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 12027
{
	public int startVisible; 
	public float endVisible; 


	public void .ctor() { }

	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12028
{
	public static readonly VirtualScroll.<>c <>9; 
	public static Func<int, int> <>9__20_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

