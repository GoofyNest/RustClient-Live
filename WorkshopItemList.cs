internal class WorkshopItemList : MonoBehaviour // TypeDefIndex: 7743
{	// Fields
	private static int StaticRefresh; // 0x0
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

	// Properties
	private int NumPages { get; }

	// Methods

	// RVA: 0xE97E30 Offset: 0xE97230 VA: 0x180E97E30
	public static void RefreshAll() { }

	// RVA: 0xE98110 Offset: 0xE97510 VA: 0x180E98110
	private int get_NumPages() { }

	// RVA: 0xE978E0 Offset: 0xE96CE0 VA: 0x180E978E0
	private void Awake() { }

	// RVA: 0xE97DF0 Offset: 0xE971F0 VA: 0x180E97DF0
	private void PageNext() { }

	// RVA: 0xE97E10 Offset: 0xE97210 VA: 0x180E97E10
	private void PagePrev() { }

	// RVA: 0xE97D40 Offset: 0xE97140 VA: 0x180E97D40
	public void OnChangedItemType(int type) { }

	// RVA: 0xE98010 Offset: 0xE97410 VA: 0x180E98010
	private void Update() { }

	// RVA: 0xE97FB0 Offset: 0xE973B0 VA: 0x180E97FB0
	public void SwitchToLatest() { }

	// RVA: 0xE97FF0 Offset: 0xE973F0 VA: 0x180E97FF0
	public void SwitchToTrending() { }

	// RVA: 0xE97FD0 Offset: 0xE973D0 VA: 0x180E97FD0
	public void SwitchToPopular() { }

	// RVA: 0xE97F90 Offset: 0xE97390 VA: 0x180E97F90
	public void SwitchToAccepted() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1360 Offset: 0xD0760 VA: 0x1800D1360
	// RVA: 0xE97EA0 Offset: 0xE972A0 VA: 0x180E97EA0
	public Task Refresh() { }

	// RVA: 0xE98100 Offset: 0xE97500 VA: 0x180E98100
	public void .ctor() { }

	// RVA: 0xE980C0 Offset: 0xE974C0 VA: 0x180E980C0
	private static void .cctor() { }

}

private sealed class WorkshopItemList.<>c // TypeDefIndex: 7744
{	// Fields
	public static readonly WorkshopItemList.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__17_0; // 0x8
	public static Func<Skinnable, string> <>9__17_1; // 0x10
	public static Func<string, string> <>9__17_2; // 0x18
	public static Func<Item, DateTime> <>9__26_0; // 0x20

	// Methods

	// RVA: 0xE941E0 Offset: 0xE935E0 VA: 0x180E941E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE93FD0 Offset: 0xE933D0 VA: 0x180E93FD0
	internal bool <Awake>b__17_0(Skinnable x) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440
	internal string <Awake>b__17_1(Skinnable x) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal string <Awake>b__17_2(string x) { }

	// RVA: 0xE93FF0 Offset: 0xE933F0 VA: 0x180E93FF0
	internal DateTime <Refresh>b__26_0(Item x) { }

}

private struct WorkshopItemList.<Refresh>d__26 : IAsyncStateMachine // TypeDefIndex: 7745
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WorkshopItemList <>4__this; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x137510 Offset: 0x136910 VA: 0x180137510 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

