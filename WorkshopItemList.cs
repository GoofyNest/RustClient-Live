internal class WorkshopItemList : MonoBehaviour // TypeDefIndex: 7743
{	private static int StaticRefresh; // 0x0
	public WorkshopItemButton ButtonPrefab; // 0x18
	public GameObject Container; // 0x20
	public ListType ListType; // 0x28
	private const int PerPage = 50;
	public int Page; // 0x2C
	public Button PreviousPage; // 0x30
	public Button NextPage; // 0x38
	public Text PageInfo; // 0x40
	public string ItemFilter; // 0x48
	public Dropdown ItemTypeSelector; // 0x50
	private int ForcedRefresh; // 0x58
	private int TotalResults; // 0x5C
	private bool Refreshing; // 0x60

	private int NumPages { get; }


	public static void RefreshAll() { }

	private int get_NumPages() { }

	private void Awake() { }

	private void PageNext() { }

	private void PagePrev() { }

	public void OnChangedItemType(int type) { }

	private void Update() { }

	public void SwitchToLatest() { }

	public void SwitchToTrending() { }

	public void SwitchToPopular() { }

	public void SwitchToAccepted() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1360 Offset: 0xD0760 VA: 0x1800D1360
	public Task Refresh() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopItemList.<>c // TypeDefIndex: 7744
{	public static readonly WorkshopItemList.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__17_0; // 0x8
	public static Func<Skinnable, string> <>9__17_1; // 0x10
	public static Func<string, string> <>9__17_2; // 0x18
	public static Func<Item, DateTime> <>9__26_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Awake>b__17_0(Skinnable x) { }

	internal string <Awake>b__17_1(Skinnable x) { }

	internal string <Awake>b__17_2(string x) { }

	internal DateTime <Refresh>b__26_0(Item x) { }

}

private struct WorkshopItemList.<Refresh>d__26 : IAsyncStateMachine // TypeDefIndex: 7745
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WorkshopItemList <>4__this; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

