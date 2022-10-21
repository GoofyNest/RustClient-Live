internal class WorkshopItemList : MonoBehaviour // TypeDefIndex: 7751
{
	private static int StaticRefresh; 
	public WorkshopItemButton ButtonPrefab; 
	public GameObject Container; 
	public ListType ListType; 
	private const int PerPage = 50;
	public int Page; 
	public Button PreviousPage; 
	public Button NextPage; 
	public Text PageInfo; 
	public string ItemFilter; 
	public Dropdown ItemTypeSelector; 
	private int ForcedRefresh; 
	private int TotalResults; 
	private bool Refreshing; 

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

	[AsyncStateMachineAttribute] 
	public Task Refresh() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopItemList.<>c // TypeDefIndex: 7752
{
	public static readonly WorkshopItemList.<>c <>9; 
	public static Func<Skinnable, bool> <>9__17_0; 
	public static Func<Skinnable, string> <>9__17_1; 
	public static Func<string, string> <>9__17_2; 
	public static Func<Item, DateTime> <>9__26_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Awake>b__17_0(Skinnable x) { }

	internal string <Awake>b__17_1(Skinnable x) { }

	internal string <Awake>b__17_2(string x) { }

	internal DateTime <Refresh>b__26_0(Item x) { }

}

private struct WorkshopItemList.<Refresh>d__26 : IAsyncStateMachine // TypeDefIndex: 7753
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public WorkshopItemList <>4__this; 
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

