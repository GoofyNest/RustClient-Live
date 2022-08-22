public abstract class Base : IDisposable // TypeDefIndex: 5283
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	internal static ISteamMatchmakingServers Internal { get; }
	public AppId AppId { get; set; }
	internal int Count { get; }
	internal bool IsRefreshing { get; }


	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_OnChanges(Action value) { }

	public void .ctor() { }

	[AsyncStateMachineAttribute] // RVA: 0xA23C0 Offset: 0xA17C0 VA: 0x1800A23C0
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	public virtual void Cancel() { }

	internal abstract void LaunchQuery();

	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	public void AddFilter(string key, string value) { }

	internal int get_Count() { }

	internal bool get_IsRefreshing() { }

	private void Reset() { }

	private void ReleaseQuery() { }

	public void Dispose() { }

	internal void InvokeChanges() { }

	private void UpdatePending() { }

	public void UpdateResponsive() { }

	private void MovePendingToUnresponsive() { }

	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <MovePendingToUnresponsive>b__34_0(int x) { }

}

private struct Base.<RunQueryAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 5284
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public Base <>4__this; // 0x20
	public float timeoutSeconds; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private HServerListRequest <thisRequest>5__3; // 0x38
	private TaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Base // TypeDefIndex: 6254
{	public string Parent; // 0x10
	public Auth Auth; // 0x18

	public int Version { get; }


	public int get_Version() { }

	public void .ctor() { }

}

