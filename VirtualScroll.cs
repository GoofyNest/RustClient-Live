public class VirtualScroll : MonoBehaviour // TypeDefIndex: 11997
{	public int ItemHeight; // 0x18
	public int ItemSpacing; // 0x1C
	public RectOffset Padding; // 0x20
	[TooltipAttribute] // RVA: 0xCAD40 Offset: 0xCA140 VA: 0x1800CAD40
	public GameObject DataSourceObject; // 0x28
	public GameObject SourceObject; // 0x30
	public ScrollRect ScrollRect; // 0x38
	public RectTransform OverrideContentRoot; // 0x40
	private VirtualScroll.IDataSource dataSource; // 0x48
	private Dictionary<int, GameObject> ActivePool; // 0x50
	private Stack<GameObject> InactivePool; // 0x58

	private int BlockHeight { get; }


	public void Awake() { }

	public void OnDestroy() { }

	private void OnScrollChanged(Vector2 pos) { }

	public void SetDataSource(VirtualScroll.IDataSource source) { }

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

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 11999
{	public int startVisible; // 0x10
	public float endVisible; // 0x14


	public void .ctor() { }

	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12000
{	public static readonly VirtualScroll.<>c <>9; // 0x0
	public static Func<int, int> <>9__20_1; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

