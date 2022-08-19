public abstract class Base : IDisposable // TypeDefIndex: 5283
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AppId <AppId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnChanges; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<ServerInfo> OnResponsiveServer; // 0x20
	public List<ServerInfo> Responsive; // 0x28
	public List<ServerInfo> Unresponsive; // 0x30
	internal HServerListRequest request; // 0x38
	internal List<MatchMakingKeyValuePair> filters; // 0x40
	internal List<int> watchList; // 0x48
	internal int LastCount; // 0x50

	// Properties
	internal static ISteamMatchmakingServers Internal { get; }
	public AppId AppId { get; set; }
	internal int Count { get; }
	internal bool IsRefreshing { get; }

	// Methods

	// RVA: 0xDD2680 Offset: 0xDD1A80 VA: 0x180DD2680
	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDD25B0 Offset: 0xDD19B0 VA: 0x180DD25B0
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDD2780 Offset: 0xDD1B80 VA: 0x180DD2780
	public void remove_OnChanges(Action value) { }

	// RVA: 0xDD2440 Offset: 0xDD1840 VA: 0x180DD2440
	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0xA23C0 Offset: 0xA17C0 VA: 0x1800A23C0
	// RVA: 0xDD1F50 Offset: 0xDD1350 VA: 0x180DD1F50 Slot: 5
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDD1BB0 Offset: 0xDD0FB0 VA: 0x180DD1BB0 Slot: 6
	public virtual void Cancel() { }

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void LaunchQuery();

	// RVA: 0xDD1BF0 Offset: 0xDD0FF0 VA: 0x180DD1BF0 Slot: 8
	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	// RVA: 0xDD1B10 Offset: 0xDD0F10 VA: 0x180DD1B10
	public void AddFilter(string key, string value) { }

	// RVA: 0xDD2650 Offset: 0xDD1A50 VA: 0x180DD2650
	internal int get_Count() { }

	// RVA: 0xDD2710 Offset: 0xDD1B10 VA: 0x180DD2710
	internal bool get_IsRefreshing() { }

	// RVA: 0xDD1EF0 Offset: 0xDD12F0 VA: 0x180DD1EF0
	private void Reset() { }

	// RVA: 0xDD1E70 Offset: 0xDD1270 VA: 0x180DD1E70
	private void ReleaseQuery() { }

	// RVA: 0xDD1BE0 Offset: 0xDD0FE0 VA: 0x180DD1BE0 Slot: 4
	public void Dispose() { }

	// RVA: 0xDD1C40 Offset: 0xDD1040 VA: 0x180DD1C40
	internal void InvokeChanges() { }

	// RVA: 0xDD2320 Offset: 0xDD1720 VA: 0x180DD2320
	private void UpdatePending() { }

	// RVA: 0xDD23B0 Offset: 0xDD17B0 VA: 0x180DD23B0
	public void UpdateResponsive() { }

	// RVA: 0xDD1C60 Offset: 0xDD1060 VA: 0x180DD1C60
	private void MovePendingToUnresponsive() { }

	// RVA: 0xDD1CF0 Offset: 0xDD10F0 VA: 0x180DD1CF0
	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDD21C0 Offset: 0xDD15C0 VA: 0x180DD21C0
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDD2050 Offset: 0xDD1450 VA: 0x180DD2050
	private bool <MovePendingToUnresponsive>b__34_0(int x) { }

}

private struct Base.<RunQueryAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 5284
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public Base <>4__this; // 0x20
	public float timeoutSeconds; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private HServerListRequest <thisRequest>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x123550 Offset: 0x122950 VA: 0x180123550 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123560 Offset: 0x122960 VA: 0x180123560 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Base // TypeDefIndex: 6254
{	// Fields
	public string Parent; // 0x10
	public Auth Auth; // 0x18

	// Properties
	public int Version { get; }

	// Methods

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0
	public int get_Version() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

