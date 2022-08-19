public class VirtualScroll : MonoBehaviour // TypeDefIndex: 11997
{	// Fields
	public int ItemHeight; // 0x18
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

	// Properties
	private int BlockHeight { get; }

	// Methods

	// RVA: 0x798280 Offset: 0x797680 VA: 0x180798280
	public void Awake() { }

	// RVA: 0x798B70 Offset: 0x797F70 VA: 0x180798B70
	public void OnDestroy() { }

	// RVA: 0x798C00 Offset: 0x798000 VA: 0x180798C00
	private void OnScrollChanged(Vector2 pos) { }

	// RVA: 0x799120 Offset: 0x798520 VA: 0x180799120
	public void SetDataSource(VirtualScroll.IDataSource source) { }

	// RVA: 0x7992A0 Offset: 0x7986A0 VA: 0x1807992A0
	private int get_BlockHeight() { }

	// RVA: 0x798910 Offset: 0x797D10 VA: 0x180798910
	public void FullRebuild() { }

	// RVA: 0x798750 Offset: 0x797B50 VA: 0x180798750
	public void DataChanged() { }

	// RVA: 0x798C10 Offset: 0x798010 VA: 0x180798C10
	public void Rebuild() { }

	// RVA: 0x798E90 Offset: 0x798290 VA: 0x180798E90
	private void RecycleOutOfRange(int startVisible, float endVisible) { }

	// RVA: 0x799080 Offset: 0x798480 VA: 0x180799080
	private void Recycle(int key) { }

	// RVA: 0x798410 Offset: 0x797810 VA: 0x180798410
	private void BuildItem(int i) { }

	// RVA: 0x7989D0 Offset: 0x797DD0 VA: 0x1807989D0
	private GameObject GetItem() { }

	// RVA: 0x7991F0 Offset: 0x7985F0 VA: 0x1807991F0
	public void .ctor() { }

}

private sealed class VirtualScroll.<>c__DisplayClass20_0 // TypeDefIndex: 11999
{	// Fields
	public int startVisible; // 0x10
	public float endVisible; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797FE0 Offset: 0x7973E0 VA: 0x180797FE0
	internal bool <RecycleOutOfRange>b__0(int x) { }

}

private sealed class VirtualScroll.<>c // TypeDefIndex: 12000
{	// Fields
	public static readonly VirtualScroll.<>c <>9; // 0x0
	public static Func<int, int> <>9__20_1; // 0x8

	// Methods

	// RVA: 0x798160 Offset: 0x797560 VA: 0x180798160
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x797E80 Offset: 0x797280 VA: 0x180797E80
	internal int <RecycleOutOfRange>b__20_1(int x) { }

}

